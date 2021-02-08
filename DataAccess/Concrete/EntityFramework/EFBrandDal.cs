using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFBrandDal : IBrandDal
    {
        public void Add(CarBrand entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CarBrand entity)
        {
            throw new NotImplementedException();
        }

        public CarBrand Get(Expression<Func<CarBrand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarBrand> GetAll(Expression<Func<CarBrand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(CarBrand entity)
        {
            throw new NotImplementedException();
        }
    }
}
