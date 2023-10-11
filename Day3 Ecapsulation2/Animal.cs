// using Microsoft.VisualBasic;

namespace Day3_Ecapsulation2;

public class Animal
{
	public string name = "";
	private int _animalAge;
	public bool isHaveTail;
	
	public int animalAge
	{
		get
		{
			return _animalAge;
		}
		set
		{
			_animalAge = value;
		}
		
	}
	public Animal(int age)
	{
		 animalAge = age;
		//  return animalAge;
	}
	
}

public class Cat:Animal
{
	public string color="";
	public int age;
	public Cat(int age):base(age)
	{
		
	}
	public void print()
	{
		age = animalAge;
	}
	
 	
}
