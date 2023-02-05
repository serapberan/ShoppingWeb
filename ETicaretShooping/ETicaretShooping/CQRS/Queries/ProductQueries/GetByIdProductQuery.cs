using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.CQRS.Queries.ProductQueries
{
    public class GetByIdProductQuery
    {
        public GetByIdProductQuery(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; set; }
    }
}
