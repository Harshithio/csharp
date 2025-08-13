using System;
interface IVehicle
{
    void Start();
    void Stop();
}

class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Car is starting...");
    }

    public void Stop()
    {
        Console.WriteLine("Car is stopping...");
    }
}

class Bike : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Bike is starting...");
    }

    public void Stop()
    {
        Console.WriteLine("Bike is stopping...");
    }
}

class Truck : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Truck is starting...");
    }

    public void Stop()
    {
        Console.WriteLine("Truck is stopping...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        IVehicle car = new Car();
        IVehicle bike = new Bike();
        IVehicle truck = new Truck();

        Console.WriteLine("=== Car Actions ===");
        car.Start();
        car.Stop();

        Console.WriteLine("\n=== Bike Actions ===");
        bike.Start();
        bike.Stop();

        Console.WriteLine("\n=== Truck Actions ===");
        truck.Start();
        truck.Stop();

        Console.ReadLine(); // Keep the console window open
    }
}

