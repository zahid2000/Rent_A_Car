using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : EFEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                var result = from car in context.Cars
                             join brand in context.CarBrands on car.BrandId equals brand.CarBrandId
                             join color in context.CarColors on car.ColorId equals color.CarColorId
                             select new CarDetailDto
                             {
                                 CarId = car.CarId,
                                 CarName = car.Description,
                                 BrandName = brand.Brand,
                                 ColorName = color.Color,
                                 DailyPrice = car.DailyPrice,
                                 ModelYear = car.ModelYear,
                                 ImagePath = (from img in context.CarImages where img.CarId == car.CarId select img.ImagePath).ToArray()

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}

