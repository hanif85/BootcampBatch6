using System;

class Program
{
	static void Main()
	{
		MyCollection<string> myStringCollection = new MyCollection<string>();
		myStringCollection.SetValue(0, "hello");
		myStringCollection.SetValue(1, "world");

		string value = myStringCollection.GetValue(0);
		Console.WriteLine(value);
		Console.WriteLine(myStringCollection.GetValue(1));
		
	}
}

class MyCollection<T>
{
	private T[] collection = new T[100];

	public T GetValue(int index)
	{
		if (index >= 0 && index < collection.Length)
		{
			return collection[index];
		}
		throw new IndexOutOfRangeException("Data not found at the specified index.");
	}

	public bool SetValue(int index, T data)
	{
		if (index >= 0 && index < collection.Length)
		{
			collection[index] = data;
			return true;
		}
		return false;
	}
}
