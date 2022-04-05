using System;

public static class ResistorColor
{
    public static int ColorCode(string color) => Enum.TryParse(typeof(Resistors), color, true, out object result) ? (int)result : throw new ArgumentException();

    public static string[] Colors() => Enum.GetNames(typeof(Resistors));
}

public enum Resistors
{
    black,
    brown,
    red,
    orange,
    yellow,
    green,
    blue,
    violet,
    grey,
    white,        
}