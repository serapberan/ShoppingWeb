using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FavoriteManager : IFavoriteService
    {
        IFavoriteDal _favoriteDal;

        public FavoriteManager(IFavoriteDal favoriteDal)
        {
            _favoriteDal = favoriteDal;
        }

        public Favorite FavoriteFind(Expression<Func<Favorite, bool>> filter)
        {
            return _favoriteDal.FavoriteGetFind(filter);
        }

        public void TAdd(Favorite t)
        {
            _favoriteDal.Add(t);
        }

        public void TDelete(Favorite t)
        {
            _favoriteDal.Delete(t);
        }

        public Favorite TGetById(int id)
        {
            return _favoriteDal.GetById(id);
        }

        public List<Favorite> TGetList(Expression<Func<Favorite, bool>> filter)
        {
            return _favoriteDal.List(filter);
        }

        public List<Favorite> TList()
        {
            return _favoriteDal.List();
        }

        public void TUpdate(Favorite t)
        {
            _favoriteDal.Update(t);
        }
    }
}
