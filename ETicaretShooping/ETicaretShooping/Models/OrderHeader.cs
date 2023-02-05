using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Models
{
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }
        public string AppUserId { get; set; }
        [ForeignKey("AppUserId")]
        public AppUser AppUser { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderTotal { get; set; }
        public string OrderStatus { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
    }
}
