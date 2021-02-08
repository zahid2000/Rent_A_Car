using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars = new List<Car> ()
        {
            new Car{CarId=1,ColorId=1,BrandId=1,DailyPrice=47500,ModelYear=2020,Description="Yeni Model Porche"},
            new Car{CarId=2,ColorId=1,BrandId=3,DailyPrice=54300,ModelYear=2015,Description="Yeni Model Hunday"},
            new Car{CarId=3,ColorId=5,BrandId=3,DailyPrice=45300,ModelYear=2021,Description="Yeni Model Nissan"},

        };
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return  _cars.Where(c => c.BrandId == brandId).ToList();
           
        }

        public List<Car> GetByColorId(int colorid)
        {
            return _cars.Where(c => c.ColorId == colorid).ToList();

        }

        public Car GetById(int id)
        {
            return _cars.Single(c => c.CarId==id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
           
        }
    }
}
