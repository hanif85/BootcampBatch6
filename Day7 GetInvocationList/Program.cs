using System;
using System.Collections.Generic;
using System.Linq;

public delegate string MyDelegate();

class Program
{
    static void Main()
    {
        MyDelegate mydel = Message;
        mydel += PrintOut;

        List<string> result = new List<string>();
        Delegate[] delegateList = mydel.GetInvocationList();

        foreach (MyDelegate d in delegateList)
        {
            result.Add(d.Invoke());
        }

        string combinedResult = result.Aggregate((current, next) => current + " " + next);
        Console.WriteLine(combinedResult);
    }

    static string Message()
    {
        return "message";
    }

    static string PrintOut()
    {
        return "printout";
    }
}
