using System;

class Program
{
    static void Main()
    {
        Publisher pub = new Publisher();

        Subscriber sub1 = new Subscriber();
        Subscriber2 sub2 = new Subscriber2();
        Subscriber3 sub3 = new Subscriber3();

        // Subscribe the three subscribers to the publisher
        pub.AddSubscriber(sub1.Notification);
        pub.AddSubscriber(sub2.Notification);
        pub.AddSubscriber(sub3.Notification);

        // Publisher uploads a video and notifies subscribers
        pub.UploadVideo();

        // Unsubscribe the first subscriber
        pub.RemoveSubscriber(sub1.Notification);

        // Publisher uploads another video and notifies the remaining subscribers
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
        NotifyMySubscriber("Check my video");
    }

    public void NotifyMySubscriber(string message)
    {
        subscriber?.Invoke(message);
    }

    public void AddSubscriber(Notify sub)
    {
        subscriber += sub;
    }

    public void RemoveSubscriber(Notify sub)
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
