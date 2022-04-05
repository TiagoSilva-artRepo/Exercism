using System;
using System.Linq;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        IDictionary<char, int> nucleotides = new Dictionary<char, int>(){ {'A', 0}, {'C', 0}, {'G', 0}, {'T', 0} };
        
        foreach (var nucleotide in sequence)
        {
            if (!nucleotides.ContainsKey(nucleotide)) throw new ArgumentException("Invalid nucleotide"); 
            nucleotides[nucleotide] += 1;                  
        }
        return nucleotides;
    }
}