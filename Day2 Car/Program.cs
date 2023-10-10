using System;
using Day2_Car;

class Program
{
	static void Main(string [] args)
	{
		Engine Gasoline = new Engine("Gasoline", "Lamborgini");
		Tire tire = new Tire();
		Lamp LED = new Lamp();
		tire.tireSize = 14;
		
		Car car = new Car("honda", "civic", "Silver");
		Car detail = new Car(Gasoline, tire, LED);
		car.print(		car.GetValue());
	}
}