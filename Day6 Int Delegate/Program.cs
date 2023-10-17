using System;

// Define a delegate to hold methods with two integer parameters and a return value of int
public delegate int MyDelegate(int left, int right);

class Program
{
    static void Main()
    {
        // Create an instance of MyDelegate and add methods to it
        MyDelegate myDelegate = Add;
        myDelegate += Subtract;
        myDelegate += Multiply;
        myDelegate += Divide;

        // Invoke the delegate to execute all added methods and collect the result
        int result = myDelegate(10, 5);

        // Display the result
        Console.WriteLine("Result: " + result);

        // Explanation:
        Console.WriteLine("The delegate 'myDelegate' holds a list of methods that take two integers and return an integer.");
    }

    // Methods that will be added to the delegate
    static int Add(int left, int right)
    {
        return left + right;
    }

    static int Subtract(int left, int right)
    {
        return left - right;
    }

    static int Multiply(int left, int right)
    {
        return left * right;
    }

    static int Divide(int left, int right)
    {
        if (right != 0)
        {
            return left / right;
        }
        else
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
    }
}
