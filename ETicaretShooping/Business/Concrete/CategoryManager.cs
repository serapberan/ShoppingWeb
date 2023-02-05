using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        //dependency injection
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
            //amacım bağımlılıkları minimize etmektir.
        }

        public void FullDelete(Category data)
        {
            var result = _categoryDal.GetById(data.CategoryId);
            _categoryDal.FullDelete(result);
        }

        public void RestoreDeleted(Category data)
        {
            var result = _categoryDal.GetById(data.CategoryId);
            result.Status = true;
            _categoryDal.Update(result);
        }

        public void TAdd(Category t)
        {
            t.Status = true;
            _categoryDal.Add(t);
        }

        public void TDelete(Category t)
        {
            var result = _categoryDal.GetById(t.CategoryId);
            result.Status = false;
            _categoryDal.Update(result);
          
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> TGetList(Expression<Func<Category, bool>> filter)
        {
            return _categoryDal.List(filter);
        }

        public List<Category> TList()
        {
            return _categoryDal.List();
        }

        public void TUpdate(Category t)
        {
            var result = _categoryDal.GetById(t.CategoryId);
            result.Name = t.Name;
            _categoryDal.Update(result);
            
        }







        //.................................................................................................
        //    public void TDelete(Category t)
        //    {
        //        _categoryDal.Delete(t);
        //    }

        //    public Category TGetByID(int id)
        //    {
        //        return _categoryDal.GetByID(id);
        //    }

        //    public List<Category> TGetList()
        //    {
        //        return _categoryDal.GetList();
        //    }

        //    public void TInsert(Category t)
        //    {
        //        //iş kurallarını burada yazıyoruz
        //        /*
        //        if (t.CategoryName != null && t.CategoryName.Length >= 5 && t.CategoryDescription.StartsWith("A"))
        //        {
        //            //bu şartları sağlıyorsa ekle
        //            _categoryDal.Insert(t);
        //        }
        //        else
        //        {
        //            //hata mesajı
        //        }
        //        */
        //        _categoryDal.Insert(t);

        //    }

        //    public void TUpdate(Category t)
        //    {
        //        _categoryDal.Update(t);
        //    }
        //}

    }
}