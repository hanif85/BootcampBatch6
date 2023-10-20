<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Action
void Main()
{
	
}
class CardCreator
{
	public List<Card> cards;
	public Action<Card> onCardUpdate;
	public void CreateCard(int id, string description) 
	{
		Card card = new Card() {id = id, description = description};
		cards.Add(card);
		Update(card);
	}
	public void Update(Card card)
	{
		onCardUpdate?.Invoke(card);
	}
}
class Card { 
	public int id;
	public string description;
}
class UI
{
	public void Notification(Card data)
	{
		$"Update UI location {data.id} , {data.description}".Dump();
	}
}
class Database
{
	public void AddCardToDb(Card data)
	{
		$"Update Database {data.id} , {data.description}".Dump();
	}
}