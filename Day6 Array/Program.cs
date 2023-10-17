using System;

class ArrayExample
{
    public int[] MyArray { get; private set; }
    public char[] MyChar { get; private set; }
    public string[] MyStrings { get; private set; }

    public ArrayExample()
    {
        MyArray = new int[] { 1, 2, 4 };
        MyChar = new char[4];
        MyStrings = new string[] { "1", "2", "3" };
    }

    public int GetArrayElement(int index)
    {
        if (index >= 0 && index < MyArray.Length)
        {
            return MyArray[index];
        }
        return -1; // Or throw an exception, return a default value, or handle it differently.
    }

    public void SetArrayElement(int index, int value)
    {
        if (index >= 0 && index < MyArray.Length)
        {
            MyArray[index] = value;
        }
        // You can choose to handle out-of-range indices differently, e.g., throw an exception.
    }

    public int GetArrayLength()
    {
        return MyArray.Length;
    }
}

class Program
{
    static void Main()
    {
        ArrayExample example = new ArrayExample();
        
        int result = example.GetArrayElement(2);
        example.SetArrayElement(2, 6);
        int length = example.GetArrayLength();
        
        Console.WriteLine("Array Element: " + result);
        Console.WriteLine("Updated Array: " + string.Join(", ", example.MyArray));
        Console.WriteLine("Array Length: " + length);
    }
}
