
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var cars = new List<Car> { new Car { Type = "Coupe", Year = 2022 }, new Car { Type = "Truck", Year = 2020 }, new Car { Type = "Coupe", Year = 2021 }, new Car { Type = "Bus", Year = 2019 }, new Car { Type = "Truck", Year = 2023 } };
        var sortedCars = cars.OrderBy(car => car.Type)           .ThenBy(car => car.Year); 

    foreach (var car in sortedCars) { Console.WriteLine($"{car.Type} - {car.Year}"); }
    }
}
class Car { public string Type { get; set; } public int Year { get; set; } }