using Entities.Concrete;
using ETicaretShooping.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles = "Member")]
    public class EditProfileController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly IFileProvider _fileProvider;
        public EditProfileController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, IFileProvider fileProvider)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _fileProvider = fileProvider;
        }

        public async Task<IActionResult> UserEdit()
        {
            ViewBag.genderList = new SelectList(Enum.GetNames(typeof(Gender)));
            var currentUser = (await _userManager.FindByNameAsync(User.Identity!.Name!))!;
            ViewBag.userImage = currentUser.ImageURL;
            var userEditViewModel = new UserEditWiewModel()
            {
                UserName = currentUser.UserName,
                Email = currentUser.Email,
                Phone = currentUser.PhoneNumber,
                BirthDate = currentUser.BirthDate,
                City = currentUser.City,
                Gender = (Gender)currentUser.Gender,

            };

            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UserEdit(UserEditWiewModel p)
        {
            // if (ModelState.IsValid)
            // {
            //     return View();
            // }

            // var currentUser = await _userManager.FindByNameAsync(User.Identity.Name!);

            // currentUser.UserName = request.UserName;
            // currentUser.Email = request.Email;
            // currentUser.PhoneNumber = request.Phone;
            // currentUser.BirthDate = request.BirthDate;
            // currentUser.City = request.City;
            // currentUser.Gender = (Gender)request.Gender;

            // if (request.ImageURL != null && request.ImageURL.Length > 0)
            // {
            //     var wwwrootFolder = _fileProvider.GetDirectoryContents("wwwroot");

            //     string randomFileName = $"{Guid.NewGuid().ToString()}{Path.GetExtension(request.ImageURL.FileName)}";

            //     var newPicturePath = Path.Combine(wwwrootFolder!.First(x => x.Name == "userimages").PhysicalPath!, randomFileName);

            //     using var stream = new FileStream(newPicturePath, FileMode.Create);

            //     await request.ImageURL.CopyToAsync(stream);

            //     currentUser.ImageURL = randomFileName;
            // }

            // var updateToUserResult = await _userManager.UpdateAsync(currentUser);

            // //if (!updateToUserResult.Succeeded)
            // //{
            // //    ModelState.AddModelError("", "Bir hata oluştu");
            // //    //ModelState.AddModelErrorList(updateToUserResult.Errors);
            // //    return View();
            // //}

            // await _userManager.UpdateSecurityStampAsync(currentUser);
            // await _signInManager.SignOutAsync();
            // await _signInManager.SignInAsync(currentUser, true);
            //// await _signInManager.SignInAsync(currentUser, true);
            // //if (request.BirthDate.HasValue)
            // //{
            // //    await _signInManager.SignInWithClaimsAsync(currentUser, true, new[] { new Claim("birthdate", currentUser.BirthDate!.Value.ToString()) });
            // //}

            // //else
            // //{
            // //    await _signInManager.SignInAsync(currentUser, true);
            // //}


            // TempData["SuccessMessage"] = "Üye bilgileri başarıyla değiştirilmiştir";

            // var userEditViewModel = new UserEditWiewModel()
            // {
            //     UserName = currentUser.UserName!,
            //     Email = currentUser.Email!,
            //     Phone = currentUser.PhoneNumber!,
            //     BirthDate = currentUser.BirthDate,
            //     City = currentUser.City,
            //     Gender = (Gender?)currentUser.Gender,
            // };

            // return View(userEditViewModel);

            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.userImage = user.ImageURL;
            if (p.ImageURL != null && p.ImageURL.Length > 0)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.ImageURL.FileName);
                var imagename = Guid.NewGuid() + extension;  //resim ismi karışmaması için rastgele üret
                var savelocation = resource + "/wwwroot/userimages/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create); //stream akışı yönlendir
                await p.ImageURL.CopyToAsync(stream);
                user.ImageURL = imagename;
            }
            user.UserName = p.UserName;
            user.PhoneNumber = p.Phone;
            user.Email = p.Email;
            user.City = p.City;
            user.PhoneNumber = p.Phone;
            user.BirthDate = p.BirthDate;
            user.Gender = (Gender)p.Gender;

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }

            return View();
        }
    }
}
