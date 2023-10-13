public class Program
{
	//var, object, dynamic
	
	static void Printer(object x)
	{
		Console.WriteLine(x);
		// x.Dump();
	}
	static void Add(object x, object y)
	{
		if(x is int && y is int) {
			int a = (int)x;
			int b = (int)y;
			Console.WriteLine(a+b);
			// (a+b).Dump();
		}
		if(x is Car) {
			Console.WriteLine("Tidak masuk akal");
			
		}
	}
	static void Main() 
	{
		//var = compiler help decide variable type
		var myInt = 3;	
		myInt = int.Parse("1");
		Console.WriteLine(myInt);
		// myInt.Dump();
		
		//object
		int myInt2 = 2;
		object x = myInt2;
		Console.WriteLine(x);
		// x.Dump();
		
		int myInt3 = 3;
		object obj = myInt3; //Boxing
		float result = (int)obj; //Unboxing
		
		Printer(3);
		Printer("a");
		Printer(true);
		Printer(3.0f);
		Printer(3.0M);
		
		Add(3,3);
		Add(new Car(), new Car());
		
		//dynamic (dont use it)
		dynamic myDynamic = 3;
		myDynamic = "3";
		myDynamic = true;
		myDynamic = new Car();
		myDynamic.CallIstriGuwe();
		myDynamic.Mboh();
		myDynamic.EngineRunButBurnKetoke();
	}
}


class Car{}