<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Car with interface
class Car {
	public IEngine engine;
	public Car(IEngine e) {
		engine = e;
	}
	public void Move() {
		engine.Run();
	}
}
public interface IEngine { 
	void Run();
}
class ElectricEngine : IEngine {
	public void Run() {
		"Electric Engine Run".Dump();
	}
}
class HydrogenEngine : IEngine
{
	public void Run()
	{
		"Hydrogen Engine Run".Dump();
	}
}
void Main() {
	Car car = new Car(new IEngine());
	car.Move();
}