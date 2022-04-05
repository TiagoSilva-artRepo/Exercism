using System;
using System.Collections.Generic;
using System.Linq;

public static class Raindrops
{
    private static Dictionary<int, string> factors = new Dictionary<int, string>() { {3, "Pling"}, {5, "Plang"}, {7, "Plong"} };

    public static string Convert(int number) => string.Join(String.Empty, factors.Where(x => IsFactor(number, x.Key)).Select(x => x.Value).DefaultIfEmpty(number.ToString()));

    private static bool IsFactor(int dividend, int divisor)
    {
        return dividend % divisor == 0;
    }
}