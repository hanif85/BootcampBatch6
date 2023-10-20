using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Complex Calculator ===");

        // Wrapper classes for int, double, and Complex
        var intWrapper = new NumericWrapper<int>();
        var doubleWrapper = new NumericWrapper<double>();
        var complexWrapper = new ComplexWrapper();

        // Addition
        int additionResult = Calculate<int>(OperationType.Addition, intWrapper, 3, 4, 5);
        Console.WriteLine($"Addition Result: {additionResult}");

        // Multiplication
        double multiplicationResult = Calculate<double>(OperationType.Multiplication, doubleWrapper, 2.5, 4.0, 1.5);
        Console.WriteLine($"Multiplication Result: {multiplicationResult}");

        // Complex Number Addition
        Complex complex1 = new Complex(2.0, 3.0);
        Complex complex2 = new Complex(1.5, 2.5);
        Complex complexAdditionResult = Calculate<Complex>(OperationType.ComplexAddition, complexWrapper, complex1, complex2);
        Console.WriteLine($"Complex Addition Result: {complexAdditionResult}");

        // String Concatenation
        string combinedString = StringCombiner("Hello", "World", "from", "Complex", "Calculator!");
        Console.WriteLine($"Combined String: {combinedString}");
    }

    static T Calculate<T>(OperationType operationType, INumericOperation<T> numericWrapper, params T[] values)
    {
        T result = default(T);

        foreach (T value in values)
        {
            switch (operationType)
            {
                case OperationType.Addition:
                    result = numericWrapper.Add(result, value);
                    break;
                case OperationType.Multiplication:
                    result = numericWrapper.Multiply(result, value);
                    break;
                case OperationType.ComplexAddition:
                    result = numericWrapper.ComplexAdd(result, value);
                    break;
            }
        }

        return result;
    }

    static string StringCombiner(params string[] strings)
    {
        string result = string.Join(" ", strings);
        return result;
    }
}

public interface INumericOperation<T>
{
    T Add(T a, T b);
    T Multiply(T a, T b);
    T ComplexAdd(T a, T b);
}

class NumericWrapper<T> : INumericOperation<T>
{
    public T Add(T a, T b) => (dynamic)a + (dynamic)b;
    public T Multiply(T a, T b) => (dynamic)a * (dynamic)b;
    public T ComplexAdd(T a, T b) => (dynamic)a + (dynamic)b;
}

class ComplexWrapper : INumericOperation<Complex>
{
    public Complex Add(Complex a, Complex b) => Complex.Add(a, b);
    public Complex Multiply(Complex a, Complex b) => Complex.Multiply(a, b);
    public Complex ComplexAdd(Complex a, Complex b) => Complex.Add(a, b);
}

public enum OperationType
{
    Addition,
    Multiplication,
    ComplexAddition
}
