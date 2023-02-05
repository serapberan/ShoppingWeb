using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.CQRS.Results.OrderResult
{
    public class GetAllOrderQueryResult
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public int OrderNo { get; set; }
        public decimal ProductPrice { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string ProductImage { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public int AppUserId { get; set; }
        public int ProductId { get; set; }
    }
}
