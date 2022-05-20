using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c=>c.BrandId==brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }


        public void Add(Car car)
        {
            if(car.Description.Length>=2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Car Added Successfuly..");
            }
            else
            {
                throw new Exception("Car name length must be more than 2 characters and daily rate must be greater than 0!!!");
            }
        }


        public void Update(Car car)
        {
            _carDal.Update(car);
        }


        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
        
    }
}
