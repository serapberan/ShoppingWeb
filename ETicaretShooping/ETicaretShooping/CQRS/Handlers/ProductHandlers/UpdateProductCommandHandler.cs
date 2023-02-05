using DataAccess.Concrete.EntityFramework;
using ETicaretShooping.CQRS.Commands.ProductCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.CQRS.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(ProductUpdateCommand command)
        {
            var values = _context.Products.Find(command.ProductId);
            values.Name = command.Name;
            values.Description = command.Description;
            values.Price = command.Price;
            values.Stock = command.Stock;
        }
    }
}