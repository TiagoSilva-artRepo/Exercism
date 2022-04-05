using System;
using System.Collections.Generic;
using System.Linq;

[Flags]
public enum Allergen : byte
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    public int Mask { get; private set; }
    public Allergies(int mask)
    {
        Mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen) => (Mask & (byte)allergen) > 0;

    public Allergen[] List() => Enum.GetValues(typeof(Allergen)).Cast<Allergen>().Where(allergy => IsAllergicTo(allergy)).ToArray();
}