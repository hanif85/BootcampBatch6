using System;

class Program
{
	static void Main()
	{
		Parent p = new Child();
		Child c = (Child)p;
		Console.WriteLine(c.x);
		// Console.WriteLine(p)
	}
}

class Parent { }

class Child : Parent
{
	public int x = 3;
}
