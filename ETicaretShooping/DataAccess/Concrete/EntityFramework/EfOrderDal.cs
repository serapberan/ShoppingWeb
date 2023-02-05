using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
        Context db = new Context();

        public List<Order> GetListMyApprovalProduct(int id)  //hazırlanma asamasında 
        {
            var orderState = OrderState.HazırlanmaAsamasında;
            var orderstatelist = db.Orders.Where(x => x.OrderState == orderState && x.AppUserId == id).ToList();
            return orderstatelist;
        }

        public List<Order> GetListMyCargoProduct(int id)   //kargoda 
        {
            var orderstate = OrderState.KargoyaVerildi;
            var orderstatelist = db.Orders.Where(x => x.OrderState == orderstate && x.AppUserId == id).ToList();
            return orderstatelist;
        }

        public List<Order> GetListMyDeliveredProduct(int id)  //teslim edildi
        {
            var orderstate = OrderState.TeslimEdildi;
            var orderstatelist = db.Orders.Where(x => x.OrderState == orderstate && x.AppUserId == id).ToList();
            return orderstatelist;
        }

        public List<Order> GetListMyOldProduct(int id)  //eski
        {
            var orderstate = OrderState.EskiSiparisler;
            var orderstatelist = db.Orders.Where(x => x.OrderState == orderstate && x.AppUserId == id).ToList();
            return orderstatelist;
        }




        public List<Order> OrderCargoList()
        {
            throw new NotImplementedException();
        }

        public List<Order> OrderKargoList()
        {
            var orderstate = OrderState.KargoyaVerildi;
            var orderstatelist = db.Orders.Where(x => x.OrderState == orderstate).ToList();
            return orderstatelist;
        }

        public List<Order> OrderListState()
        {
            var orderstate = OrderState.HazırlanmaAsamasında;
            var orderstatelist = db.Orders.Where(x => x.OrderState == orderstate).ToList();
            return orderstatelist;
        }

        public Order OrderStateDelete(Order p)
        {

            var orderstate = OrderState.HazırlanmaAsamasında;
            var order = db.Orders.Where(x => x.OrderId == p.OrderId && x.OrderState == orderstate).FirstOrDefault();

            db.Orders.Remove(order);
            db.SaveChanges();
            return order;
        }
    }
}
