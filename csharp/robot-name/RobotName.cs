using System;
using System.Collections.Generic;

public class Robot
{
    private static readonly List<Char> alphabet = new List<char>{'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
    private static HashSet<string> robotNames = new HashSet<string>();
    private static Random random = new Random();
    private string _name;
    public string Name
    {
        get => _name ??= GenerateName();
        private set => _name = value;
    }

    public Robot()
    {
    }

    private string GenerateName()
    {
        string name = $"{alphabet[random.Next(26)]}{alphabet[random.Next(26)]}{random.Next(0, 10)}{random.Next(0, 10)}{random.Next(0, 10)}";
        if(!robotNames.Add(name)) return GenerateName();
        return name;
    }

    public void Reset()
    {
        robotNames.Remove(Name);
        Name = GenerateName();
    }
}  