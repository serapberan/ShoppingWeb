using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IOrderDal : IGenericDal<Order>
    {
        List<Order> GetListMyApprovalProduct(int id); //Hazırlık Asamasında 
        List<Order> GetListMyCargoProduct(int id); //Kargodaki ürünler
        List<Order> GetListMyDeliveredProduct(int id); //TeslimEdildi
        List<Order> GetListMyOldProduct(int id);  // Geçmiş

        public List<Order> OrderListState();  //sipariş durumu kargo | hazırlık | teslim 
        public List<Order> OrderCargoList();
        public Order OrderStateDelete(Order p);
    }
}
