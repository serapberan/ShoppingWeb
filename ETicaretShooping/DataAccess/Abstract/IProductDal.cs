using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal : IGenericDal<Product> 
    {
        void ProductBySelectTrue(int id);
        void ProductBySelectFalse(int id);
        public List<Product> OutOfStock();  //stok tükendi
        public List<Product> RunningOutStock();
      //  List<Product> List(Expression<Func<Product, bool>> filter);
    }
}
