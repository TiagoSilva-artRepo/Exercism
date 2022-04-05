using System;
using System.Linq;

public static class Grains
{
    public static ulong Square(int n) => n < 1 || n > 64 ? throw new ArgumentOutOfRangeException("Invalid chess square number.") : (ulong)Math.Pow(2, n-1);

    public static ulong Total()
    {
        return Enumerable.Range(1,64).Aggregate(0UL, (a, c) => a + Square(c));
    }
}