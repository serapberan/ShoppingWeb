using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using ETicaretShooping.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Controllers
{
    [AllowAnonymous]  //kuralları muaf et 
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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
                var result = await _userManager.CreateAsync(appUser,p.Password);
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


        [HttpGet]
        public IActionResult SignIn()  //Login işlemleri için
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserSignInViewModel u)
        {
            var result = await _signInManager.PasswordSignInAsync(u.UserName, u.Password, false, true);
            if (result.Succeeded)
            {
                //var values = await _userManager.FindByNameAsync(User.Identity.Name);
                //ViewBag.name = values.Name;
                //ViewBag.surname = values.Surname;
                //ViewBag.username = values.UserName;
                //ViewBag.ımg = values.ImageURL;
                return RedirectToAction("Index", "Profile", new { area = "Admin" });
                // return RedirectToAction("Index", "Anasayfa");
            }
            else
            {
                return RedirectToAction("SingIn", "Login");
            }
            return View(u);
        }

    }
}
