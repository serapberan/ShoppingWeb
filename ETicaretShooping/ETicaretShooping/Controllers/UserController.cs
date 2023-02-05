using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using ETicaretShooping.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace ETicaretShooping.Controllers
{
    [AllowAnonymous]
    [Authorize(Roles = "User")]
    public class UserController : Controller
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        private RoleManager<AppRole> _roleManager;

        OrderManager orderManager = new OrderManager(new EfOrderDal());
        CartManager cartManager = new CartManager(new EfCartDal());
        FavoriteManager favoriteManager = new FavoriteManager(new EfFavoriteDal());
        Context db = new Context();

        public UserController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }


        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByNameAsync(model.UserName);

            if (user == null)
            {

                ModelState.AddModelError("", " Hatalı lütfen bilgilerinizi kontrol ediniz");

            }
            if (await _userManager.IsLockedOutAsync(user))
            {
                ModelState.AddModelError("", "Hesabınız bir süreliğine kilitlendi");
            }
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, true);
            if (result.Succeeded)
            {
                await _userManager.ResetAccessFailedCountAsync(user);
                // HttpContext.Session.SetString("FullName", user.Email);
                HttpContext.Session.SetString("Name", user.Name);
                HttpContext.Session.SetString("SurName", user.Surname);
                HttpContext.Session.SetString("Username", user.UserName);
                HttpContext.Session.SetString("Email", user.Email);
                HttpContext.Session.SetInt32("Id", user.Id);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                await _userManager.AccessFailedAsync(user);

                int fail = await _userManager.GetAccessFailedCountAsync(user);
                if (fail == 3)
                {
                    await _userManager.SetLockoutEndDateAsync(user, new DateTimeOffset(DateTime.Now.AddMinutes(2)));
                    ModelState.AddModelError("", "Hesabınız 3 başarısız girişten dolayı 2 dakika süreyle kilitlenmiştir. Daha sonra tekrar deneyiniz");
                }
                else
                {
                    ModelState.AddModelError("", "Geçersiz eposta veya şifre");
                }
            }
            return View();

        }


        [AllowAnonymous]
        public IActionResult LogOut()
        {
            _signInManager.SignOutAsync();
            HttpContext.Session.Remove("Id");
            return RedirectToAction("Index", "Home");
        }


        //public IActionResult ProfileUpdate()
        //{
        //    AppUser user = _userManager.FindByNameAsync(User.Identity.Name).Result;
        //    ProfileUpdateViewModel userViewModel = user.Adapt<ProfileUpdateViewModel>();  //adapt araştır
        //    return View(userViewModel);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProfileUpdate(ProfileUpdateViewModel userModel)
        {
            ModelState.Remove("Password");
            ModelState.Remove("RePassword");

            if (ModelState.IsValid)
            {

                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.UserName = userModel.UserName;
                user.Email = userModel.Email;
                user.Name = userModel.Name;
                user.Surname = userModel.SurName;
                IdentityResult result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    await _userManager.UpdateSecurityStampAsync(user);
                    await _signInManager.SignOutAsync();
                    await _signInManager.SignInAsync(user, true);
                    ViewBag.success = "Bilgileriniz Başarıyla Güncellenmiştir";


                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", "Bir Hata Oluştu");
                    }
                }
            }

            return View(userModel);
        }


        public void TotalAmount(int id, int qnumber)  //toplam tutar  qnumber-->adet
        {
            var values = cartManager.TGetById(id);
            values.Quantity = qnumber;
            values.Price = values.Price * values.Quantity;
            cartManager.TUpdate(values);

        }


        public ActionResult ProductDown(int id)  //ürün eksiltme
        {
            var values = cartManager.TGetById(id);
            if (values.Quantity == 1)
            {
                cartManager.TDelete(values);

            }
            values.Quantity--;
            values.Price = values.Price * values.Quantity;
            cartManager.TUpdate(values);
            return RedirectToAction("Index", "Cart");
        }


        public ActionResult ProductUp(int id) //Ürün arttır
        {
            var values = cartManager.TGetById(id);
            values.Quantity++;
            values.Price = values.Price * values.Quantity;
            cartManager.TUpdate(values);

            return RedirectToAction("Index", "Cart");
        }

        public IActionResult UserCartList()
        {
            var userauthenticationid = HttpContext.Session.GetInt32("Id");
            var username = User.Identity.Name;
            // var user = db.UserAdmins.FirstOrDefault(x => x.Email == username);
            var user = _userManager.FindByNameAsync(username);
            var model = cartManager.TGetList(x => x.AppUser.Id == userauthenticationid);
            //var userid = db.UserAdmins.FirstOrDefault(x => x.Id == userauthenticationid);
            var userid = _userManager.FindByIdAsync(username);
            if (userauthenticationid == null)
            {
                return View("LoginCheck");
            }

            if (model != null)
            {
                if (userid == null)
                {
                    ViewBag.Total = "Sepetinizde ürün bulunmamaktadır";
                }

                else if (userid != null)
                {
                    var Total = db.Carts.Where(x => x.AppUserId == userid.Id).Sum(x => x.Product.Price * x.Quantity);

                    Total = Math.Round(Total, 0);
                    ViewBag.Total = "Toplam Tutar =" + Total + "TL";
                }
                ViewBag.id = TempData["Id"];
                return View(model);

            }
            return NotFound();
        }

        public IActionResult FavoriteProducts()
        {
            var user = HttpContext.Session.GetString("Id");
            //var favoritelist = favoriteManager.TGetList(x => x.Id == AppUser.);
            return View();
        }

    }
}
