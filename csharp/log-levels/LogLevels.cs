using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int messageStartIndex = logLine.IndexOf(":") + 1;
        return logLine.Substring(messageStartIndex).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int levelStartIndex = logLine.IndexOf("[") + 1;
        int levelEndIndex = logLine.IndexOf("]") - 1;
        return logLine.Substring(levelStartIndex, levelEndIndex).ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
