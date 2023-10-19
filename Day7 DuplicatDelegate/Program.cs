using System;
using System.Collections.Generic;
using System.Linq;

public delegate void Publish(string x);

class Program
{
    static void Main()
    {
        Publisher pub = new Publisher();
        Subscriber sub = new Subscriber();
        
        // Adding the subscriber twice to demonstrate duplicate delegate handling
        pub.AddSubscriber(sub.Notify);
        pub.AddSubscriber(sub.Notify); // duplicate delegate
        pub.SentNotification();
        
        pub.RemoveSubscriber(sub.Notify);
        pub.SentNotification();
    }
}

class Publisher
{
    private Publish _subscriber;

    public void SentNotification()
    {
        _subscriber?.Invoke("subs");
    }

    public bool AddSubscriber(Publish sub)
    {
        if (_subscriber is null || !_subscriber.GetInvocationList().Contains(sub))
        {
            _subscriber += sub;
            return true;
        }
        return false;
    }

    public void RemoveSubscriber(Publish sub)
    {
        _subscriber -= sub;
    }
}

class Subscriber
{
    public void Notify(string message)
    {
        Console.WriteLine(message);
    }
}
