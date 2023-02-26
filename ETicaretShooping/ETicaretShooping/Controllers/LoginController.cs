using Entities.Concrete;
using ETicaretShooping.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ETicaretShooping.Controllers
{
    [AllowAnonymous]  //kuralları muafet 
    public class LoginController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;

        }


        [HttpGet]
        public IActionResult SignUp() //Kullanıcı kayıt
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel p) //Kullanıcı kayıt
        {
            AppUser appUser = new AppUser()
            {
                Name = p.Name,
                Surname = p.SurName,
                UserName = p.UserName,
                Email = p.Email
            };
            if (p.Password == p.ConfigPassword)
            {
                var result = await _userManager.CreateAsync(appUser, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }

        //.......................................Login işlemleri....................................................

        [HttpGet]
        public IActionResult SignIn()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserSignInViewModel request, string returnUrl = null)
        {

           // returnUrl = returnUrl ?? Url.Action("Index", "Profile", new { area = "Member" });  //kullanıcı bir önceki syf tutup oraya yönlendiricez
            returnUrl = returnUrl ?? Url.Action("Index", "Anasayfa");  //kullanıcı bir önceki syf tutup oraya yönlendiricez

            var hasUser = await _userManager.FindByEmailAsync(request.EMail);
           
            if (hasUser == null)
            {
                ModelState.AddModelError(string.Empty, "Email veya şifre Hatalı");
                return View();
            }

            var signInresult = await _signInManager.PasswordSignInAsync(hasUser, request.Password, request.RememberMe, true); //RememberMe --> beni hatırla seçili ise 60 gün boyunca ccooki aktif olacak

            if (signInresult.Succeeded )
            {
                return Redirect(returnUrl);

            }
            if (signInresult.IsLockedOut)
            {
                ModelState.AddModelError("", "Hatalı Denemeler Sonucu 3 Dk. Boyunca Giriş Yapamazsınız!");
                return View();
            }

            ModelState.AddModelError("", $"Hatalı Giriş Sayısı:{await _userManager.GetAccessFailedCountAsync(hasUser)}");

            return View();

        }


        //..............................................Şifremi Unuttum...........................................
        [AllowAnonymous]
        [HttpGet]
        public IActionResult ForgetPassword()   //Şifremi Unuttum
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult ForgetPassword(ForgetPasswordViewModel request)
        {
            AppUser user = _userManager.FindByEmailAsync(request.Email).Result;  //kullanıcıyı bul
            if (user != null)
            {
                string forgetPassworToken = _userManager.GeneratePasswordResetTokenAsync(user).Result;   
                string forgetPasswordLink = Url.Action("ResetPassword", "Login", new { userId = user.Id, Token = forgetPassworToken }, HttpContext.Request.Scheme);

                MailHelper.ForgetPassword.SendResetPasswordEmail(forgetPasswordLink,user.Email);

                TempData["SuccessMessage"] = "Şifre yenileme linki, eposta adresinize gönderilmiştir";
            }
            else
            {
                ModelState.AddModelError("", "Bu email adresine sahip kullanıcı bulunamamıştır.");
                return View();
            }
            
            return View(request);
        }


        //..............................................Şifre Yenileme...........................................

        [AllowAnonymous]
        public IActionResult ResetPassword(string userId, string token)
        {
            TempData["userId"] = userId;
            TempData["token"] = token;
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel request)
        {
            var userId = TempData["userId"];
            var token = TempData["token"];

            if (userId == null || token == null)
            {
                throw new Exception("Bir hata meydana geldi");
            }

            var hasUser = await _userManager.FindByIdAsync(userId.ToString()!);

            if (hasUser == null)
            {
                ModelState.AddModelError(String.Empty, "Kullanıcı bulunamamıştır.");
                return View();
            }

            IdentityResult result = await _userManager.ResetPasswordAsync(hasUser, token.ToString()!, request.Password);  //şifreyi yeniledi

            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = "Şifreniz başarıyla yenilenmiştir";
            }
            else
            {
                ModelState.AddModelError("", "Şifre yenileme işlemmi gerçekleştirilemedi. İşlem Başarısız!");
            }

            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

        //..............................................Çıkış Yap...........................................
        public async Task<IActionResult> LogOut()   //Çıkış Yap
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Anasayfa");
        }

    }
}
