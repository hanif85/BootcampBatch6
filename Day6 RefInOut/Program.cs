using System;

class Program
{
    static void Main()
    {
        NumberOperations operations = new NumberOperations();

        // Ref
        int myIntRef = 2;
        operations.MultiplyByTwoRef(ref myIntRef);
        Console.WriteLine(myIntRef); // 4

        // Out
        operations.MultiplyByTwoOut(out int myIntOut);
        Console.WriteLine(myIntOut);

        // In
        int myIntIn = 4;
        operations.MultiplyByTwoIn(in myIntIn);
    }
}

class NumberOperations
{
    // Ref = pass reference, must be assigned before the method call
    public void MultiplyByTwoRef(ref int input)
    {
        input = 4;
        input *= 2;
    }

    // Out = pass reference, must be assigned within the method before method exit
    public void MultiplyByTwoOut(out int input)
    {
        input = 4; // Assignment
        input = input * 2;
    }

    // In = pass reference, must be assigned, but it's read-only
    public void MultiplyByTwoIn(in int input)
    {
        // input = 4; // Cannot assign to a readonly parameter
        int result = input * 4;
    }
}
