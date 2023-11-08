namespace Day17.DocumentationXML;

public class TheLib
{
	
	/// <summary>
	/// Adds two numbers together and returns the result.
	/// </summary>
	/// <param name="a">The first number to add.</param>
	/// <param name="b">The second number to add.</param>
	/// <returns>The sum of a and b kayae</returns>
	public static double Add(double a, double b)
	{
		return a + b;
	}

	/// <summary>
    /// Multiply two numbers together and returns the result.
    /// </summary>
    /// <param name="a">The first number to multiply.</param>
    /// <param name="b">The second number to multiply.</param>
    /// <returns>The multiply of a and b.</returns>
	public static double Mul(double a, double b)
	{
		return a * b;
	}

	public static double Div(double a, double b)
	{
		return a / b;
	}

	public static double Sub(double a, double b)
	{
		return a - b;
	}
}
