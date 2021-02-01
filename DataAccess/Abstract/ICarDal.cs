using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetByColorId(int colorId);
        List<Car> GetByBrandId(int brandId);
        Car GetById(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        
    }
}
