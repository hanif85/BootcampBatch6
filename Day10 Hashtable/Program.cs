using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add(3, 3.3f);
        hashtable.Add("5", "foo");
        hashtable.Add(true, false);

        // Access values by key
        float value1 = (float)hashtable[3];
        string value2 = (string)hashtable["5"];
        bool value3 = (bool)hashtable[true];

        Console.WriteLine($"Value for key 3: {value1}");
        Console.WriteLine($"Value for key '5': {value2}");
        Console.WriteLine($"Value for key 'true': {value3}");
    }
}
