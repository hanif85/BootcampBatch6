using System;
using Day2;
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
public class Program
{
	static void Main(string[] Arg)
	{
		Transportation Civic = new Transportation() ;
		Civic.color = "Red";
		Civic.doors = 4;
		Civic.wheels = 4;
		
		Console.WriteLine($"The Civic with {Civic.color} color and {Civic.doors} doors and {Civic.wheels} wheels is Robert cars");
		string engineOnOff = Civic.EnginRun(true);
		Console.WriteLine(engineOnOff);
	}
}
