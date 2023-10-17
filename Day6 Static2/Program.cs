using System;

class Program
{
    static void Main()
    {
        // Create two car instances
        Car carA = new Car();
        Car carB = new Car();

        // Set the price for carA and carB using the PriceHandler method
        carB.PriceHandler(10);
        carA.PriceHandler(11);

        // Retrieve and display the prices for carA, carB, and the static price
        Console.WriteLine("Car A Price: " + carA.GetPrice());
        Console.WriteLine("Car B Price: " + carB.GetPrice());
        Console.WriteLine("Static Price: " + Car.StaticPrice);

        // Additional example:
        Car carC = new Car();
        carC.PriceHandler(12);
        Console.WriteLine("Car C Price: " + carC.GetPrice());
    }
}

class Car
{
    // Static field to store the price shared across all instances
    public static int StaticPrice;

    // Instance method to set the price for the specific car instance
    public void PriceHandler(int price)
    {
        StaticPrice = price;
    }

    // Instance method to get the price of the specific car instance
    public int GetPrice()
    {
        return StaticPrice;
    }
}
