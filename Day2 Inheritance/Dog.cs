namespace Day2_Inheritance;

public class Dog : Animal
{
	public Dog(string name) : base(name)
	{
		Console.WriteLine($"Dog name {name} created");
	}
	public void Run()
	{
		Console.WriteLine("Run");
	}
	public void Bark()
	{
		Console.WriteLine("Bark");
	}
	
}
