using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dto;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFRentalDal : EFEntityRepositoryBase<Rental, CarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                var result = from re in context.Rentals
                             join us in context.Users
                             on re.CustomerId equals us.UserId
                             join ca in context.Cars
                             on re.CarId equals ca.CarId
                             join ba in context.CarBrands
                            on ca.BrandId equals ba.CarBrandId


                             select new RentalDetailDto
                             {
                                 Id = re.RentalId,
                                 CarName = ($"{ba.Brand} {ca.Description}"),
                                 UserName = ($"{us.FirstName} {us.LastName}"),
                                 RentDate = re.RentDate,
                                 ReturnDate = (DateTime)re.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
