using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car
            {
                Id = 7,
                BrandId = 1,
                ColorId = 3,
                ModelYear = "2016",
                DailyPrice = 250,
                Description = "Volkswagen Golf 1.6 TDI Highline DSG"
            };

            carManager.Add(car);
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.ModelYear + " " + item.Description);
            }
        }
    }
}
