//MobileLegend
public class Program
{
	static void Main() {
	GameController game = new(new MobileLegendPlayer());
	// game.player();
	GameControllerOnline gameOnline = new(new MobileLegendPlayer());
	// gameOnline.player();
}
}

class GameController {
	public IPlayer player;
	public GameController(IPlayer p) {
		player = p;
	}
}
class Internet
{
	public IOnline user;
	public Internet(IOnline u)
	{
		user = u;
	}
}
class GameControllerOnline
{
	public IOnlinePlayer player;
	public GameControllerOnline(IOnlinePlayer p)
	{
		player = p;
	}
}
public interface IPlayer {
	void PlayerName();
}
public interface IOnline {
	void GetID();
}
public interface IOnlinePlayer : IPlayer, IOnline 
{
	
}
class Player : IPlayer {
	public void PlayerName() 
	{
		Console.WriteLine("Player");
	}
}
class MobileLegendPlayer : IOnlinePlayer
{
	public void PlayerName()
	{
		Console.WriteLine("MobileLegendPlayer");
	}
	public void GetID() {
		Console.WriteLine(1);
	}
}