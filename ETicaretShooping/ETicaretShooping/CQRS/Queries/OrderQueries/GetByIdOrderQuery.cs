using ETicaretShooping.CQRS.Results.OrderResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.CQRS.Queries.OrderQueries
{
    public class GetByIdOrderQuery : IRequest<GetByIdOrderQyeryResult>
    {
        public GetByIdOrderQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
