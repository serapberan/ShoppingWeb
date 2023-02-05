using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.name = values.Name + " " + values.Surname;
            ViewBag.userName=values.UserName;
            ViewBag.userImage=values.ImageURL;
            return View();
        }
    }
}
