using DataAccess.Concrete.EntityFramework;
using ETicaretShooping.CQRS.Queries.OrderQueries;
using ETicaretShooping.CQRS.Results.OrderResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ETicaretShooping.CQRS.Handlers.OrderHandlers
{
    public class GetByIdOrderQueryHandler : IRequestHandler<GetByIdOrderQuery, GetByIdOrderQyeryResult>
    {
        private readonly Context _context;

        public GetByIdOrderQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetByIdOrderQyeryResult> Handle(GetByIdOrderQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Orders.FindAsync(request.Id);
            return new GetByIdOrderQyeryResult
            {
                OrderId = values.OrderId,
                OrderNo = values.OrderNo,
                AppUserId = values.AppUserId,
                ProductId = values.ProductId,
                ProductPrice = values.ProductPrice,
                Quantity = values.Quantity
            };
        }
    }
}
