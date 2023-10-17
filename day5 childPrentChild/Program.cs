using System;

class Program
{
    static void Main()
    {
        Child c = new Child();
        int result = c.x;
        Console.WriteLine(result);
    }
}

class Parent { }

class Child : Parent
{
    public int x = 3;
}
