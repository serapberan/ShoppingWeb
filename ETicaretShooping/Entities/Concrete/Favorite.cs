using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Favorite  //Favori Ürünler
    {
        [Key]
        public int FavoriteId { get; set; }
        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
