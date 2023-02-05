using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.ViewComponents
{
    public class _DiscountComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var db = new Context();
            ViewBag.v1 = db.Categories.Count();
            ViewBag.v2 = db.Products.Count();
            return View();
        }
    }
}
