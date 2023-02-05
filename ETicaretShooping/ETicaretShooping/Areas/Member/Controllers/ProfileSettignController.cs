using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Areas.Member.Controllers
{
    public class ProfileSettignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
