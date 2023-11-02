//IEnumerable GetEnumerator
public class Program
{	
	static void Main()
	{
		List<int> myInt = new List<int> {1,2,3};
		var enumerable = myInt.GetEnumerator();
		
		enumerable.MoveNext();
		enumerable.MoveNext();
		// enumerable.MoveNext();
		// enumerable.MoveNext();
		// enumerable.MoveNext();
		int result = enumerable.Current;
		Console.WriteLine(result);
		
		foreach(var x in myInt) {
			Console.WriteLine(x);
		}
	}
}
public class Multiply
{
	
}

