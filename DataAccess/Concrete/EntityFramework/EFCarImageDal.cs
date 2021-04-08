using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class EFCarImageDal : EFEntityRepositoryBase<CarImage, CarContext>, ICarImageDal
    {
        public List<CarImageDto> GetCarImagesDetail(Expression<Func<CarImageDto, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                var result = from car in context.Cars
                             join image in context.CarImages
                             on car.CarId equals image.CarId
                             join brand in context.CarBrands
                             on car.BrandId equals brand.CarBrandId
                             select new CarImageDto
                             {
                                 Id = image.Id,
                                 CarId = car.CarId,
                                 CarName = ($"{brand.Brand} {car.Description}"),
                                 ImagePath = (from img in context.CarImages where img.CarId == car.CarId select img.ImagePath).ToArray(),
                                 Date = DateTime.Today


                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        public bool IsExists(int id)
        {
            using (CarContext context = new CarContext())
            {
                return context.CarImages.Any(c => c.Id == id);
            }
        }
    }
}
