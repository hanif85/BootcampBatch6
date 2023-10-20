using System;

class Program
{
    static void Main()
    {
        Car car = new Car();

        // Check if 'x' is initialized to a value
        if (car.x == 0)
        {
            Console.WriteLine("Car 'x' is not initialized to a value.");
        }
        else
        {
            Console.WriteLine("Car 'x' is initialized to: " + car.x);
        }

        // Check if 'y' is null
        if (car.y == null)
        {
            Console.WriteLine("Car 'y' is null.");
        }
        else
        {
            Console.WriteLine("Car 'y' is not null and has a length of: " + car.y.Length);
        }
    }
}

class Car
{
    public Engine engine = new Engine();
    public string? y;
    public int x;
}

class Engine
{
    public void Test()
    {
        Console.WriteLine("test");
    }
}
