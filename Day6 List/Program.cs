using System;
using System.Collections.Generic;

public class TransportApp
{
	public void Run()
	{
		List<ITransport> myList = new List<ITransport>();
		myList.Add(new Car());
		myList.Add(new Truck());
		myList.Add(new Plane());
		//myList.Add(new Sayur()); // This line would cause a compilation error
	}
}

public interface ITransport { }

public class Car : ITransport { }

public class Truck : ITransport { }

public class Plane : ITransport { }

public class Sayur { }

class Program
{
	static void Main()
	{
		TransportApp app = new TransportApp();
		app.Run();
	}
}

