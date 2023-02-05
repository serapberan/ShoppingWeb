using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        Context db = new Context();
        public void FullDelete(Category p)
        {
            var delete = db.Categories.Find(p.CategoryId);
            db.Categories.Remove(delete);
        }
    }
}
