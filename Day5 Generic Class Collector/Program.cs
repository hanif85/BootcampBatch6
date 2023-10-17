using System;

class Program
{
	static void Main()
	{
		GenericCollection<int, string> generic = new GenericCollection<int, string>();
		generic.Add(3, "hello");
		
		generic.Add(4, "true");
	}
}

class GenericCollection<T, T2>
{
	private T[] myCollection = new T[100];
	private T2[] myCollection2 = new T2[100];
	private int counter = 0;

	public bool Add(T input, T2 input2)
	{
		if (counter < myCollection.Length)
		{
			myCollection[counter] = input;
			myCollection2[counter] = input2;
			counter++;
			
			return true;
		}
		return false;
	}
}
