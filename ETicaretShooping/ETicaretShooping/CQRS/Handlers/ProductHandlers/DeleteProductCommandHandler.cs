using DataAccess.Concrete.EntityFramework;
using ETicaretShooping.CQRS.Commands.ProductCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.CQRS.Handlers.ProductHandlers
{
    public class DeleteProductCommandHandler
    {
        private readonly Context _context;

        public DeleteProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(ProductDeleteCommand command)
        {
            var values = _context.Products.Find(command.Id);
            _context.Products.Remove(values);
            _context.SaveChanges();
        }
    }
}
