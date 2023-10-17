<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//List Collection / Generic with Abstraction
void Main()
{
	List<ITransport> myList = new List<ITransport>();
	myList.Add(new Car());
	myList.Add(new Truck());
	myList.Add(new Plane());
	//myList.Add(new Sayur()); Error
}
public interface ITransport { }
class Car : ITransport{ }
class Truck : ITransport { }
class Plane : ITransport { }
class Sayur { }