using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles = "Member")]
    public class ShoopignProductController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        IOrderService _orederService;
        public ShoopignProductController(UserManager<AppUser> userManager, IOrderService orderService)
        {
            _userManager = userManager;
            _orederService = orderService;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Product p)
        {
            return View();
        }


        public async Task<IActionResult> MyApprovalProduct()  //hazırlanma asamasında  Siparişler
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name;
            var valueList = _orederService.GetListMyApprovalProduct(values.Id);
            return View(valueList);
        }

        public async Task<IActionResult> MyCargoProduct()   // kargodaki siparişler
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name;
            var valueList = _orederService.GetListMyCargoProduct(values.Id);
            return View(valueList);

        }

        public async Task<IActionResult> MyDeliveredProduct()   // teslim edilen siparişler
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name;
            var valueList = _orederService.GetListMyDeliveredProduct(values.Id);
            return View(valueList);

        }

        public async Task<IActionResult> MyOldProduct()   //eski siparişler
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name;
            var valueList = _orederService.GetListMyOldProduct(values.Id);
            return View(valueList);
        }
    }
}
