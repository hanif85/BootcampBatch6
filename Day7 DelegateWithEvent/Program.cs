using System;
using System.Collections.Generic;

public delegate void SportsEventNotification(string eventName, string description);

class Program
{
    static void Main()
    {
        SportsEventCenter eventCenter = new SportsEventCenter();

        SportsFan fan1 = new SportsFan("Alice");
        SportsFan fan2 = new SportsFan("Bob");
        SportsAnalyst analyst = new SportsAnalyst("John");

        eventCenter.SportsEventPublished += fan1.OnSportsEvent;
        eventCenter.SportsEventPublished += fan2.OnSportsEvent;
        eventCenter.SportsEventPublished += analyst.OnSportsEvent;

        eventCenter.PublishSportsEvent("Soccer Match", "Goal by Team A!");
        eventCenter.PublishSportsEvent("Basketball Game", "Three-pointer by Player B!");
    }
}

class SportsEventCenter
{
    public event SportsEventNotification SportsEventPublished;

    public void PublishSportsEvent(string eventName, string description)
    {
        Console.WriteLine($"Publishing event: {eventName} - {description}");
        SportsEventPublished?.Invoke(eventName, description);
    }
}

class SportsFan
{
    public string Name { get; }
    public SportsFan(string name)
    {
        Name = name;
    }

    public void OnSportsEvent(string eventName, string description)
    {
        Console.WriteLine($"{Name} received an update about the {eventName}: {description}");
    }
}

class SportsAnalyst
{
    public string Name { get; }
    public SportsAnalyst(string name)
    {
        Name = name;
    }

    public void OnSportsEvent(string eventName, string description)
    {
        Console.WriteLine($"{Name} analyzed the {eventName}: {description}");
    }
}
