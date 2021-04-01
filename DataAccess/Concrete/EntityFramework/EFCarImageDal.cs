using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class EFCarImageDal : EFEntityRepositoryBase<CarImage, CarContext>, ICarImageDal
    {
        public bool IsExists(int id)
        {
            using (CarContext context = new CarContext())
            {
                return context.CarImages.Any(c => c.Id == id);
            }
        }
    }
}
