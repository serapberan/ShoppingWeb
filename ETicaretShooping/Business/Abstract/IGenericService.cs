using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGenericService<T>
    {
       
        void TAdd(T t);
        void TUpdate(T t);
        void TDelete(T t);
        T TGetById(int id);
        List<T> TList();
        List<T> TGetList(Expression<Func<T, bool>> filter);


        //void TAdd(T t);
        //void TDelete(T t);
        //void TUpdate(T t);
        //List<T> TGetList();
        //T TGetByID(int id);
        //List<T> GetByFilter(Expression<Func<T, bool>> filter);
    }
}
