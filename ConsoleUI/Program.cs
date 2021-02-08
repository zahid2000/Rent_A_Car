using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            //CarAddTest(carManager);
            //CarUpdateTest(carManager);
            //CarTest(carManager);

        }

        private static void CarAddTest(CarManager carManager)
        {
            Car car1 = new Car { BrandId = 5, ColorId = 1, ModelYear = 2014, DailyPrice = 13500, Description = "Hunday" };
            carManager.Add(car1);
        }

        private static void CarUpdateTest(CarManager carManager)
        {
            Car car3 = new Car { CarId = 11, BrandId = 3, ColorId = 1, ModelYear = 2014, DailyPrice = 23500, Description = "Mercedes Benz" };
            carManager.Update(car3);
        }

        private static void CarTest(CarManager carManager)
        {
            Console.WriteLine("--------------GetAll-------------------");
            foreach (var car in carManager.GetAll())
            {
                
                Console.WriteLine($"{car.CarId}\t {car.BrandId}\t {car.ColorId}\t{car.ModelYear}\t{car.DailyPrice}\t{car.Description}");
            }
            Console.WriteLine("--------------GetById-------------------");
            Car car2 = carManager.GetById(1);
            Console.WriteLine($"{car2.CarId}\t {car2.BrandId}\t {car2.ColorId}\t{car2.ModelYear}\t{car2.DailyPrice}\t{car2.Description}");

            Console.WriteLine("--------------GetByBrandId-------------------");
            foreach (var car in carManager.GetByBrandId(2))
            {
                Console.WriteLine($"{car.CarId}\t {car.BrandId}\t {car.ColorId}\t{car.ModelYear}\t{car.DailyPrice}\t{car.Description}");
            }
            Console.WriteLine("--------------GetByColorId-------------------");
            foreach (var car in carManager.GetByColorId(2))
            {
                Console.WriteLine($"{car.CarId}\t {car.BrandId}\t {car.ColorId}\t{car.ModelYear}\t{car.DailyPrice}\t{car.Description}");

            }
        }
    }
}
