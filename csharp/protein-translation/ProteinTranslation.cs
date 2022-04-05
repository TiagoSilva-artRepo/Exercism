using System;
using System.Linq;
using System.Collections.Generic;

public static class ProteinTranslation
{

    private static IDictionary<string, string> codons = new Dictionary<string, string>
    {
        {"AUG", "Methionine"},
        {"UUU", "Phenylalanine"},
        {"UUC", "Phenylalanine"},
        {"UUA", "Leucine"},
        {"UUG", "Leucine"},
        {"UCU", "Serine"},
        {"UCC", "Serine"},
        {"UCA", "Serine"},
        {"UCG", "Serine"},
        {"UAU", "Tyrosine"},
        {"UAC", "Tyrosine"},
        {"UGU", "Cysteine"},
        {"UGC", "Cysteine"},
        {"UGG", "Tryptophan"},
        {"UAA", "STOP"},
        {"UAG", "STOP"},
        {"UGA", "STOP"},
    };

    public static string[] Proteins(string strand) => Enumerable.Range(0, strand.Length / 3).Select(i => codons[strand.Substring(i * 3, 3)]).TakeWhile(codon => codon != "STOP").ToArray();

}