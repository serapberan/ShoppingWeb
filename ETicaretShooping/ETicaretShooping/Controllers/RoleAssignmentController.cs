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
    [AllowAnonymous]
    [Area("Admin")]
    public class RoleAssignmentController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public RoleAssignmentController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UserList()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> AssingRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x=> x.Id == id);
            var role = _roleManager.Roles.ToList();
            TempData["UserId"] = user.Id;
            var userRole = await _userManager.GetRolesAsync(user);

            List<RoleAssingViewModel> models = new List<RoleAssingViewModel>();

            foreach (var item in role)
            {
                RoleAssingViewModel roleAssingViewModel = new RoleAssingViewModel();
                roleAssingViewModel.Name = item.Name;
                roleAssingViewModel.RoleId = item.Id;
                roleAssingViewModel.Exists = userRole.Contains(item.Name);
                models.Add(roleAssingViewModel);
            }
            return View(models);
        }
    }
}
