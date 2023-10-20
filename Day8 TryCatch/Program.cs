using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Start");

		int result = 0; // Initialize the result variable.

		try
		{
			result = Calculator.PerformComplexCalculation();
		}
		catch (InvalidCalculationException e)
		{
			Console.WriteLine("An error occurred during calculation: " + e.Message);
			result = 0; // Reset the result to zero in case of an error.
		}
		finally
		{
			Console.WriteLine("Release resources");
		}

		Console.WriteLine("Result: " + result);
		Console.WriteLine("Finish all tasks");
	}
}

class Calculator
{
	public static int PerformComplexCalculation()
	{
		Console.WriteLine("Calculator is performing a complex calculation");

		try
		{
			int a = GetUserInput("Enter value for 'a':");
			int b = GetUserInput("Enter value for 'b':");

			// Check for division by zero.
			if (b == 0)
			{
				throw new InvalidCalculationException("Division by zero is not allowed.");
			}

			// Simulate a complex calculation.
			int result = (a + b) / (a - b);

			Console.WriteLine("Calculation completed successfully");
			return result;
		}
		catch (FormatException)
		{
			Console.WriteLine("Invalid input. Please enter valid numbers for 'a' and 'b'.");
			throw new InvalidCalculationException("Invalid input.", new FormatException());
		}
	}

	private static int GetUserInput(string prompt)
	{
		Console.WriteLine(prompt);
		return int.Parse(Console.ReadLine());
	}
}

class InvalidCalculationException : Exception
{
	public InvalidCalculationException(string message) : base(message) { }
	public InvalidCalculationException(string message, Exception innerException) : base(message, innerException) { }
}

