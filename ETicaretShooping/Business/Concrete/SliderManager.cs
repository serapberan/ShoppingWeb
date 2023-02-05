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
    public class SliderManager : ISliderService
    {
        ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void TAdd(Slider t)
        {
            _sliderDal.Add(t);
        }

        public void TDelete(Slider t)
        {
            _sliderDal.Delete(t);
        }

        public Slider TGetById(int id)
        {
            return _sliderDal.GetById(id);
        }

        public List<Slider> TGetList(Expression<Func<Slider, bool>> filter)
        {
            return _sliderDal.List(filter);
        }

        public List<Slider> TList()
        {
            return _sliderDal.List();
        }

        public void TUpdate(Slider t)
        {
            _sliderDal.Update(t);
        }
    }
}
