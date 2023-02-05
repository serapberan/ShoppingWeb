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
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void TAdd(AppUser t)
        {
            _appUserDal.Add(t);
        }

        public void TDelete(AppUser t)
        {
            _appUserDal.Delete(t);
        }

        public AppUser TGetById(int id)
        {
            return _appUserDal.GetById(id);
        }

        public List<AppUser> TGetList(Expression<Func<AppUser, bool>> filter)
        {
            return _appUserDal.List(filter);
        }

        public List<AppUser> TList()
        {
            return _appUserDal.List();
        }

        public void TUpdate(AppUser t)
        {
            _appUserDal.Update(t);
        }
    }
}
