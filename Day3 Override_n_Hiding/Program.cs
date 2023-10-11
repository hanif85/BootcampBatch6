//Method Hiding + Overriding
class Program 
{
	static void Main() 
	{
		Cat cat = new Cat(); //Override
		cat.MakeSound(); //Meow 
		cat.leg(4);
		Animal parent = cat;
		parent.MakeSound(); //Meow
		
		Dog dog = new Dog(); //Idem
		dog.MakeSound(); //Make Sound
		dog.leg(4);
		Animal parent2 = dog;
		parent2.MakeSound(); //Make Sound
		
		Bird bird = new Bird(); //Method Hiding
		bird.MakeSound(); //Chip
		bird.leg(2);
		Animal parent3 = bird;
		parent3.MakeSound(); //MakeSound
		Algae greenAlgae = new();
		greenAlgae.MakeSound();
	
	}
}
class Algae
{
	public void MakeSound()
	{
		Console.WriteLine("no sound");
	}
}


class Bird : Animal
{
	public new void MakeSound() //Method Hiding
	{
		Console.WriteLine("Chirp");
	}
	public override void leg(int n)
	{
		base.leg(n);
	}
}
class Dog : Animal //Ngikut
{ 
	public override void leg(int n)
	{
		base.leg(n);
	}
}
class Cat : Animal //Overriding
{
	public override void MakeSound()
	{
		Console.WriteLine("Meow");
	}
	public override void leg(int n)
	{
		base.leg(n);
	}
}
class Animal
{
	public virtual void MakeSound()
	{
		Console.WriteLine("Make Sound");
	}
	public virtual void leg(int n)
	{
		Console.WriteLine($"The legs are {n}");
	}
}