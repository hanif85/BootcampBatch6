namespace Day17.DebuggerTutorial;



	static class Program
	{
		static void Main()
		{
			double a = 4.0;
			double b = 2.5;
			double answer = Add(a, b);
			
			Console.WriteLine($"{a} + {b} = {answer}");
		}
		static double Add(double a, double b)
		{
			return a + b;
		}
	}
