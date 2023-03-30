using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{BrandId = 1, ColorId = 1, DailyPrice = 110, Description = "Vintage Car", Id = 1, ModelYear = "1980" },
                new Car{BrandId = 1, ColorId = 3, DailyPrice = 95, Description = "Broken Air Conditioner", Id = 2, ModelYear = "2012" },
                new Car{BrandId = 2, ColorId = 4, DailyPrice = 70 , Description = "Manuel", Id = 3, ModelYear = "2001"},
                new Car{BrandId = 3, ColorId = 12, DailyPrice = 120, Description = "Automatic" , Id = 4, ModelYear = "2015"},
                new Car{BrandId = 2, ColorId = 1, DailyPrice = 150, Description = "Vintage Car", Id = 5, ModelYear = "1985"}

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

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}