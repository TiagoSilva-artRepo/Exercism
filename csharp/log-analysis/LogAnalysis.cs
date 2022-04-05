using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimeter)
    {
        int startIndex = str.IndexOf(delimeter) + delimeter.Length;
        return str.Substring(startIndex); 
    } 

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string firstDelimeter, string secondDelimeter)
    {
        int startIndex = str.IndexOf(firstDelimeter) + firstDelimeter.Length;
        int endIndex = str.IndexOf(secondDelimeter) - startIndex;
        return str.Substring(startIndex, endIndex);
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        int startIndex = str.IndexOf(":") + 1;
        return str.Substring(startIndex).Trim(); 
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        int startIndex = str.IndexOf("[") + 1;
        int endIndex = str.IndexOf("]") - 1;
        return str.Substring(startIndex, endIndex);
    }
}