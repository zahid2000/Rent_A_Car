using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
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
        IBrandDal _carBrandDal;

        public CarBrandManager(IBrandDal carBrandDal)
        {
            _carBrandDal = carBrandDal;
        }

        public IResult Add(CarBrand carBrand)
        {
            _carBrandDal.Add(carBrand);
            return new SuccessResult(Messages.CarBrandAdded);
        }

        public IResult Delete(CarBrand carBrand)
        {
            _carBrandDal.Delete(carBrand);
            return new SuccessResult(Messages.CarBrandDeleted);
        }

        public IDataResult<List<CarBrand>> GetAll()
        {
            return new SuccessDataResult<List<CarBrand>>(_carBrandDal.GetAll(),Messages.CarBrandListed); 
        }

        public IDataResult<CarBrand> GetBrandId(int brandid)
        {
            return new SuccessDataResult<CarBrand>(_carBrandDal.Get(cb => cb.CarBrandId == brandid));
        }

        public IResult Update(CarBrand carBrand)
        {
            _carBrandDal.Update(carBrand);
            return new SuccessResult(Messages.CarBrandUpdated);
        }
    }
}
