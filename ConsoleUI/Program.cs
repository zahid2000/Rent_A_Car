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
            CarGetTest();
            //CarUpdateTest();
           // CarAddTest();
           // CarGetDetailsTest();
            //CarColorTest();
            //CarBrandTest();

        }

        private static void CarBrandTest()
        {
            CarBrandManager carBrandManager = new CarBrandManager(new EFCarBrandDal());
            Console.WriteLine(carBrandManager.GetBrandId(2).Data.CarBrandId + " " + carBrandManager.GetBrandId(2).Data.Brand);
            //foreach (var carBrand in carBrandManager.GetAll())
            //{
            //    Console.WriteLine("{0}-{1}",carBrand.CarBrandId,carBrand.Brand); 
            //}
        }

        private static void CarColorTest()
        {
            CarColorManager colorManager = new CarColorManager(new EFCarColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine("{0}-{1}", color.CarColorId, color.Color);
            }
        }

        private static void CarGetDetailsTest()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var carDetail in result.Data)
                {
                    Console.WriteLine("{0}/{1}/{2}/{3}", carDetail.CarName, carDetail.BrandName, carDetail.ColorName, carDetail.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

           
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            Car car = new Car { BrandId = 6, ColorId = 3, ModelYear = 2018, DailyPrice = 12500, Description = "Hunday" };
            var result=carManager.Add(car);
            Console.WriteLine(result.Message);
            
        }

        private static void CarUpdateTest()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            Car car = new Car { CarId = 11, BrandId = 3, ColorId = 1, ModelYear = 2014, DailyPrice = 23500, Description = "Mercedes Benz" };
            carManager.Update(car);
        }

        private static void CarGetTest()
        {
            CarManager carManager = new CarManager(new EFCarDal());

            Console.WriteLine("--------------GetAll-------------------");
            foreach (var car in carManager.GetAll().Data)
            {

                Console.WriteLine($"{car.CarId}\t {car.BrandId}\t {car.ColorId}\t{car.ModelYear}\t{car.DailyPrice}\t{car.Description}");
            }
            Console.WriteLine("--------------GetById-------------------");
            Car car2 = carManager.GetById(1).Data;
            Console.WriteLine($"{car2.CarId}\t {car2.BrandId}\t {car2.ColorId}\t{car2.ModelYear}\t{car2.DailyPrice}\t{car2.Description}");

            Console.WriteLine("--------------GetByBrandId-------------------");
            foreach (var car in carManager.GetByBrandId(2).Data)
            {
                Console.WriteLine($"{car.CarId}\t {car.BrandId}\t {car.ColorId}\t{car.ModelYear}\t{car.DailyPrice}\t{car.Description}");
            }
            Console.WriteLine("--------------GetByColorId-------------------");
            foreach (var car in carManager.GetByColorId(2).Data)
            {
                Console.WriteLine($"{car.CarId}\t {car.BrandId}\t {car.ColorId}\t{car.ModelYear}\t{car.DailyPrice}\t{car.Description}");

            }
        }

       

        

        
    }
}
