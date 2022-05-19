


using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System.Collections.Generic;

ICarService _carService = new CarManager(new InMemoryCarDal());

Simulation1(_carService);

Console.WriteLine("--------------------------------------------------");











static void Simulation1(ICarService _carService)
{
    foreach (var car in _carService.GetAll())
    {
        Console.WriteLine(car.DailyPrice);
        Console.WriteLine(car.ModelYear);
        Console.WriteLine(car.Description);
        Console.WriteLine("-------------");

    }
}