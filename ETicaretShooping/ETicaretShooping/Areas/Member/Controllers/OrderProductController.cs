using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class OrderProductController : Controller
    {
        private readonly Context _db;
        private readonly ProductManager _productManager;

        public OrderProductController(Context db, ProductManager productManager)
        {
            _db = db;
            _productManager = productManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductDetails(int id)  //Ürğn detay sayfası
        {
            var product = _productManager.TGetById(id);
            Cart cart = new Cart()
            {
                Product = product,
                ProductId = product.ProductId
            };
            return View(product);
        }
    }
}
