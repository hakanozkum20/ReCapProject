using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           

            CarManager carManager = new(new EfCarDal ());

            foreach (var car in carManager.GetAllByBrandId(1))
            {
                Console.WriteLine(car.Descriptions);
                
            }
        }
    }
}
