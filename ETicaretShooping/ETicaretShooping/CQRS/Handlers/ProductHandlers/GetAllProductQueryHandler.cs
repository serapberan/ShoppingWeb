using DataAccess.Concrete.EntityFramework;
using ETicaretShooping.CQRS.Queries.ProductQueries;
using ETicaretShooping.CQRS.Results.ProductResult;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.CQRS.Handlers.ProductHandlers
{
    public class GetAllProductQueryHandler
    {
        private readonly Context _context;

        public GetAllProductQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetAllProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetAllProductQueryResult
            {
                ProductId = x.ProductId,
                Name = x.Name,
                Description = x.Description,
                Price = x.Price,
                ImageUrl = x.ImageUrl   //kayıt yapmadığımız sürece izlemeye gerek olmadığı için değişiklik yok --savechange yok
            }).AsNoTracking().ToList();  //AsNoTracking kullanıldığında Entity üzerinde değişiklik var mı yok mu  Context tarafından izlemenmez.
            return values;
        }
    }
}
