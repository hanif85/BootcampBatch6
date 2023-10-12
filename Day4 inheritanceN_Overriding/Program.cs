class Program{
//Inheritance OK and Overriding and Method Hiding
static void Main() {
	Engine general = new DieselEngine();
	//Engine e = new Engine();
	//DieselEngine diesel = new DieselEngine();
	//e = diesel;

	DieselEngine diesel = new();
	ElectricEngine electric = new();
	HidrogenEngine hidrogenEngine = new();
	hidrogenEngine.Emission();
	diesel.Emission();
	
	
	Car car = new Car(diesel);
	car.EngineStart();
	
}
}
class Car
{
	private Engine _engine;
	public Car(Engine e)
	{
		_engine = e;
	}
	public void EngineStart()
	{
		_engine.Run();
		_engine.WarmUp();
	}

}
class Engine {
	public virtual void Run() {
		Console.WriteLine("Engine Run");
	}
	public virtual void WarmUp() {
	}
	public virtual void Emission()
	{
		Console.WriteLine("Check emission");
	}
}
class DieselEngine : Engine
{
	public override void Run()
	{
		Console.WriteLine("Diesel Engine Run");
	}
	public override void WarmUp() {
		Console.WriteLine("Diesel Engine Warm Up");
	}
	public override void Emission()
	{
		Console.WriteLine("Diesel  is low emission");
	}
}
class ElectricEngine : Engine
{
	public override void Run()
	{
		Console.WriteLine("Electric Engine Run");
	}
	public override void Emission()
	{
		Console.WriteLine("Hidrogen is low emission");
	}
}

class HidrogenEngine : Engine
{
	public override void Run()
	{
		Console.WriteLine("Hidrogen Engine Run");
		
	}
	public override void Emission()
	{
		Console.WriteLine("Hidrogen is low emission");
	}
}