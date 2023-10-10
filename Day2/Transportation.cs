namespace Day2;

public class Transportation
{
	public int wheels;
	public int doors;
	public string color;
	
	public string EnginRun(bool onOff)
	{
		if (onOff)
		{
			return "engine is Running Broo!!!";
		} else 
		{
			return "engine is not Running Broo!!";
		}
	}
	public void Move(string direction)
	{
		
	}
}
