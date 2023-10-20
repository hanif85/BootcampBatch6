using System;

class Program
{
    static void Main()
    {
        string text = "This is a sample text.";

        // Extension method to count the number of words in a string.
        int wordCount = text.WordCount();
        Console.WriteLine($"Word count: {wordCount}");

        // Extension method to reverse the string.
        string reversedText = text.Reverse();
        Console.WriteLine($"Reversed text: {reversedText}");

        // Extension method to convert the string to title case.
        string titleCaseText = text.ToTitleCase();
        Console.WriteLine($"Title case text: {titleCaseText}");
    }
}

public static class StringExtensions
{
    // Extension method to count the number of words in a string.
    public static int WordCount(this string str)
    {
        string[] words = str.Split(new char[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    // Extension method to reverse a string.
    public static string Reverse(this string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Extension method to convert a string to title case.
    public static string ToTitleCase(this string str)
    {
        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
    }
}
