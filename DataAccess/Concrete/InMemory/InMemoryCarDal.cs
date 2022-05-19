using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=100,Description="güzel bir audi",ModelYear=2021},
                new Car{Id=1,BrandId=1,ColorId=2,DailyPrice=200,Description="güzel bir audi2",ModelYear=2022},
                new Car{Id=1,BrandId=2,ColorId=7,DailyPrice=500,Description="güzel bir volvo",ModelYear=2019},
                new Car{Id=1,BrandId=3,ColorId=2,DailyPrice=150,Description="güzel bir mercedes",ModelYear=2015},
                new Car{Id=1,BrandId=3,ColorId=6,DailyPrice=600,Description="güzel bir mercedes2",ModelYear=2008},
                new Car{Id=1,BrandId=4,ColorId=4,DailyPrice=1500,Description="güzel bir hyundai",ModelYear=2001}
            };

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
