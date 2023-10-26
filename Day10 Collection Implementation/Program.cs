using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<Player, Data> dictPlayers = new Dictionary<Player, Data>();

        Player player1 = new Player();
        Player player2 = new Player();
        Player player3 = new Player();

        dictPlayers.Add(player1, new Data(Colour.Black, 0, 100));
        dictPlayers.Add(player2, new Data(Colour.White, 0, 100));
        dictPlayers.Add(player3, new Data(Colour.Black, 0, 100));

        // Simulate dealing cards to players
        DealCards(dictPlayers, player1, new Card("Ace of Spades"));
        DealCards(dictPlayers, player1, new Card("King of Hearts"));
        DealCards(dictPlayers, player2, new Card("Queen of Diamonds"));
        DealCards(dictPlayers, player2, new Card("Jack of Clubs"));
        DealCards(dictPlayers, player3, new Card("Ten of Spades"));
        DealCards(dictPlayers, player3, new Card("Nine of Hearts"));

        // Perform operations on player data
        foreach (var kvp in dictPlayers)
        {
            Console.WriteLine($"Player: {kvp.Key}");
            Console.WriteLine("Cards: " + string.Join(", ", kvp.Value.GetCards()));
            Console.WriteLine($"Color: {kvp.Value.GetColour()}");
            Console.WriteLine($"Score: {kvp.Value.GetScore()}");
            Console.WriteLine($"Bet: {kvp.Value.GetBet()}");
            Console.WriteLine();
        }
    }

    static void DealCards(Dictionary<Player, Data> dictPlayers, Player player, Card card)
    {
        if (dictPlayers.ContainsKey(player))
        {
            dictPlayers[player].AddCards(card);
        }
    }
}

class Data
{
    private List<Card> _playerCards;
    private Colour _playerColour;
    private int _playerScore;
    private int _playerBet;

    public Data(Colour colour, int initialScore, int bet)
    {
        _playerCards = new List<Card>();
        _playerColour = colour;
        _playerScore = initialScore;
        _playerBet = bet;
    }

    public bool AddCards(Card card)
    {
        _playerCards.Add(card);
        return true;
    }

    public List<Card> GetCards()
    {
        return _playerCards;
    }

    public Colour GetColour()
    {
        return _playerColour;
    }

    public int GetScore()
    {
        return _playerScore;
    }

    public int GetBet()
    {
        return _playerBet;
    }
}

public enum Colour
{
    White,
    Black
}

class Player
{
    public override string ToString()
    {
        return "Player";
    }
}

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
