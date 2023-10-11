namespace Day3_polymorphism;

public class PolWithInheritance
{
		private string _name;
	public PolWithInheritance() {
		_name = "papa";
		Console.WriteLine(_name);
	}
	public PolWithInheritance(string name) {
		_name = name;
		Console.WriteLine(_name);
	}
}
class Child:PolWithInheritance {
	public Child(string name) 
	{
		Console.WriteLine(name);
	}
	public Child() : base("parent") {
		// Console.WriteLine()
	}
	//public Child() { parameter sama dengan yang diatas
	//	
	//}
}