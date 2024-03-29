﻿


using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

using Entities.Concrete;
using System.Collections.Generic;

ICarService _carService = new CarManager(new EfCarDal());
IBrandService _brandService = new BrandManager(new EfBrandDal());
IColorService _colorService = new ColorManager(new EfColorDal());
IUserService _userService=new UserManager(new EfUserDal());



//foreach (var car in _carService.GetAll())
//{
//    Console.WriteLine("{0}",car.Description);

//}

//Console.WriteLine("-----------------------------");

//foreach (var carDTO in _carService.GetCarDetails())
//{
//    Console.WriteLine(carDTO.CarName+"-->"+carDTO.BrandName+"-->"+carDTO.ColorName);
//}

//Console.WriteLine("-----------------------------");

//foreach(var car in _carService.GetCarsByBrandId(1))
//{
//    Console.WriteLine(car.Description);
//}

//Console.WriteLine("-----------------------------");


//foreach (var car in _carService.GetCarsByColorId(1))
//{
//    Console.WriteLine(car.Description);
//}

//Console.WriteLine("-----------------------------");

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





//foreach (var brand in _brandService.GetAll())
//{
//    Console.WriteLine("Brands:"+brand.BrandName);
//}

////_brandService.Delete(new Brand
////{
////    Id=1003

////});




//foreach (var color in _colorService.GetAll())
//{
//    Console.WriteLine("Colors:" + color.ColorName);
//}

//_colorService.Add(new Color
//{
//    ColorName = "Yellow"
//});

//_colorService.Update(new Color
//{   
//    Id=1002,
//    ColorName = "Blue
//});

//_colorService.Delete(new Color
//{
//    Id = 1002

//});


//Console.WriteLine("---------------------------------------");
//foreach (var productDTO in _carService.GetCarDetails())
//{

//    Console.WriteLine("Car Name:{0}",productDTO.CarName);
//    Console.WriteLine("Brand Name:{0}",productDTO.BrandName);
//    Console.WriteLine("Color Name:{0}",productDTO.ColorName);
//    Console.WriteLine("Daily Price:{0}",productDTO.DailyPrice);
//    Console.WriteLine("Model Year:{0}",productDTO.ModelYear);
//    Console.WriteLine("****");

//}



//var result = _carService.GetAll();

//if (result.Success)
//{

//    foreach (var car in result.Data)
//    {
//        Console.WriteLine(car.Description);
//    }

//}
//else
//{
//    Console.WriteLine(result.Message);
//}


//var result = _userService.GetAll();

//if (result.Success)
//{

//    foreach (var user in result.Data)
//    {

//        Console.WriteLine(user.FirstName+" "+user.LastName+" "+ user.Email);

//    }

//}
