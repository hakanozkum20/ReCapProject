using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InmemoryCarDal : ICarDal
    {
        readonly List<Car> _cars;

        public InmemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1, BrandId=1, ColorId=2, ModelYear="2010",DailyPrice=120, Descriptions="Opel Astra" },
                new Car{Id=2, BrandId=1, ColorId=1, ModelYear="2020",DailyPrice=250, Descriptions="Audi A4" },
                new Car{Id=3, BrandId=2, ColorId=2, ModelYear="2012",DailyPrice=100, Descriptions="TOGG" },
                new Car{Id=4, BrandId=3, ColorId=3, ModelYear="2015",DailyPrice=400, Descriptions="Renault Megane" },
                new Car{Id=5, BrandId=1, ColorId=4, ModelYear="2021",DailyPrice=1200, Descriptions="Porche" }

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

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.BrandId== carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}