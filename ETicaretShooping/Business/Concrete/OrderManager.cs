using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public List<Order> GetListMyApprovalProduct(int id)
        {
            return _orderDal.GetListMyApprovalProduct(id);
        }

        public List<Order> GetListMyCargoProduct(int id)
        {
            return _orderDal.GetListMyCargoProduct(id);
        }

        public List<Order> GetListMyDeliveredProduct(int id)
        {
            return _orderDal.GetListMyDeliveredProduct(id);
        }

        public List<Order> GetListMyOldProduct(int id)
        {
            return _orderDal.GetListMyOldProduct(id);
        }

        public List<Order> OrderKargoList()
        {
            throw new NotImplementedException();
        }

        public Order OrderStateDelete(Order p)
        {
            throw new NotImplementedException();
        }

        public List<Order> OrderStateList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Order t)
        {
            _orderDal.Add(t);
        }

        public void TDelete(Order t)
        {
            _orderDal.Delete(t);
        }

        public Order TGetById(int id)
        {
            return _orderDal.GetById(id);
        }

        public List<Order> TGetList(Expression<Func<Order, bool>> filter)
        {
            return _orderDal.List(filter);
        }

        public List<Order> TList()
        {
            return _orderDal.List();
        }

        public void TUpdate(Order t)
        {
            _orderDal.Update(t);
        }
    }
}
