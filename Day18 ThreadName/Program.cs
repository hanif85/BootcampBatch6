using System;
using System.Threading;

class Program
{
	static void Main()
	{

		Thread thread = new Thread(DoWork);
		Thread secondThread = new Thread(DoWork);
		Thread otherThread = new Thread(DoOtherWork);


		thread.Name = "Worker Thread";
		secondThread.Name = "Second Worker Thread";
		otherThread.Name = "Other Worker Thread";


		thread.Start();
		secondThread.Start();
		otherThread.Start();

		thread.Join();
		secondThread.Join();
		otherThread.Join();
		
		Console.WriteLine("Main thread exiting.");
	}

	static void DoWork()
	{
		Console.WriteLine($"Thread {Thread.CurrentThread.Name} started.");
		Thread.Sleep(2000);
		Console.WriteLine($"Thread {Thread.CurrentThread.Name} finished.");
	}
	static void DoOtherWork()
	{
		Console.WriteLine($"Thread {Thread.CurrentThread.Name} started.");
		Thread.Sleep(200);
		Console.WriteLine($"Thread {Thread.CurrentThread.Name} finished.");
	}
}