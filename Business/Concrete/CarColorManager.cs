using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
   public class CarColorManager : ICarColorService
    {
        EFCarColorDal _colorDal;

        public CarColorManager(EFCarColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<CarColor> GetAll()
        {
            return _colorDal.GetAll();
        }

        public CarColor GetColorId(int colorId)
        {
            return  _colorDal.GetAll().SingleOrDefault(c => c.CarColorId == colorId);
        }
    }
}
