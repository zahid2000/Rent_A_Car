﻿using Core.DataAccess.EntityFramework;
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
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarContext context=new CarContext())
            {
                var result = from ca in context.Cars
                             join b in context.CarBrands on ca.BrandId equals b.CarBrandId
                             join co in context.CarColors on ca.ColorId equals co.CarColorId                            
                           select new CarDetailDto
                           {
                               CarName =ca.Description, BrandName=b.Brand,ColorName=co.Color,DailyPrice=ca.DailyPrice
                           };
                return result.ToList();
            }
        }
    }
}
