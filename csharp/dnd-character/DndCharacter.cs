using System;
using System.Linq;

public class DndCharacter
{
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }
    public int Hitpoints { get; set; }

    public static int Modifier(int score) => (int)Math.Floor((score - 10d) / 2d);

    public static int Ability() 
    {
        Random random = new Random();
        var diceThrows =  Enumerable.Range(1,4).Select(x => random.Next(1, 7)).ToList();
        diceThrows.Sort((a, b) => b.CompareTo(a));
        return diceThrows.Take(3).Sum();
    }

    public static DndCharacter Generate()
    {
        DndCharacter dndCharacter = new DndCharacter();
        dndCharacter.Strength = Ability();
        dndCharacter.Dexterity = Ability();
        dndCharacter.Constitution = Ability();
        dndCharacter.Intelligence = Ability();
        dndCharacter.Wisdom = Ability();
        dndCharacter.Charisma = Ability();
        dndCharacter.Hitpoints = 10 + Modifier(dndCharacter.Constitution);
        return dndCharacter;
    }
}
