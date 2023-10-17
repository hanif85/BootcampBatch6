using System;

class Program
{
    static void Main()
    {
        string myString = "Hello";
        StringAppender(ref myString);
        Console.WriteLine(myString);
    }

    static void StringAppender(ref string input)
    {
        input += "!!!!";
    }
}
