using System;

class StandardCodeExample
{
    public void Run()
    {
        // Integer arithmetic
        int a = 1;
        int b = 2;
        int c = 3;
        bool intComparisonResult = (a + b == c);
        Console.WriteLine(intComparisonResult); // True

        // Floating-point arithmetic using float
        float fa = 1.0f;
        float fb = 2.0f;
        float fc = 3.0f;
        float fresult = fa + fb;
        bool floatComparisonResult = (fresult == fc);
        Console.WriteLine(floatComparisonResult); // True

        // Floating-point arithmetic using double
        double da = 0.1;
        double db = 0.2;
        double result = a + b;
        bool doubleComparisonResult = (Math.Abs(result - 0.3) < double.Epsilon);
        Console.WriteLine(doubleComparisonResult); // False
        Console.WriteLine(result);

        // Decimal arithmetic
        decimal DA = 1.0M;
        decimal DB = 2.0M;
        decimal DC = 3.0M;
        bool decimalComparisonResult = (DA + DB == DC);
        Console.WriteLine(decimalComparisonResult); // True
    }
}

class Program
{
    static void Main()
    {
        StandardCodeExample example = new StandardCodeExample();
        example.Run();
    }
}
