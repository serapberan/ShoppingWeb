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
    public class CartManager : ICartService
    {
        ICartDal _cartDal;

        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }

        public void DeleteRange(IEnumerable<Cart> t)
        {
            _cartDal.RangeDelete(t);
        }

        public void TAdd(Cart t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Cart t)
        {
            _cartDal.Add(t);
        }

        public Cart TGetById(int id)
        {
           return _cartDal.GetById(id);
        }

        public List<Cart> TGetList(Expression<Func<Cart, bool>> filter)
        {
            return _cartDal.List(filter);
        }

        public List<Cart> TList()
        {
          return  _cartDal.List();
        }

        public void TUpdate(Cart t)
        {
            _cartDal.Update(t);
        }
    }
}
