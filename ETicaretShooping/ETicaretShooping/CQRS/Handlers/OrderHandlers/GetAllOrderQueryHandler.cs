using DataAccess.Concrete.EntityFramework;
using ETicaretShooping.CQRS.Queries.OrderQueries;
using ETicaretShooping.CQRS.Results.OrderResult;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ETicaretShooping.CQRS.Handlers.OrderHandlers
{
    public class GetAllOrderQueryHandler : IRequestHandler<GetAllOrderQuery,List<GetAllOrderQueryResult>>
    {
        private readonly Context _context;

        public GetAllOrderQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllOrderQueryResult>> Handle(GetAllOrderQuery request, CancellationToken cancellationToken)
        {
            return await _context.Orders.Select(x => new GetAllOrderQueryResult
            {
                OrderId = x.OrderId,
                OrderNo = x.OrderNo,
                ProductId = x.ProductId,
                AppUserId = x.AppUserId,
                Quantity = x.Quantity,
                ProductPrice = x.ProductPrice,
                Address = x.Address,
                City = x.City,
                District = x.District,
                Date = x.Date

            }).AsNoTracking().ToListAsync();
        }
    }
}
