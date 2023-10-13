//Reference
class Program

{
	static void Main(string[] args)
	{
		string x = "3";
		Car car1 = new Car(3);
		Car car2 = car1;
		car2.value = 5;
		Car car3 = new Car(5);
		car3 = car1;
		car3.value = 10;
		
		Console.WriteLine(car1.value);
		Console.WriteLine(car2.value);
		Console.WriteLine(car3.value);

	}
}

class Car {
	public int value;
	public Car(int x) {
		value = x;
	}
}
