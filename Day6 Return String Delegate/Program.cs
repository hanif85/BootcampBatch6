using System;

// Define a delegate to hold methods with no parameters and a return value of string
public delegate string MyDelegate();

class Program
{
    static void Main()
    {
        // Create an instance of MyDelegate and add methods to it
        MyDelegate myDelegate = Printer;
        myDelegate += Layangan;

        // Invoke the delegate to execute all added methods and collect the results
        string result = myDelegate();

        // Display the result
        Console.WriteLine("Result: " + result);

        // Additional example with a different set of methods
        MyDelegate myOtherDelegate = Greet;
        myOtherDelegate += Goodbye;
        string otherResult = myOtherDelegate();

        // Display the result of the additional example
        Console.WriteLine("Other Result: " + otherResult);

        // Explanation:
        Console.WriteLine("The delegate 'myDelegate' holds a list of methods and can invoke all of them.");
    }

    // Methods that will be added to the delegate
    static string Printer()
    {
        return "Printer";
    }

    static string Layangan()
    {
        return "Layangan";
    }

    // Additional methods for the second example
    static string Greet()
    {
        return "Hello!";
    }

    static string Goodbye()
    {
        return "Goodbye!";
    }
}
