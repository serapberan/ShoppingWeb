using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        //................................KATEGORY LİSTESİ.......................................
        public IActionResult Index()  //category Listesi
        {
            var values = _categoryService.TList();
            return View(values);
        }

        //................................KATEGORY EKLEME.......................................
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.TAdd(category);
            return RedirectToAction("Index");
        }

        //................................KATEGORY SİLME.......................................
        public IActionResult DeleteCategory(int id)   //silme çalışmıyor bak 
        {
            var values = _categoryService.TGetById(id);
            _categoryService.TDelete(values);
            return RedirectToAction("Index");
        }

        //................................KATEGORY GÜNCELLEME.......................................
        [HttpGet]
        public IActionResult CategoryUpdate(int id )
        {
            var values = _categoryService.TGetById(id);
            return View(values);
        }


        [HttpPost]
        public async Task <IActionResult> CategoryUpdate(Category category)
        {
            _categoryService.TUpdate(category);
            return RedirectToAction("Index", "Category");
        }


    }
}
