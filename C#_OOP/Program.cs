using System;

class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine("Car Information");
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        Console.WriteLine();
    }
}

class Bike : Vehicle
{
    public string BikeType { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine("Bike Information");
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Bike Type: {BikeType}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car()
        {
            Make = "Lamborghini",
            Model = "Laborgani X1",
            Year = 2024,
            NumberOfDoors = 2
        };

        Bike bike = new Bike()
        {
            Make = "Honda",
            Model = "CBR FireFox",
            Year = 2023,
            BikeType = "Racing"
        };

        car.PrintInfo();
        bike.PrintInfo();
    }
}
