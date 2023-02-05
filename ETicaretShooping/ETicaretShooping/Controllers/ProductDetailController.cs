using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using ETicaretShooping.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ETicaretShooping.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly Context _db;
        private readonly IProductService _productService;


        public ProductDetailController(IProductService productService, Context db)
        {
            _productService = productService;
            _db = db;
        }
   

        public IActionResult Index()
        {
            return View();
        }

       [HttpGet]
        public IActionResult ProductDetailPage(int id) //ürüne göre detayı getir
        {
            var values = _productService.TGetById(id);
            return View(values);
        }

       // [HttpPost]
       //// [Authorize]
       // public IActionResult ProductDetailPage(Order Scart) 
       // {
       //     Scart.AppUserId = 0;
       //     if (ModelState.IsValid)
       //     {
       //         var claimsIdentity = (ClaimsIdentity)User.Identity;
       //         var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
       //         Scart.AppUserId = claim.Value;
       //         Order cart = _db.Orders.FirstOrDefault
       //             (U => U.AppUserId == Scart.AppUserId && U.ProductId == Scart.ProductId);
       //         if (cart == null)
       //         {
       //             _db.Orders.Add(Scart);
       //         }
       //         else
       //         {
       //             cart.Count += Scart.Count;
       //         }
       //         _db.SaveChanges();
       //         //tüm sipariş verenlerin sayısını sessionda tutuyoruz
       //         var count = _db.Orders.Where(i => i.ApplicationUserId == Scart.ApplicationUserId).ToList().Count();
       //         HttpContext.Session.SetInt32(Diger.sShoppingCart, count);
       //         return RedirectToAction(nameof(Index));
       //     }
       //     else
       //     {
       //         var product = _db.Products.FirstOrDefault(i => i.Id == Scart.Id); //sadece o ait ürün bilgisi gelecek
       //         ShoppingCart cart = new ShoppingCart()
       //         {
       //             Product = product,
       //             ProductId = product.Id
       //         };
       //     }

       //     return View(Scart);
       // }
    }
}
