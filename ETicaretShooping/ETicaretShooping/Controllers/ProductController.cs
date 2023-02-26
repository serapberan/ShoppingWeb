using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Controllers
{
    [AllowAnonymous]
    public class ProductController : Controller
    {
        private readonly Context _db;
        private readonly ProductManager _productManager;
        

        public ProductController(Context db, ProductManager productManager)
        {
            _db = db;
            _productManager = productManager;

        }

        public IActionResult Search(string search)
        {
            var find = _db.Products.Where(x => x.Name.Contains(search) && x.Category.Name.Contains(search) && x.Description.Contains(search)).ToList();


            var imagelist = _productManager.TGetList(x => x.Status == true);


            var bluz = _productManager.TGetList(x => x.Status == true && x.Category.Name == "TShirts & Bluz");
            ViewBag.computer = bluz;

            var gömlek = _productManager.TGetList(x => x.Status == true && x.Category.Name == "Gömlek");
            ViewBag.computerimage = gömlek;


            var hırka = _productManager.TGetList(x => x.Status == true && x.Category.Name == "Hırka");
            ViewBag.computerimage = hırka;


            var pantolon = _productManager.TGetList(x => x.Status == true && x.Category.Name == "Pantolon");
            ViewBag.computerimage = pantolon;


            var jean = _productManager.TGetList(x => x.Status == true && x.Category.Name == "Jean");
            ViewBag.computerimage = jean;

      



            var elbise = _productManager.TGetList(x => x.Status == true && x.Category.Name == "Elbise");
            ViewBag.computerimage = elbise;


            var ceket = _productManager.TGetList(x => x.Status == true && x.Category.Name == "Ceket");
            ViewBag.computerimage = ceket;


            var kaban = _productManager.TGetList(x => x.Status == true && x.Category.Name == "Kaban");
            ViewBag.computerimage = kaban;


            var mont = _productManager.TGetList(x => x.Status == true && x.Category.Name == "Mont");
            ViewBag.computerimage = mont;

            return View(find);
        }

    }
}
