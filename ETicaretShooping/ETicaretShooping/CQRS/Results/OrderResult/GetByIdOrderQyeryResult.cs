using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.CQRS.Results.OrderResult
{
    public class GetByIdOrderQyeryResult
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public int OrderNo { get; set; }
        public int AppUserId { get; set; }
        public int ProductId { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
