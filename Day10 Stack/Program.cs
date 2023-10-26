using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Reverse Polish Notation (RPN) Calculator");
        Console.WriteLine("Enter an RPN expression, e.g., '3 4 + 5 *':");

        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                break;

            try
            {
                double result = EvaluateRPNExpression(input);
                Console.WriteLine("Result: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    static double EvaluateRPNExpression(string expression)
    {
        var stack = new Stack<double>();
        var tokens = expression.Split(' ');

        foreach (string token in tokens)
        {
            if (double.TryParse(token, out double number))
            {
                stack.Push(number);
            }
            else
            {
                if (stack.Count < 2)
                    throw new InvalidOperationException("Invalid RPN expression.");

                double b = stack.Pop();
                double a = stack.Pop();
                double result = PerformOperation(a, b, token);
                stack.Push(result);
            }
        }

        if (stack.Count != 1)
            throw new InvalidOperationException("Invalid RPN expression.");

        return stack.Pop();
    }

    static double PerformOperation(double a, double b, string operatorSymbol)
    {
        switch (operatorSymbol)
        {
            case "+":
                return a + b;
            case "-":
                return a - b;
            case "*":
                return a * b;
            case "/":
                if (Math.Abs(b) < 1e-6)
                    throw new InvalidOperationException("Division by zero.");
                return a / b;
            default:
                throw new InvalidOperationException("Invalid operator: " + operatorSymbol);
        }
    }
}
