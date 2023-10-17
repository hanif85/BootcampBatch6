using System;

class Program
{
	static void Main()
	{
		GameController game = new GameController(new MobileLegendPlayer());
		Console.WriteLine(game.Player);
		GameControllerOnline gameOnline = new GameControllerOnline(new MobileLegendPlayer());
		Console.WriteLine(gameOnline);
	}
}

class GameController
{
	public IPlayer Player { get; }

	public GameController(IPlayer player)
	{
		Player = player;
	}
}

class Internet
{
	public IOnline User { get; }

	public Internet(IOnline user)
	{
		User = user;
	}
}

class GameControllerOnline
{
	public IOnlinePlayer Player { get; }

	public GameControllerOnline(IOnlinePlayer player)
	{
		Player = player;
	}
}

public interface IPlayer
{
	void PlayerName();
}

public interface IOnline
{
	void GetID();
}

public interface IOnlinePlayer : IPlayer, IOnline
{
}

class Player : IPlayer
{
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

	public void GetID()
	{
		Console.WriteLine(1);
	}
}
