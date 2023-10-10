namespace Day2_Inheritance;

public class Cat : Animal
{
	public Cat(string name) : base(name)
	{
		Console.WriteLine($"Cat instance {name}");
	}
	public void jump()
	{
		Console.WriteLine("Jump");
		
	}
	public void Meow()
	{
		Console.WriteLine("meowwwww");
	}
	
}
