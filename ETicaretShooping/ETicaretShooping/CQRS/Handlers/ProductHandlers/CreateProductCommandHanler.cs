using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using ETicaretShooping.CQRS.Commands.ProductCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.CQRS.Handlers.ProductHandlers
{
    public class CreateProductCommandHanler
    {
        private readonly Context _context;

        public CreateProductCommandHanler(Context context)
        {
            _context = context;
        }

        public void Handle(ProductCreateCommand command)
        {
            _context.Products.Add(new Product
            {
                Name = command.Name,
                Description = command.Description,
                Price = command.Price,
                Stock = command.Stock,
                CategoryId = command.CategoryId
            }); 
            _context.SaveChanges();
        }
    }
}
