using System;

class Program
{
    static void Main()
    {
        Publisher pub = new Publisher();

        Subscriber sub1 = new Subscriber();
        Subscriber2 sub2 = new Subscriber2();
        Subscriber3 sub3 = new Subscriber3();

        pub.Subscribe(sub1.Notification);
        pub.Subscribe(sub2.Notification);
        pub.Subscribe(sub3.Notification);

        pub.UploadVideo();

        pub.Unsubscribe(sub1.Notification);

        pub.UploadVideo();
    }
}

class Publisher
{
    public delegate void Notify(string message);
    private Notify subscriber;

    public void UploadVideo()
    {
        Console.WriteLine("Uploading Video...");
        Console.WriteLine("Finished");
        NotifySubscribers("Check my video");
    }

    public void NotifySubscribers(string message)
    {
        subscriber?.Invoke(message);
    }

    public void Subscribe(Notify sub)
    {
        subscriber += sub;
    }

    public void Unsubscribe(Notify sub)
    {
        subscriber -= sub;
    }
}

class Subscriber
{
    public void Notification(string message)
    {
        Console.WriteLine($"Subscriber 1 got notification: {message}");
    }
}

class Subscriber2
{
    public void Notification(string message)
    {
        Console.WriteLine($"Subscriber 2 got notification: {message}");
    }
}

class Subscriber3
{
    public void Notification(string message)
    {
        Console.WriteLine($"Subscriber 3 got notification: {message}");
    }
}
