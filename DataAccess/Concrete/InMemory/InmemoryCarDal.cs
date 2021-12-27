using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InmemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InmemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1, BrandId=1, ColorId=2, ModelYear=2010,DailyPrice=120, Description="Opel Astra" },
                new Car{Id=2, BrandId=1, ColorId=1, ModelYear=2020,DailyPrice=250, Description="Audi A4" },
                new Car{Id=3, BrandId=2, ColorId=2, ModelYear=2012,DailyPrice=100, Description="TOGG" },
                new Car{Id=4, BrandId=3, ColorId=3, ModelYear=2015,DailyPrice=400, Description="Renault Megane" },
                new Car{Id=5, BrandId=1, ColorId=4, ModelYear=2021,DailyPrice=1200, Description="Porche" }

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
            return _cars.Where(c => c.BrandId== carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}