using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a ChatApplication instance for managing message sending and receiving.
        ChatApplication chatApp = new ChatApplication();

        // Create two User instances: Alice and Bob.
        User user1 = new User("Alice");
        User user2 = new User("Bob");

        // Create UI and Database instances for message display and logging.
        UI ui = new UI();
        Database database = new Database();

        // Subscribe User instances, UI, and Database to the MessageReceived event of ChatApplication.
        chatApp.MessageReceived += user1.OnMessageReceived;
        chatApp.MessageReceived += user2.OnMessageReceived;
        chatApp.MessageReceived += ui.DisplayMessage;
        chatApp.MessageReceived += database.LogMessage;

        // Alice sends a message to Bob.
        chatApp.SendMessage("Alice", "Hi, Bob!");

        // Bob responds to Alice's message.
        chatApp.SendMessage("Bob", "Hello, Alice!");

        // Unsubscribe Alice from the event.
        chatApp.MessageReceived -= user1.OnMessageReceived;

        // Alice sends another message after being unsubscribed.
        chatApp.SendMessage("Alice", "I'm back!");
    }
}

class ChatApplication
{
    // Declare an Action to handle message reception, taking a sender and a message.
    public Action<string, string> MessageReceived;

    // Method to simulate sending a message.
    public void SendMessage(string sender, string message)
    {
        // Display that a message is being sent.
        Console.WriteLine($"{sender} sent a message: {message}");
        
        // Invoke the MessageReceived Action, broadcasting the message to subscribers.
        MessageReceived?.Invoke(sender, message);
    }
}

class User
{
    // User's name.
    public string Name { get; }

    // Constructor to initialize the user with a name.
    public User(string name)
    {
        Name = name;
    }

    // Event handler method for receiving and displaying messages.
    public void OnMessageReceived(string sender, string message)
    {
        Console.WriteLine($"{Name} received a message from {sender}: {message}");
    }
}

class UI
{
    // Method for displaying messages in the UI.
    public void DisplayMessage(string sender, string message)
    {
        Console.WriteLine($"UI: {sender} says, '{message}'");
    }
}

class Database
{
    // Method for logging messages to a database.
    public void LogMessage(string sender, string message)
    {
        Console.WriteLine($"Database: Logging message from {sender}: {message}");
    }
}
