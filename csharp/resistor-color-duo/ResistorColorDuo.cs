using System;
using System.Linq;
using System.Text;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 2; i++)
        {
            sb.Append((int)Enum.Parse(typeof(ResistorColors), colors[i]));             
        }   
        return int.Parse(sb.ToString());
    }
}

public enum ResistorColors
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
    white
}
