//String(immutable) vs StringBuilder(mutable)
using System.Diagnostics;
using System.Text;
class Program
{
	

	static void Main()
	{
		// StringBuilder
		Stopwatch stopwatch = new Stopwatch();
		//String
		string a = String.Empty;
		stopwatch.Start();
		for (int i = 0; i < 2000; i++)
		{
			a += ("Hello");
			a += ("World");
			a += ("!");
		}
		stopwatch.Stop();
		Console.WriteLine($"String : {stopwatch.ElapsedMilliseconds} ms");


		//StringBuilder
		StringBuilder sb = new StringBuilder();
		stopwatch.Restart();
		for(int i = 0; i < 2000; i++) 
		{
			sb.Append("Hello");
			sb.Append("World");
			sb.Append("!");
		}
		stopwatch.Stop();
		Console.WriteLine($"StringBuilder : {stopwatch.ElapsedMilliseconds} ms");

	}
}