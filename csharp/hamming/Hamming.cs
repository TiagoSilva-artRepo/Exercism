using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand) => 
        firstStrand.Length == secondStrand.Length
        ? firstStrand.Where((letter, index) => letter != secondStrand[index]).Count()
        : throw new ArgumentException("Strands must have same size.");
}