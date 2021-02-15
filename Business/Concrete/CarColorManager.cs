using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
        EFCarColorDal _carColorDal;

        public CarColorManager(EFCarColorDal colorDal)
        {
            _carColorDal = colorDal;
        }

        public IResult Add(CarColor carColor)
        {
            _carColorDal.Add(carColor);
            return new SuccessResult(Messages.CarColorAdded);
        }

        public IResult Delete(CarColor carColor)
        {
            _carColorDal.Delete(carColor);
            return new SuccessResult(Messages.CarColorDeleted);
        }

        public IDataResult<List<CarColor>> GetAll()
        {
            return new SuccessDataResult<List<CarColor>>(_carColorDal.GetAll(),Messages.CarColorListed);
        }

        public IDataResult<CarColor> GetColorId(int colorId)
        {
            return new SuccessDataResult<CarColor>(_carColorDal.Get(c => c.CarColorId == colorId));
        }

        public IResult Update(CarColor carColor)
        {
            _carColorDal.Update(carColor);
         return new SuccessResult(Messages.CarColorUpdated);
        }
    }
}
