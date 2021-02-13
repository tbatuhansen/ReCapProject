using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear="2003",DailyPrice=150,Description="Renault Megané II 1.6 Dynamique TeknoPlus"},
                new Car{Id=2,BrandId=2,ColorId=1,ModelYear="2012",DailyPrice=200,Description="Volkswagen Jetta 1.6 TDI Trendline"},
                new Car{Id=3,BrandId=3,ColorId=2,ModelYear="2008",DailyPrice=120,Description="Ford Focus 1.6 TDCI Trend"},
                new Car{Id=4,BrandId=1,ColorId=3,ModelYear="2004",DailyPrice=120,Description="Renault Laguna II 1.6 Privilege"},
                new Car{Id=5,BrandId=4,ColorId=3,ModelYear="2013",DailyPrice=190,Description="Chery Tiggo 1.6 Lusso"},
                new Car{Id=6,BrandId=5,ColorId=4,ModelYear="1995",DailyPrice=80,Description="Toyota Corolla 1.6 XE.i"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
