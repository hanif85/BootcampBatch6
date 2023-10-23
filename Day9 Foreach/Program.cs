// See https://aka.ms/new-console-template for more information

class Program
{
	static void Main()
	{
		int[] myArray = {1,2,3,4,5};
		foreach(int i in myArray) {
			Console.WriteLine(i);
		// i.Dump();
	}
	
	List<string> myList = new List<string>() {"a","b","c"};
	foreach(string str in myList) {
		Console.WriteLine(str);
		// str.Dump();
	}
	
	List<Car> myCar = new List<Car>() {
		new Car("Hello"),
		new Car("TEST"),
		new Car("toyota")
	};
	foreach(Car car in myCar) {
		Console.WriteLine(car.brand);
	}
	}
}
class Car
{
	public string brand;
	public Car(string brand)
	{
		this.brand = brand;
	}
}