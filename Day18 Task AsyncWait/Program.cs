using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        int result = await AddAsync(3, 4);
        Console.WriteLine($"Result: {result}");
    }

    static async Task<int> AddAsync(int a, int b)
    {
        // Simulate an asynchronous operation
        await Task.Delay(1000);

        return a + b;
    }
}
