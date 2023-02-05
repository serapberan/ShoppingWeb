using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        Context db = new Context();

        public List<Product> List(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> OutOfStock()  //stok tükendi
        {
            return db.Products.Where(x => x.Stock == 0).ToList();
        }

        public void ProductBySelectFalse(int id)
        {
            var values = db.Products.Find(id);
            values.Popular = false;
            db.Update(values);
            db.SaveChanges();
        }

        public void ProductBySelectTrue(int id)
        {

            var values = db.Products.Find(id);
            values.Popular = true;
            db.Update(values);
            db.SaveChanges();
        }

        public List<Product> RunningOutStock()
        {
            return db.Products.Where(x => x.Stock < 50).ToList();
        }

    }
}
