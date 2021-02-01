using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars = new List<Car> ()
        {
            new Car{Id=1,ColorId=1,BrandId=1,DailyPrice=47500.99,ModelYear=2020,Description="Yeni Model Porche"},
            new Car{Id=2,ColorId=1,BrandId=3,DailyPrice=54300.99,ModelYear=2015,Description="Yeni Model Hunday"},
            new Car{Id=3,ColorId=5,BrandId=3,DailyPrice=45300.99,ModelYear=2021,Description="Yeni Model Nissan"},

        };
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
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
            return _cars.Single(c => c.Id==id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
           
        }
    }
}
