using DataAccess.Concrete.EntityFramework;
using ETicaretShooping.CQRS.Queries.ProductQueries;
using ETicaretShooping.CQRS.Results.ProductResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.CQRS.Handlers.ProductHandlers
{
    public class GetByIdProductQueryHandler
    {
        private readonly Context _context;

        public GetByIdProductQueryHandler(Context context)
        {
            _context = context;
        }

        public GetByIdProductQueryResult Handle(GetByIdProductQuery query ) 
        {
            var value = _context.Products.Find(query.ProductId);
            return new GetByIdProductQueryResult
            {
                ProductId = value.ProductId,
                Name = value.Name,
                Description = value.Description,
                Price = value.Price
            };
        }
    }
}
