class Program 
{
	//String is Reference, but string immutable and when we input new data that make new address in heap that store new data
	static void Main(string[] args)
	{
		string a = "3";
		string b = a;
		b = "5";
		
		Console.WriteLine(a);
		Console.WriteLine(b);
		// a.Dump();
		// b.Dump();
		
		string myString = "hello";
		myString = "World";
		myString += "!";
		//myString = myString + "!";
		
	}


}