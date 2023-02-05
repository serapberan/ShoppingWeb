using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.ViewComponents
{
    public class _TrendProductComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var values = productManager.TList(); 
            return View(values);
        }
    }
}
