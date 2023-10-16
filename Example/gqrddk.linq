<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//MobileLegend
void Main() {
	GameController game = new(new MobileLegendPlayer());
	
	GameControllerOnline gameOnline = new(new MobileLegendPlayer());
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
		"Player".Dump();
	}
}
class MobileLegendPlayer : IOnlinePlayer
{
	public void PlayerName()
	{
		"MobileLegendPlayer".Dump();
	}
	public void GetID() {
		1.Dump();
	}
}