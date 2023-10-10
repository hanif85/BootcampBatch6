// See https://aka.ms/new-console-template for more information
// using System;
using TheCat;
public class Program
{
	static void Main(string[] args)
	{
		Cat Anabul = new Cat();
		Anabul.size = "big";
		Anabul.color = "Grey";
		Anabul.leg = 4;
		Console.WriteLine ($"Anabul size is {Anabul.size}, has {Anabul.color} color and the legs is {Anabul.leg}");
		Anabul.Run("Anabul slow when run");
		Anabul.Jump("Anabul sometimes jump");
		Cat Oyen = new Cat();
		Anabul.size = "Slim";
		Anabul.color = "Orange";
		Anabul.leg = 4;	
		Console.WriteLine ($"Oyen size is {Oyen.size}, has {Oyen.color} color and the legs is {Oyen.leg}");
		Oyen.Run("Oyen fast when run");
		Oyen.Jump("Oyen almost jump All the time");
	}
}
