namespace ConsoleApp13;


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>()
        {
            new Car("Toyota", 120),
            new Bicycle("Trek", 25),
            new Airplane("Boeing", 900)
        };

        foreach (Vehicle v in vehicles)
        {
            v.Move();

            if (v is Refuelable refuelable)
            {
                refuelable.Refill();
            }

            Console.WriteLine();
        }
    }
}

abstract class Vehicle
{
    public string brand;
    public int speed;

    public Vehicle(string brand, int speed)
    {
        this.brand = brand;
        this.speed = speed;
    }

    public abstract void Move();
}

interface Refuelable
{
    void Refill();
}

class Car : Vehicle, Refuelable
{
    public Car(string brand, int speed) : base(brand, speed) { }

    public override void Move()
    {
        Console.WriteLine($"Car {brand} drives on the road with speed {speed} km/h");
    }

    public void Refill()
    {
        Console.WriteLine($"Car {brand} is refueling at the gas station");
    }
}

class Bicycle : Vehicle
{
    public Bicycle(string brand, int speed) : base(brand, speed) { }

    public override void Move()
    {
        Console.WriteLine($"Bicycle {brand} is pedaling with speed {speed} km/h");
    }
}

class Airplane : Vehicle, Refuelable
{
    public Airplane(string brand, int speed) : base(brand, speed) { }

    public override void Move()
    {
        Console.WriteLine($"Airplane {brand} flies in the sky with speed {speed} km/h");
    }

    public void Refill()
    {
        Console.WriteLine($"Airplane {brand} is refueling aviation fuel");
    }
}
