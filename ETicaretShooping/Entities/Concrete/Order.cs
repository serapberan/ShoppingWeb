using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public enum OrderState
    {
        HazırlanmaAsamasında,  //0
        KargoyaVerildi, //1
        TeslimEdildi,    //2
        EskiSiparisler  //3

    }

    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public int OrderNo { get; set; }
        public decimal ProductPrice { get; set; }
        public OrderState OrderState { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        public string City { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        public string District { get; set; }
        public string ProductImage { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int ProductId { get; set; }
        public virtual Product Products { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        public string CardName { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        public string ExpirationMonth { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        public string ExpirationYear { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        public string Cvc { get; set; }
    }
}
