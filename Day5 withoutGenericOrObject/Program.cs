using System;

class Program
{
    static void Main()
    {
        IntCollection intCollection = new IntCollection();
        intCollection.Add(1);
        
        string stringValue = "Hello, World!";
        StringCollection stringCollection = new StringCollection();
        stringCollection.Add(stringValue);
        
        double doubleValue = 3.14;
        DoubleCollection doubleCollection = new DoubleCollection();
        doubleCollection.Add(doubleValue);
        
        int result = intCollection.MyCollection[0];
        string resultString = stringCollection.MyCollection[0];
        double resultDouble = doubleCollection.MyCollection[0];
        
        Console.WriteLine(result);
        Console.WriteLine(resultString);
        Console.WriteLine(resultDouble);
    }
}

class IntCollection
{
    public int[] MyCollection { get; } = new int[100];
    public int Counter { get; private set; } = 0;

    public bool Add(int input)
    {
        if (Counter < MyCollection.Length)
        {
            MyCollection[Counter] = input;
            Counter++;
            return true;
        }
        return false;
    }
}

class StringCollection
{
    public string[] MyCollection { get; } = new string[100];
    public int Counter { get; private set; } = 0;

    public bool Add(string input)
    {
        if (Counter < MyCollection.Length)
        {
            MyCollection[Counter] = input;
            Counter++;
            return true;
        }
        return false;
    }
}

class DoubleCollection
{
    public double[] MyCollection { get; } = new double[100];
    public int Counter { get; private set; } = 0;

    public bool Add(double input)
    {
        if (Counter < MyCollection.Length)
        {
            MyCollection[Counter] = input;
            Counter++;
            return true;
        }
        return false;
    }
}
