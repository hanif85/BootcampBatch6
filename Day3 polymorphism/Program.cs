//Overloading
using Day3_polymorphism;
class Program {
	static void Main() {
		Calculator calc = new();
		
		calc.Add();
		calc.Add(3,4);
		calc.Add(3,4,5);
		Child c = new Child();
		// calc.Add("1","2").Dump();
	}
}

class Calculator {
		public void printf(string data)
	{
		Console.WriteLine(data);
	}
	
	public void Add() {
		printf("none");
	}
	public void Add(int a, int b) {
		Console.WriteLine(a+b);
	}
	public void Add(int a, int b, int c) {
		Console.WriteLine(a+b+c);
	}
	public string Add(string a, string b) {
		return a+b;
	}
}