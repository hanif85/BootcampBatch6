using System;

class Program
{
    static void Main()
    {
        // Create three subscriber instances
        Subscriber sub1 = new Subscriber();
        Subscriber sub2 = new Subscriber();
        Subscriber sub3 = new Subscriber();

        // Create a publisher instance
        Publisher pub = new Publisher();
        
        // Notify subscribers about a video upload
        pub.NotifyMySubscriber(sub1, "Check my video");
        pub.NotifyMySubscriber(sub2, "Check my video");
        pub.NotifyMySubscriber(sub3, "Check my video");
        
        // Notify subscribers about a donation request
        pub.NotifyMySubscriber(sub1, "Donate");
        pub.NotifyMySubscriber(sub2, "Donate");
        pub.NotifyMySubscriber(sub3, "Donate");
    }
}

class Publisher
{
    public void UploadVideo()
    {
        // Simulate uploading a video
        Console.WriteLine("Uploading Video...");
        Console.WriteLine("Finished");
    }

    public void NotifyMySubscriber(Subscriber sub, string message)
    {
        // Notify the subscriber by calling the Notification method
        sub.Notification(message);
    }
}

class Subscriber
{
    public void Notification(string message)
    {
        // Display a notification message for the subscriber
        Console.WriteLine($"Subscriber got notification: {message}");
    }
}
