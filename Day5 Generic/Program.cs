using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        GenericCollection<int> collection = new GenericCollection<int>();
        collection.Add(3);
        collection.Add(4);
        collection.Add(5);
        int result = collection.MyCollection[0];
        Console.WriteLine(result);

        GenericCollection<bool> collectionOfBool = new GenericCollection<bool>();
        collectionOfBool.Add(true);
        collectionOfBool.Add(false);
        bool resultOfBool = collectionOfBool.MyCollection[0];
        Console.WriteLine(resultOfBool);
    }
}

class GenericCollection<T>
{
    private List<T> myCollection = new List<T>();

    public List<T> MyCollection => myCollection;

    public void Add(T input)
    {
        myCollection.Add(input);
    }
}
