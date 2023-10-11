namespace Day2_Inheritance;

public class Animal
{
	public string name="";
	public string sound="";
	public int age;
	public Animal(string name)
	{
		this.name = name;
		Console.WriteLine("Animal instance created");
		
	}
	public void Eat(string getEat)
	{
		Console.WriteLine(getEat);
	}
}
