using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarColorService
    {
       IDataResult<List<CarColor>> GetAll();
       IDataResult<CarColor> GetColorId(int colorId);
       IResult Update(CarColor carColor);
        IResult Delete(CarColor carColor);
        IResult Add(CarColor carColor);


    }
}
