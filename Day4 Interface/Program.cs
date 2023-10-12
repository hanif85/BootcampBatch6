
// Interface
using System.Runtime.InteropServices.Marshalling;

interface IAnimal 
{
  void animalSound(); // interface method (does not have a body)
  void isTailLong(bool tail);
}
interface IMammalia
{
	void drinkMilk();
	void isbreathWithLung();
}

// Cat "implements" the IAnimal interface
class Cat : IAnimal, IMammalia
{
  public void animalSound() 
  {
	// The body of animalSound() is provided here
	Console.WriteLine("The Cat says: miauw miauw");
  }

	public void drinkMilk()
	{
		Console.WriteLine("Cat drink milk");
	}

	public void isbreathWithLung()
	{
		Console.WriteLine("Yes, I have Lung");
	}

	public void isTailLong(bool tail)
  {
	if (tail)
	{
		Console.WriteLine("The tail is long");
	}else{
		Console.WriteLine("the tail is short");
	}
  	
  }
}
class Goat : IAnimal, IMammalia
{
  public void animalSound() 
  {
	// The body of animalSound() is provided here
	Console.WriteLine("The Goat says: mbeeek mbeeek");
  }

	public void drinkMilk()
	{
		Console.WriteLine("Goat drink milk");
	}

	public void isbreathWithLung()
	{
		Console.WriteLine("Yes, I have Lung");
	}

	public void isTailLong(bool tail)
  {
	if (tail)
	{
		Console.WriteLine("The tail is long");
	}else{
		Console.WriteLine("the tail is short");
	}
  	
  }
}
class Program 
{
  static void Main(string[] args) 
  {
	Cat myCat = new Cat();  // Create a Pig object
	myCat.animalSound();
	myCat.isTailLong(true);
	myCat.drinkMilk();
	myCat.isbreathWithLung();
	Goat mygoat = new Goat();
	mygoat.animalSound();
	mygoat.isTailLong(false);
	mygoat.drinkMilk();
	mygoat.isbreathWithLung();
  }
}