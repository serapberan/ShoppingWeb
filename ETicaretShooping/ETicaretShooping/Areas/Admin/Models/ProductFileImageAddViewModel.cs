using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Areas.Admin.Models
{
    public class ProductFileImageAddViewModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public IFormFile ImageUrl { get; set; }
        public string ImgName { get; set; }
        public bool Approved { get; set; }
        public bool Popular { get; set; }
        public bool Status { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
