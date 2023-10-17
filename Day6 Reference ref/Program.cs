using System;

class Program
{
    static void Main()
    {
        Car car = new Car(2000); // Reference Type
        CarProcessor processor = new CarProcessor();

        processor.MultiplyByTwoCar(car);
        Console.WriteLine("Price after multiplication: " + car.price); // 4000
    }
}

class Car
{
    public int price;

    public Car(int value)
    {
        price = value;
    }
}

class CarProcessor
{
    public void MultiplyByTwoCar(Car input)
    {
        input.price = input.price * 2;
    }
}
