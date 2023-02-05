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
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(AppRole appRole)
        {
            var result = await  _roleManager.CreateAsync(appRole);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteRol(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            var result = await _roleManager.DeleteAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(AppRole appRole)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == appRole.Id);
            values.Name = appRole.Name;
            var result = await _roleManager.UpdateAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
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
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
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

        [HttpGet]
        public async Task<IActionResult> AssignRole2(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            var roles = _roleManager.Roles.ToList();

            TempData["UserId"] = user.Id;

            var userRoles = await _userManager.GetRolesAsync(user);

            List<RoleAssingViewModel> models = new List<RoleAssingViewModel>();

            foreach (var item in roles)
            {
                RoleAssingViewModel m = new RoleAssingViewModel();
                m.RoleId = item.Id;
                m.Name = item.Name;
                m.Exists = userRoles.Contains(item.Name);
                models.Add(m);
            }
            return View(models);
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole2(List<RoleAssingViewModel> model)
        {
            var userid = (int)TempData["Userid"];
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userid);

            foreach (var item in model)
            {
                if (item.Exists)
                {
                    await _userManager.AddToRoleAsync(user, item.Name);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.Name);
                }
            }
            return RedirectToAction("UserList");

        }

    }
}
