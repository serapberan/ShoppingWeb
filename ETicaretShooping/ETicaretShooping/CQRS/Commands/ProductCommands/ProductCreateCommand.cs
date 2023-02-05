using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.CQRS.Commands.ProductCommands
{
    public class ProductCreateCommand
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }

    }
}
