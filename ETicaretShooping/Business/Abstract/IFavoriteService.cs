using Entities.Concrete;
using System;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IFavoriteService : IGenericService<Favorite>
    {
        public Favorite FavoriteFind(Expression<Func<Favorite, bool>> filter);
    }

}
