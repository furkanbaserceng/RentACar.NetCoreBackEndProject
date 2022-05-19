using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {

        List<Car> GetAll();

        List<Car> GetCarsByBrandId(int brandId);

        List<Car> GetCarsByColorId(int colorId);

        List<CarDetailsDTO> GetCarDetails();

        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}
