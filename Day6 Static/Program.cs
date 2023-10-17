using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 5;

        int additionResult = Calculator.Add(a, b);
        int subtractionResult = Calculator.Subtract(a, b);
        int multiplicationResult = Calculator.Multiply(a, b);
        int divisionResult = Calculator.Divide(a, b);

        Console.WriteLine($"Addition: {additionResult}");
        Console.WriteLine($"Subtraction: {subtractionResult}");
        Console.WriteLine($"Multiplication: {multiplicationResult}");
        Console.WriteLine($"Division: {divisionResult}");
    }
}

class Calculator
{
    public static int Add(int left, int right)
    {
        return left + right;
    }

    public static int Subtract(int left, int right)
    {
        return left - right;
    }

    public static int Multiply(int left, int right)
    {
        return left * right;
    }

    public static int Divide(int left, int right)
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
