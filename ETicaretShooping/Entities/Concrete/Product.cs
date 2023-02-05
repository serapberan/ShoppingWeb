using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product
    {

        public Product()
        {
            Images = new List<Image>();
        }
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; }
        public bool Approved { get; set; }
        public bool Popular { get; set; }
        public bool Status { get; set; }
        [NotMapped]  
        public IEnumerable<IFormFile> Image { get; set; }
        public int CategoryId { get; set; }
        
        [ForeignKey("CategoryId")]
        public  Category Category { get; set; }  // 1 ürünün 1 kategorisi olabilir
        public virtual List<Image> Images { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Favorite> Favorites { get; set; }
        public virtual List<Cart> Carts { get; set; }

    }
}
