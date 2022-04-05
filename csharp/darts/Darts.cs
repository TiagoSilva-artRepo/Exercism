using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        if (Math.Abs(x) > 10 || Math.Abs(y) > 10)
        {
            return 0;
        }
        else if (Math.Abs(x) > 5 || Math.Abs(y) > 5)
        {
            return 1;
        }
        else if (Math.Abs(x) > 1 || Math.Abs(y) > 1)
        {
            return 5;
        }
        else
        {
            return 10;
        }
    }
}
