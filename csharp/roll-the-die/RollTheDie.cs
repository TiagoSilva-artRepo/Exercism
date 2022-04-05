using System;

public class Player
{
    private const int numberOfSides = 18;
    private const double maxStrength = 100.00;
    public int RollDie()
    {
        Random dice = new Random();
        return dice.Next(numberOfSides) + 1;
    }

    public double GenerateSpellStrength()
    {
        Random dice = new Random();
        return dice.NextDouble() * maxStrength;
    }
}
