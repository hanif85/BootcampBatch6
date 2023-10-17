using System;

class Program
{
    static void Main()
    {
        ObjectCollection collection = new ObjectCollection();
        collection.Add(1);
        collection.Add(true);
        collection.Add(1.0f);
        collection.Add(null);
        collection.Add("yusuf");
        collection.Add(1000000M);

        for (int i = 0; i < collection.Counter; i++)
        {
            if (collection.MyCollection[i] is int intValue)
            {
                int result = intValue;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Element at index " + i + " is not an integer.");
            }
        }
    }
}

class ObjectCollection
{
    private object[] myCollection = new object[100];
    private int counter = 0;

    public object[] MyCollection => myCollection;
    public int Counter => counter;

    public bool Add(object input)
    {
        if (counter < myCollection.Length)
        {
            myCollection[counter] = input;
            counter++;
            return true;
        }
        return false;
    }
}
