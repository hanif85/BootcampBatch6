namespace Day17.HotReload;

public class HoReload
{
	public static async void Main()
	{
		while (true)
		{
			Console.WriteLine("TEST");
			await Task.Delay(2000);
		}
	}
}
