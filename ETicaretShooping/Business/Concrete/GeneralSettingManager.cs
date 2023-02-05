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
    public class GeneralSettingManager : IGeneralSettingService
    {
        IGeneralSettingsDal _generalSettingsDal;

        public GeneralSettingManager(IGeneralSettingsDal generalSettingsDal)
        {
            _generalSettingsDal = generalSettingsDal;
        }

        public void TAdd(GeneralSetting t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(GeneralSetting t)
        {
            throw new NotImplementedException();
        }

        public GeneralSetting TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<GeneralSetting> TGetList(Expression<Func<GeneralSetting, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<GeneralSetting> TList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(GeneralSetting t)
        {
            throw new NotImplementedException();
        }
    }
}
