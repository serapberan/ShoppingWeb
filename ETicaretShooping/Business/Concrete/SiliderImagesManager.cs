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
    public class SiliderImagesManager : ISliderImageService
    {
        ISliderImageDal _sliderImageDal;

        public SiliderImagesManager(ISliderImageDal sliderImageDal)
        {
            _sliderImageDal = sliderImageDal;
        }

        public void TAdd(SliderImage t)
        {
            _sliderImageDal.Add(t);
        }

        public void TDelete(SliderImage t)
        {
            _sliderImageDal.Delete(t);
        }

        public SliderImage TGetById(int id)
        {
            return _sliderImageDal.GetById(id);
        }

        public List<SliderImage> TGetList(Expression<Func<SliderImage, bool>> filter)
        {
            return _sliderImageDal.List(filter);
        }

        public List<SliderImage> TList()
        {
            return _sliderImageDal.List();
        }

        public void TUpdate(SliderImage t)
        {
            _sliderImageDal.Update(t);
        }
    }
}
