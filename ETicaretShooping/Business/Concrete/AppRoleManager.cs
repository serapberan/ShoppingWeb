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
    public class AppRoleManager : IAppRoleService
    {
        IAppRoleDal _appRoleDal;

        public AppRoleManager(IAppRoleDal appRoleDal)
        {
            _appRoleDal = appRoleDal;
        }

        public void TAdd(AppRole t)
        {
            _appRoleDal.Add(t);
        }

        public void TDelete(AppRole t)
        {
            _appRoleDal.Delete(t);
        }

        public AppRole TGetById(int id)
        {
            return _appRoleDal.GetById(id);
        }

        public List<AppRole> TGetList(Expression<Func<AppRole, bool>> filter)
        {
            return _appRoleDal.List(filter);
        }

        public List<AppRole> TList()
        {
            return _appRoleDal.List();
        }

        public void TUpdate(AppRole t)
        {
            _appRoleDal.Update(t);
        }
    }
}
