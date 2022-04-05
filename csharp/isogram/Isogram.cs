using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var chars = word.ToLowerInvariant().ToCharArray().Where(x => Char.IsLetter(x));
        return chars.Distinct().Count() == chars.Count();
    }
}
