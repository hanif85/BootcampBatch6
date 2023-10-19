using System;
using System.Threading;

class Program
{
    static void Main()
    {
        StockMarketMonitor stockMarketMonitor = new StockMarketMonitor();
        Trader trader1 = new Trader("Alice");
        Trader trader2 = new Trader("Bob");
        StockAnalyst stockAnalyst = new StockAnalyst("John");

        stockMarketMonitor.StockPriceChanged += trader1.OnStockPriceChanged;
        stockMarketMonitor.StockPriceChanged += trader2.OnStockPriceChanged;
        stockMarketMonitor.StockPriceChanged += stockAnalyst.OnStockPriceChanged;

        // Simulate stock price changes
        for (int i = 0; i < 5; i++)
        {
            stockMarketMonitor.UpdateStockPrice("XYZ", 100 + i);
            Thread.Sleep(1000);
        }
    }
}

class StockMarketMonitor
{
    public event EventHandler<StockPriceChangedEventArgs> StockPriceChanged;

    public void UpdateStockPrice(string symbol, decimal newPrice)
    {
        Console.WriteLine($"Stock price update for {symbol}: ${newPrice}");
        StockPriceChanged?.Invoke(this, new StockPriceChangedEventArgs(symbol, newPrice));
    }
}

class StockPriceChangedEventArgs : EventArgs
{
    public string Symbol { get; }
    public decimal NewPrice { get; }

    public StockPriceChangedEventArgs(string symbol, decimal newPrice)
    {
        Symbol = symbol;
        NewPrice = newPrice;
    }
}

class Trader
{
    public string Name { get; }

    public Trader(string name)
    {
        Name = name;
    }

    public void OnStockPriceChanged(object sender, StockPriceChangedEventArgs e)
    {
        Console.WriteLine($"{Name} received a stock price update for {e.Symbol}: ${e.NewPrice}");
    }
}

class StockAnalyst
{
    public string Name { get; }

    public StockAnalyst(string name)
    {
        Name = name;
    }

    public void OnStockPriceChanged(object sender, StockPriceChangedEventArgs e)
    {
        if (e.NewPrice > 105)
        {
            Console.WriteLine($"{Name}, the stock analyst, is interested in {e.Symbol}'s price: ${e.NewPrice}");
        }
    }
}
