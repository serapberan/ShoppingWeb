using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using ETicaretShooping.Areas.Admin.Models;
using ETicaretShooping.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<AppUser> _userManager;
       // private readonly CartManager _cartManager;

        public ProductDetailController(IProductService productService, Context db, UserManager<AppUser> userManager)
        {
            _productService = productService;
            _db = db;
            _userManager = userManager;
          //  _cartManager = cartManager;
           
        }


        public IActionResult Index()
        {
            return View();
        }

       [HttpGet]
        public async Task<IActionResult> ProductDetailPage(int id) //ürüne göre detayı getir
        {
            var values = _productService.TGetById(id);
            return View(values);
        }

        [HttpPost]
       // [ValidateAntiForgeryToken] //email girişi olmadan sepete ekleme olmasın
       // [Authorize]
        public IActionResult Details(Cart Scart)
        {
            Scart.CartId = 0;
            if (ModelState.IsValid)
            {
                var claimsIdentity = (ClaimsIdentity)User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                string appUser = Scart.AppUserId.ToString();
                appUser = claim.Value;
                Cart cart = _db.Carts.FirstOrDefault
                    (U => U.AppUserId == Scart.AppUserId && U.ProductId == Scart.ProductId);
                if (cart == null)
                {
                    _db.Carts.Add(Scart);
                }
                else
                {
                    cart.Count += Scart.Count;
                }
             
                _db.SaveChanges();
                //tüm sipariş verenlerin sayısını sessionda tutuyoruz
                var count = _db.Carts.Where(i => i.AppUserId == Scart.AppUserId).ToList().Count();
               // HttpContext.Session.SetInt32(Diger.sCart, count);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                var product = _db.Products.FirstOrDefault(i => i.ProductId == Scart.ProductId); //sadece o ait ürün bilgisi gelecek
               Cart cart = new Cart()
                {
                    Product = product,
                    ProductId = product.ProductId,
                    Date = DateTime.Now,
                    Count = 1,
                    Price = product.Price,
                    Quantity =1
                    
               };
            }

          
            return View(Scart);
        }

        [AllowAnonymous]
        public IActionResult List()
        {
            var values = _productService.TList();
            return View(values);
        }






    }
}
