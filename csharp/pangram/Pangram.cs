using System;
using System.Linq;
using System.Collections.Generic;

public static class Pangram
{
    private const int ALPHABETLETTERSCOUNT = 26;
    public static bool IsPangram(string input) => ALPHABETLETTERSCOUNT == input.ToUpperInvariant().ToCharArray().Where(x => Char.IsLetter(x)).ToHashSet().Count;
}
