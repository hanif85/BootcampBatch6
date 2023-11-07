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
