using System;
using System.Text;
using System.Globalization;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (String.IsNullOrEmpty(identifier)) return String.Empty;

        char[] stringCharacters = identifier.ToCharArray();

        StringBuilder result = new StringBuilder();
        for (int index = 0; index < stringCharacters.Length; index++)
        {
            if (Char.IsControl(stringCharacters[index])) result.Append("CTRL");

            if (Char.IsWhiteSpace(stringCharacters[index])) result.Append("_");

            if (Char.GetUnicodeCategory(stringCharacters[index]) == UnicodeCategory.DashPunctuation)
            {
                result.Append(stringCharacters[index + 1].ToString().ToUpper());
                index++;
                continue;
            };

            if (!Char.IsLetter(stringCharacters[index]) || ( (int)stringCharacters[index] >=  'α' && (int)stringCharacters[index] <= 'ω') ) continue;
            
            result.Append(stringCharacters[index]);
        }

        return result.ToString();
    }
}
