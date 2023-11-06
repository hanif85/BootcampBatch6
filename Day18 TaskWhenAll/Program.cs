using System;
using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		Task task1 = Task.Run(() => Console.WriteLine("Hello from Task 1!"));
		Task task2 = Task.Run(() => Console.WriteLine("Hello from Task 2!"));
		Task task3 = Task.Run(() => Console.WriteLine("Hello from Task 3!"));
		
		Task.WhenAll(task1, task2, task3 ).Wait();
		
		Console.WriteLine("Hello from Task 4!");
	}
}