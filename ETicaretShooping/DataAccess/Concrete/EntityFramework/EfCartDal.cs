using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCartDal : GenericRepository<Cart>, ICartDal 
    {
        Context c = new Context();
        public void RangeDelete(IEnumerable<Cart> p)
        {   
            c.Carts.RemoveRange(p);
            c.SaveChanges();
        }
    }
}
