namespace Day2_Car;

public class Car
{
	public string brand;
	public string type;
	public string color;
	public Engine mesin;
	public Tire ban;
	public Lamp lamp;
	public  Car (string brand, string type, string color)
	{
		this.brand = brand;
		this.type = type;
		this.color = color;
				
		
	}
	public Car(Engine engine, Tire tire, Lamp lamp) 
	{
		Console.WriteLine("sudah menerima engine, ban, lampu");
		mesin = engine;
		ban = tire;
		this.lamp = lamp;
	}

    public string GetValue()
    {
        return $"Mesin {mesin} , type ban{ban}, tipe lampu {this.lamp}";
    }

    public void print(string value)
	{
		Console.WriteLine(value);
	
		Console.WriteLine($"Brand {brand}, type {type}, color {color}");
	}
	
	
}
