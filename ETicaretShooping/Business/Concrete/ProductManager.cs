using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TImageUpdate(Product data)
        {
            var result = _productDal.GetById(data.ProductId);
            result.Image = data.Image;
            _productDal.Update(result);
        }

        public List<Product> TOutOfStock()
        {
            return _productDal.OutOfStock();
        }

        public void TRestoreDeleted(Product data)
        {
            var result = _productDal.GetById(data.ProductId);
            result.Status = true;
            _productDal.Update(result);
        }

        public List<Product> TRunningOutStock()
        {
            return _productDal.RunningOutStock();
        }

        public void TAdd(Product t)
        {
            
            _productDal.Add(t);
        }

        public void TDelete(Product t)
        {
           
            _productDal.Delete(t);
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> TGetList(Expression<Func<Product, bool>> filter)
        {
            return _productDal.List(filter);
        }

        public List<Product> TList()
        {
            return _productDal.List();
        }

        public void TProductBySelectFalse(int id)
        {
            _productDal.ProductBySelectFalse(id);
        }

        public void TProductBySelectTrue(int id)
        {
            _productDal.ProductBySelectTrue(id);
        }

        public void TUpdate(Product t)
        {
            var result = _productDal.GetById(t.ProductId);
            result.Name = t.Name;
            result.Description = t.Description;
            result.Price = t.Price;
            result.Stock = t.Stock;
            result.Popular = t.Popular;
            result.Approved = t.Approved;
            result.CategoryId = t.CategoryId;
            result.Status = t.Status;
            result.ImageUrl = t.ImageUrl;
            _productDal.Update(result);
        }

    }
}
