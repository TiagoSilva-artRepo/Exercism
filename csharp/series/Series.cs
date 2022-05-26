using System;
using System.Collections.Generic;
using System.Linq;


public static class Series
{
    public static string[] Slices(string numbers, int sliceLength) => sliceLength < 1 || sliceLength > numbers.Length
            ? throw new ArgumentException()
            : Enumerable.Range(0, numbers.Length - (sliceLength - 1)).Select(el => numbers.Substring(el, sliceLength)).ToArray();
}