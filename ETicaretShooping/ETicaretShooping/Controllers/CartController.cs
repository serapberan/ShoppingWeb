using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using ETicaretShooping.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ETicaretShooping.Controllers
{
    
    public class CartController : Controller
    {
        private readonly Context _context;
        private readonly ICartService _cartService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CartController(Context context, ICartService cartService, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _cartService = cartService;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index(decimal? tprice) //sepet boş olabilir null olmasın  totalprice
        {
            //if (User.Identity.IsAuthenticated)  //giriş yapan kullanıcı alışveriş yapacak
            //{
            //    var username = User.Identity.Name;
            //    var member = _context.Users.FirstOrDefault(x => x.UserName == username);
            //    var model = _context.Carts.Where(x => x.AppUserId == member.Id).ToList();  //hangi kullanıcı ne ürün ekledi
            //    var mId = _context.Carts.FirstOrDefault(x => x.AppUserId == member.Id); //kullanıcı Id bul
            //    if (model != null)
            //    {
            //        if (mId == null)  //sepette ürün yok
            //        {
            //            ViewBag.tprice = "Sepetizde ürün bulunmamaktadır!";
            //        }
            //        else if (mId != null)
            //        {
            //            var total = _context.Carts.Where(x => x.AppUserId == mId.AppUserId).Sum(x => x.Price * x.Quantity);
            //            total = Math.Round(total, 0);
            //            ViewBag.Total = "Toplam Tutar =" + total + "TL";

            //        }
            //        ViewBag.id = TempData["Id"];
            //        return View(model);
            //    }
            //}
            //return NotFound();
            return View();
        }

        public IActionResult AddCart(int id)
        {

            if (User.Identity.IsAuthenticated)
            {
                var uName = User.Identity.Name;
                var model = _context.Users.FirstOrDefault(x => x.UserName == uName);
                var pId = _context.Products.Find(id);
                var sepet = _context.Carts.FirstOrDefault(x => x.AppUserId == model.Id && x.ProductId == model.Id);
                if (sepet != null)
                {
                    sepet.Quantity++;
                    sepet.Price = pId.Price * sepet.Quantity;
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Cart");

                }
                var s = new Cart
                {
                    AppUserId = model.Id,
                    ProductId = pId.ProductId,
                    //ProductImage = pId.Images.Where(x => x.ProductId == pId.ProductId).Select(y => y.ImageName).FirstOrDefault(),
                    Quantity = 1,
                    Price = pId.Price,
                    Date = DateTime.Now
                };
                _cartService.TAdd(s);
                _context.SaveChanges();
                return RedirectToAction("Index", "Cart");

            }
            return View();
       

        }


        //public IActionResult Details(ShoopingCart Scart)
        //{
        //    Scart.Id = 0;
        //    if (ModelState.IsValid)
        //    {
        //        var claimsIdentity = (ClaimsIdentity)User.Identity;
        //        var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
        //        Scart.AppUser.Name = claim.Value;
        //        Cart cart = _context.Carts.FirstOrDefault
        //            (U => U.AppUserId == Scart.AppUserId && U.ProductId == Scart.ProductId);
        //        if (cart == null)
        //        {
        //            _cartService.TAdd(cart);
        //        }
        //        else
        //        {
        //            cart.Count += cart.Count;
        //        }
        //        _context.SaveChanges();
        //        //tüm sipariş verenlerin sayısını sessionda tutuyoruz
        //        var count = _context.ShoppingCarts.Where(i => i.ApplicationUserId == Scart.ApplicationUserId).ToList().Count();
        //        HttpContext.Session.SetInt32(Diger.sShoppingCart, count);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    else
        //    {
        //        var product = _db.Products.FirstOrDefault(i => i.Id == Scart.Id); //sadece o ait ürün bilgisi gelecek
        //        ShoppingCart cart = new ShoppingCart()
        //        {
        //            Product = product,
        //            ProductId = product.Id
        //        };
        //    }

        //    return View(Scart);
        //}
        public IActionResult Privacy()
        {
            return View();
        }

    }
}