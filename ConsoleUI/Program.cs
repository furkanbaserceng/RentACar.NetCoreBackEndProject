


using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System.Collections.Generic;

ICarService _carService = new CarManager(new InMemoryCarDal());

foreach (var car in _carService.GetAll())
{
    Console.WriteLine(car.DailyPrice);
    Console.WriteLine(car.ModelYear);
    Console.WriteLine(car.Description);
    Console.WriteLine("-------------");

}

Console.WriteLine("--------------------------------------------------");


