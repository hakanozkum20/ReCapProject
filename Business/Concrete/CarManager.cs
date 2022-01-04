using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Runtime.Serialization;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
         ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if ( car.Descriptions.Length <= 2 || car.DailyPrice <1 )
            {
                System.Console.WriteLine("2 satýr olamaz");
            }
            _carDal.Add(car);
        }

        public List<Car> GetAll()
        {
            //Ýþ kodlarý 
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }
    }
}