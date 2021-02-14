using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarBrandService
    {
       IDataResult<List<CarBrand>> GetAll();
       IDataResult<CarBrand> GetBrandId(int brandId);
        IResult Update(CarBrand carBrand);
        IResult Delete(CarBrand carBrand);
        IResult Add(CarBrand carBrand);
    }
}
