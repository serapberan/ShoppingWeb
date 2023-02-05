using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.CQRS.Commands.ProductCommands
{
    public class ProductDeleteCommand
    {
        public ProductDeleteCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
