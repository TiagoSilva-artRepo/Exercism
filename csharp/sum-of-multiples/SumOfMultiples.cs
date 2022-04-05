using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max) => Enumerable.Range(0, max).Where(i => multiples.Any(m => m > 0 && i % m == 0)).Sum();
}