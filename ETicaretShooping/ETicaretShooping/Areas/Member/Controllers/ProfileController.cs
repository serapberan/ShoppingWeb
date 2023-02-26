using Entities.Concrete;
using ETicaretShooping.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ETicaretShooping.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles = "Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
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
            userEditViewModel.City = values.City;
            ViewBag.userImage = values.ImageURL;
            return View(userEditViewModel);
        }


    }
}
