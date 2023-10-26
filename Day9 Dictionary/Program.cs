using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> myDict = new Dictionary<int, string>();
        myDict.Add(3, "foo");
        myDict.Add(5, "bar");

        // Uncommenting the next line would result in a runtime error because keys must be unique.
        // myDict.Add(3, "fizz");

        myDict.Add(7, "foo"); // Values can be duplicate

        foreach (KeyValuePair<int, string> entry in myDict)
        {
            Console.WriteLine($"{entry.Key} {entry.Value}");
        }

        string myValue = myDict[3];
        Console.WriteLine($"Value for key 3: {myValue}");

        string valueForSearch = "foo";
        int keyResult = 0;

        foreach (var entry in myDict)
        {
            if (entry.Value == valueForSearch)
            {
                keyResult = entry.Key;
                break;
            }
        }
        Console.WriteLine($"Key for value 'foo': {keyResult}");

        KeyValuePair<int, string> keyValue = new KeyValuePair<int, string>(3, "foo");
        bool containsKey = myDict.Contains(keyValue);
        Console.WriteLine($"Dictionary contains the key-value pair {keyValue}: {containsKey}");

        myDict[3] = "buzz"; // Change the value for an existing key

        int keyToAdd = 1;
        string valueToAdd = "yanto";
        myDict[keyToAdd] = valueToAdd; // Add or update a key-value pair

        foreach (KeyValuePair<int, string> entry in myDict)
        {
            Console.WriteLine($"{entry.Key} {entry.Value}");
        }
    }
}
