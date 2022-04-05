using System;

public static class Gigasecond
{
    private const double GIGASECOND = 1E9;
    public static DateTime Add(DateTime moment) => moment.AddSeconds(GIGASECOND);
}