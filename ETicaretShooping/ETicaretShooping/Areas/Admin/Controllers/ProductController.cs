using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using ETicaretShooping.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Areas.Admin.Controllers
{

    [Area("Admin")]
    //[Authorize(Roles = "Admin")]
     [Route("Admin/Product")]
    //[Route("Admin/[controller]/[action]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    
        public ProductController(IProductService productService)
        {
            _productService = productService;
          
        }

        //................................Ürün Listesi.......................................
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _productService.TList();
            return View(values);
        }

        //................................Ürün EKLEME.......................................
        [Route("AddProduct")]
        [HttpGet]
        public IActionResult AddProduct()
        {
                List<SelectListItem> values = (from x in categoryManager.TList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();
                ViewBag.v = values;
                return View();
            }
        [Route("AddProduct")]
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product p)
        {

            //var resource = Directory.GetCurrentDirectory();
            //var extension = Path.GetExtension(p.ImageUrl.FileName);
            //var imagename = Guid.NewGuid() + extension;  //resim ismi karışmaması için rastgele üret
            //var savelocation = resource + "/wwwroot/images/productimages" + imagename;
            //var stream = new FileStream(savelocation, FileMode.Create); //stream akışı yönlendir
            //await p.ImageUrl.CopyToAsync(stream);
            //p.ImageUrl = p.ImageUrl;


            _productService.TAdd(p);
            return RedirectToAction("Index", "Product");
        }



        //................................ÜRÜN GÜNCELLEME.......................................
       [Route("UpdateProduct")]
        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {

            List<SelectListItem> values = (from x in categoryManager.TList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            var prdId = _productService.TGetById(id);
            ViewBag.v = values;
            return View(prdId);
         
        }

        [Route("UpdateProduct")]
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            _productService.TUpdate(product);
            return RedirectToAction("Index", "Product");
        }

        [Route("ChangeTrue/{id}")]

        public async Task<IActionResult> ChangeTrue(int id)  //aktif
        {
            _productService.TProductBySelectTrue(id);
            return RedirectToAction("Index", "Product", new { area = "Admin" });
        }

       [Route("ChangeFalse/{id}")]

        public async Task<IActionResult> ChangeFalse(int id)  //pasif
        {
            _productService.TProductBySelectFalse(id);
            return RedirectToAction("Index", "Product", new { area = "Admin" });
        }
    }
}
