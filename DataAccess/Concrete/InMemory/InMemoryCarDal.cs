using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{Id= 1,BrandId = 1, ColorId=2, ModelYear=1997, DailyPrice=500, Description="Easy to Drive"},
                new Car{Id =2,BrandId=1,ColorId=3, ModelYear=2000, DailyPrice=800, Description="Enhanced"},
                new Car{Id=2, BrandId=3, ColorId=2,ModelYear=2003,DailyPrice=750, Description="High-Agility"},
                new Car{Id=4, BrandId=2, ColorId=6,ModelYear=2012,DailyPrice=950, Description="Economical"},
                new Car{Id=4, BrandId=2, ColorId=1,ModelYear=2020,DailyPrice=900, Description="Functional"},
            };
        }

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

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
