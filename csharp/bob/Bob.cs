using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        bool stringcontainsLetters = statement.Any(c => char.IsLetter(c));
        bool allCaps = String.Equals(statement, statement.ToUpper()) && stringcontainsLetters;
        bool question = statement.EndsWith("?");
        bool emptyStatement = String.IsNullOrWhiteSpace(statement);

        if(question && !allCaps) return "Sure.";

        if (!question && allCaps) return "Whoa, chill out!";

        if (question && allCaps) return "Calm down, I know what I'm doing!";

        if(emptyStatement) return "Fine. Be that way!";

        return "Whatever.";
    }
}