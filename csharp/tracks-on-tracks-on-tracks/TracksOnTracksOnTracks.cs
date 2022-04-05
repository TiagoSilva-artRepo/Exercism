using System;
using System.Collections.Generic;
using System.Linq;

public static class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> GetExistingLanguages()
    {
        return new List<string>() {"C#", "Clojure", "Elm"};
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        int indexOfCSharp = languages.IndexOf("C#");
        int listLength = languages.Count;

        return ((indexOfCSharp == 0) || (indexOfCSharp == 1 && (listLength == 2 || listLength == 3)));
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        foreach (var language in languages)
        {
            int firstOccurence = languages.IndexOf(language);
            int lastOccurence = languages.LastIndexOf(language);
            if(firstOccurence != lastOccurence) return false;
        }
        return true;
    }
}
