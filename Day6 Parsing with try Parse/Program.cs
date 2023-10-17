using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (n): ");
        int nData;
        if (int.TryParse(Console.ReadLine(), out nData))
        {
            for (int i = 0; i < nData; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.Write("foobar");
                else if (i % 3 == 0)
                    Console.Write("foo");
                else if (i % 5 == 0)
                    Console.Write("bar");
                else
                    Console.Write(i);

                if (i < nData)
                    Console.Write(", ");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}