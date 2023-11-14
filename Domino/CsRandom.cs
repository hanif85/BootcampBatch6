namespace Domino;

using System;

public class CsRandom
{
	private Random random;

	public CsRandom()
	{
		random = new Random();
	}

	public int GetRandomPublic(int rangeLow, int rangeHigh)
	{
		int myRandScaled = GetRandomPrivate(rangeLow, rangeHigh);
		return myRandScaled;
	}

	private int GetRandomPrivate(int rangeLow, int rangeHigh)
	{
		double myRand = random.NextDouble();
		int range = rangeHigh - rangeLow + 1;
		int myRandScaled = (int)(myRand * range) + rangeLow;
		return myRandScaled;
	}

	protected int GetRandomProtected(int rangeLow, int rangeHigh)
	{
		double myRand = random.NextDouble();
		int range = rangeHigh - rangeLow + 1;
		int myRandScaled = (int)(myRand * range) + rangeLow;
		return myRandScaled;
	}
}

    // class Program
    // {
    //     static void Main()
    //     {
    //         // Create an instance of CsRandom
    //         CsRandom randomGenerator = new CsRandom();

    //         // Use the public method to get a random number within a range
    //         int randomPublic = randomGenerator.GetRandomPublic(1, 10);
    //         Console.WriteLine($"Random Number (Public): {randomPublic}");

    //         // You cannot access the private method from outside the class
    //         // Uncommenting the line below will result in a compilation error
    //         // int randomPrivate = randomGenerator.GetRandomPrivate(1, 10);

    //         // You cannot access the protected method from outside the class
    //         // Uncommenting the line below will result in a compilation error
    //         // int randomProtected = randomGenerator.GetRandomProtected(1, 10);
    //     }
    // }