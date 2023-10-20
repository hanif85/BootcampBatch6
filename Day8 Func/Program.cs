using System;

class Program
{
    static void Main()
    {
        Func<int, int, int> func = Add;
        Func<string, int, bool, string> func2 = Message;
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static string Message(string a, int b, bool c)
    {
        return "test";
    }
}
