using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        void TProductBySelectTrue(int id);
        void TProductBySelectFalse(int id);
        public void TImageUpdate(Product data);
        void TRestoreDeleted(Product data);
        public List<Product> TOutOfStock();
        public List<Product> TRunningOutStock();
    }
}
