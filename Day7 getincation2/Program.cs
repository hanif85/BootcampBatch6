using System;
using System.Collections.Generic;

public delegate string MyDelegate();

public class DelegateDemo
{
    public MyDelegate Message { get; set; }
    public MyDelegate PrintOut { get; set; }

    public DelegateDemo()
    {
        Message = () => "message";
        PrintOut = () => "printout";
    }

    public MyDelegate CombineDelegates()
    {
        MyDelegate result = () => Message() + " " + PrintOut();
        return result;
    }

    public void PrintDelegateList(List<MyDelegate> delegateList)
    {
        foreach (MyDelegate d in delegateList)
        {
            Console.WriteLine(d.Invoke());
        }
    }
}

public class Program
{
    static void Main()
    {
        DelegateDemo delegateDemo = new DelegateDemo();
        MyDelegate combinedDelegate = delegateDemo.CombineDelegates();

        List<MyDelegate> delegateList = new List<MyDelegate>
        {
            delegateDemo.Message,
            delegateDemo.PrintOut,
            combinedDelegate
        };

        delegateDemo.PrintDelegateList(delegateList);
    }
}
