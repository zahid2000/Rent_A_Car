using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarBrandManager : ICarBrandService
    {
        EFCarBrandDal _carBrandDal;

        public CarBrandManager(EFCarBrandDal carBrandDal)
        {
            _carBrandDal = carBrandDal;
        }

        public List<CarBrand> GetAll()
        {
            return _carBrandDal.GetAll();
        }

        public CarBrand GetBrandId(int brandid)
        {
            return _carBrandDal.GetAll().SingleOrDefault(cb => cb.CarBrandId == brandid);
        }
    }
}
