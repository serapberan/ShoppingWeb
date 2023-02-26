using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using ETicaretShooping.Areas.Admin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class ProfileController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly IAppUserService _appUserService;
        private readonly IOrderService _orderService;

        public ProfileController(UserManager<AppUser> userManager, IAppUserService appUserService, IOrderService orderService)
        {
            _userManager = userManager;
            _appUserService = appUserService;
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()   //Sisteme giiriş yapan kullanıcı bilgisini getiriyoruz
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditProfileViewModel userEditViewModel = new UserEditProfileViewModel();
            userEditViewModel.Name = values.Name;
            userEditViewModel.Surname = values.Surname;
            userEditViewModel.Phonenumber = values.PhoneNumber;
            userEditViewModel.Email = values.Email;
            userEditViewModel.ImageURL = values.ImageURL;

            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditProfileViewModel p)   //Kullanıcıyı bulalaım ve bilgileri Güncelliyecek
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);


            if (p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imagename = Guid.NewGuid() + extension;  //resim ismi karışmaması için rastgele üret
                var savelocation = resource + "/wwwroot/userimages/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create); //stream akışı yönlendir
                await p.Image.CopyToAsync(stream);
                user.ImageURL = imagename;
            }
            user.Name = p.Name;
            user.Surname = p.Surname;
            user.PhoneNumber = p.Phonenumber;
            user.Email = p.Email;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }

            return View();
        }

        public IActionResult RegisterUserList()  //kAYITLI KULLANICILAR
        {
            var values = _appUserService.TList();
            return View(values);
        }


        public IActionResult DeliveredUserList(int id) //KULLANICI ALIŞVERİŞ GEÇMİŞLERİ
        {
            var result = _orderService.TGetList(x=> x.AppUserId == id);
            return View(result);
        }

    }
}

