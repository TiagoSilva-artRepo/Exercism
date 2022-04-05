using System;
using System.Text.RegularExpressions;

public class LogParser
{
    public bool IsValidLine(string text) => new Regex(@"^\D{5}").Match(text).Value switch
    {
        "[TRC]" or "[DBG]" or "[INF]" or "[WRN]" or "[ERR]" or "[FTL]" => true,
        _ => false
    };

    public string[] SplitLogLine(string text) => Regex.Split(text, @"<\D*>");

    public int CountQuotedPasswords(string lines) => new Regex("\"+.*password.*(?=\")", RegexOptions.IgnoreCase).Matches(lines).Count;
    public string RemoveEndOfLineText(string line) => Regex.Replace(line, @"end-of-line\w+", "");

    public string[] ListLinesWithPasswords(string[] lines)
    {
        string [] result = new string[lines.Length];
        Regex regex = new Regex(@"password\w+", RegexOptions.IgnoreCase);
        for (int i = 0; i < lines.Length; i++)
        {
            result[i] = regex.IsMatch(lines[i]) ? $"{regex.Match(lines[i]).Value}: {lines[i]}" : $"--------: {lines[i]}";            
        }
        return result;
    }
}
