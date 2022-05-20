


using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

using Entities.Concrete;
using System.Collections.Generic;

ICarService _carService = new CarManager(new EfCarDal());


foreach (var car in _carService.GetAll())
{
    Console.WriteLine("{0}",car.Description);

}

Console.WriteLine("-----------------------------");

foreach (var carDTO in _carService.GetCarDetails())
{
    Console.WriteLine(carDTO.Description+"-->"+carDTO.BrandName+"-->"+carDTO.ColorName);
}

Console.WriteLine("-----------------------------");

foreach(var car in _carService.GetCarsByBrandId(1))
{
    Console.WriteLine(car.Description);
}

Console.WriteLine("-----------------------------");


foreach (var car in _carService.GetCarsByColorId(1))
{
    Console.WriteLine(car.Description);
}

Console.WriteLine("-----------------------------");

//_carService.Add(new Car
//{
//    BrandId = 1,
//    ColorId = 1,
//    DailyPrice = 200,
//    Description = "A3 Sedan",
//    ModelYear = 2018
//});

//Console.WriteLine("-----------------------------");

//_carService.Update(new Car
//{
//    Id = 4,
//    BrandId = 1,
//    ColorId = 1,
//    DailyPrice = 250,
//    Description = "A5 Sedann",
//    ModelYear = 2000

//});


Console.WriteLine("-----------------------------");

//_carService.Delete(new Car
//{
//    Id = 1002
//});



IBrandService _brandService = new BrandManager(new EfBrandDal());

foreach (var brand in _brandService.GetAll())
{
    Console.WriteLine("Brands:"+brand.BrandName);
}

//_brandService.Delete(new Brand
//{
//    Id=1003
    
//});


IColorService _colorService = new ColorManager(new EfColorDal());

foreach (var color in _colorService.GetAll())
{
    Console.WriteLine("Colors:" + color.ColorName);
}

//_colorService.Add(new Color
//{
//    ColorName = "Yellow"
//});

//_colorService.Update(new Color
//{   
//    Id=1002,
//    ColorName = "Blue"
//});

//_colorService.Delete(new Color
//{
//    Id = 1002
    
//});