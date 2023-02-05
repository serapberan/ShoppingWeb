using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IOrderService : IGenericService<Order>
    {
        public List<Order> OrderStateList();
        public List<Order> OrderKargoList();
        public Order OrderStateDelete(Order p);
        List<Order> GetListMyApprovalProduct(int id);
        List<Order> GetListMyCargoProduct(int id);
        List<Order> GetListMyDeliveredProduct(int id);
        List<Order> GetListMyOldProduct(int id);


    }

}
