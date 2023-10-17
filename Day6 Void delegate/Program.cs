using System;

// Define a delegate to hold methods with no parameters and no return value
public delegate void MyDelegate();

class Program
{
    static void Main()
    {
        // Create an instance of MyDelegate and add methods to it
        MyDelegate myDelegate = Printer;
        myDelegate += Layangan;
        myDelegate += Printer2;
        myDelegate += Layangan2;

        // Invoke the delegate to execute all added methods
        myDelegate();

        // Additional example with a different set of methods
        MyDelegate myOtherDelegate = Greet;
        myOtherDelegate += Goodbye;
        myOtherDelegate();

        // Explanation:
        Console.WriteLine("The delegate 'myDelegate' holds a list of methods and can invoke all of them.");
    }

    // Methods that will be added to the delegate
    static void Printer()
    {
        Console.WriteLine("Printer");
    }

    static void Layangan()
    {
        Console.WriteLine("Layangan");
    }

    static void Printer2()
    {
        Console.WriteLine("Printer2");
    }

    static void Layangan2()
    {
        Console.WriteLine("Layangan2");
    }

    // Additional methods for the second example
    static void Greet()
    {
        Console.WriteLine("Hello!");
    }

    static void Goodbye()
    {
        Console.WriteLine("Goodbye!");
    }
}
