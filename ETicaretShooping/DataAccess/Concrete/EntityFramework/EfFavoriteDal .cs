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
    public class EfFavoriteDal : GenericRepository<Favorite>, IFavoriteDal 
    {

        Context db = new Context();

        public Favorite FavoriteGetFind(Expression<Func<Favorite, bool>> filter)
        {
            var favorite = db.Favorites.Where(filter).FirstOrDefault();
            return favorite;
        }
    }
}
