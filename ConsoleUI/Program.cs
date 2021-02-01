using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine("--------------GetAll-------------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine($"{car.Id}\t {car.BrandId}\t {car.ColorId}\t{car.ModelYear}\t{car.DailyPrice}\t{car.Description}");
            }
            Console.WriteLine("--------------GetById-------------------");
            Car car1 = carManager.GetById(1);
            Console.WriteLine(car1.Description);

            Console.WriteLine("--------------GetByBrandId-------------------");
            foreach (var  car in carManager.GetByBrandId(3))
            {
                 Console.WriteLine($"{car.Id}\t {car.BrandId}\t {car.ColorId}\t{car.ModelYear}\t{car.DailyPrice}\t{car.Description}");
            }
            Console.WriteLine("--------------GetByColorId-------------------");
            foreach (var car in carManager.GetByColorId(1))
            {
                 Console.WriteLine($"{car.Id}\t {car.BrandId}\t {car.ColorId}\t{car.ModelYear}\t{car.DailyPrice}\t{car.Description}");

            }

        }
    }
}
