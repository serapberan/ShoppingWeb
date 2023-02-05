using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()  //sadece referans tipler ulaşsın 

    {
        //public void Delete(T t)
        //{
        //    using (var context = new Context())
        //    {
        //        context.Remove(t);
        //        context.SaveChanges();
        //    }
        //}

        //public T GetByID(int id)
        //{
        //    using (var context = new Context())
        //    {
        //        return context.Set<T>().Find(id);
        //    }
        //}

        //public List<T> GetList()
        //{
        //    using (var context = new Context())
        //    {
        //        return context.Set<T>().ToList();

        //    }
        //}

        //public void Insert(T t)
        //{
        //    using (var context = new Context())
        //    {
        //        context.Add(t);
        //        context.SaveChanges();
        //    }

        //}

        //public void Update(T t)
        //{
        //    using (var context = new Context())
        //    {
        //        context.Update(t);
        //        context.SaveChanges();
        //    }

        //}


        //public List<T> List(Expression<Func<T, bool>> filter = null)   //burda isteğimize göre listemele yapabilmemizi sağlar
        //{
        //    using (var context = new Context())
        //    {
        //        return filter == null
        //            ? context.Set<T>().ToList()
        //            : context.Set<T>().Where(filter).ToList();
        //    }
        //}
        public void Add(T t)
        {
            using (var context = new Context())
            {
                context.Add(t);
                context.SaveChanges();
            }
        }

        public void Delete(T t)
        {
            using (var context = new Context())
            {
                context.Remove(t);
                context.SaveChanges();
            }
        }

        public T GetById(int id)
        {
            using (var context = new Context())
            {
                return context.Set<T>().Find(id);
            }
        }

        public List<T> List()
        {
            using (var context = new Context())
            {
                return context.Set<T>().ToList();

            }
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            using (var context = new Context())
            {
                return filter == null
                    ? context.Set<T>().ToList()
                    : context.Set<T>().Where(filter).ToList();
            }
        }

        public void Update(T t)
        {
            using (var context = new Context())
            {
                context.Update(t);
                context.SaveChanges();
            }
        }
    }
}
