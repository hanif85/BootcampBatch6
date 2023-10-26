using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<Player, PlayerInfo> playerInfo = new Dictionary<Player, PlayerInfo>();

        // Create players and their information
        Player player1 = new Player();
        Player player2 = new Player();
        Player player3 = new Player();

        PlayerInfo info1 = new PlayerInfo();
        PlayerInfo info2 = new PlayerInfo();
        PlayerInfo info3 = new PlayerInfo();

        playerInfo.Add(player1, info1);
        playerInfo.Add(player2, info2);
        playerInfo.Add(player3, info3);

        // Add cards to player1
        info1.AddCard(new Card("Ace of Spades"));
        info1.AddCard(new Card("King of Hearts"));

        // Set player colors and scores
        info1.SetColor(Colour.Black);
        info1.SetScore(21);

        info2.SetColor(Colour.White);
        info2.SetScore(17);

        info3.SetColor(Colour.Black);
        info3.SetScore(19);

        // Print player information
        foreach (var kvp in playerInfo)
        {
            Console.WriteLine("Player: " + kvp.Key);
            Console.WriteLine("Cards: " + string.Join(", ", kvp.Value.GetCards()));
            Console.WriteLine("Color: " + kvp.Value.GetColor());
            Console.WriteLine("Score: " + kvp.Value.GetScore());
            Console.WriteLine();
        }
    }
}

class PlayerInfo
{
    private List<Card> _playerCards;
    private Colour _playerColour;
    private int _playerScore;
    private int _playerBet;

    public PlayerInfo()
    {
        _playerCards = new List<Card>();
    }

    public void AddCard(Card card)
    {
        _playerCards.Add(card);
    }

    public List<Card> GetCards()
    {
        return _playerCards;
    }

    public void SetColor(Colour color)
    {
        _playerColour = color;
    }

    public Colour GetColor()
    {
        return _playerColour;
    }

    public void SetScore(int score)
    {
        _playerScore = score;
    }

    public int GetScore()
    {
        return _playerScore;
    }
}

public enum Colour
{
    White,
    Black
}

class Player { }

class Card
{
    public string Name { get; }

    public Card(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}
