using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarBrandService
    {
        List<CarBrand> GetAll();
        CarBrand GetBrandId(int brandId);
    }
}
