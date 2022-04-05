using System;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        char[] wordLetters = input.Trim().ToUpperInvariant().ToCharArray();

        char[] onePointLetters = new char[] {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'};
        char[] twoPointLetters = new char[] {'D', 'G'};
        char[] threePointLetters = new char[] {'B', 'C', 'M', 'P'};
        char[] fourPointLetters = new char[] {'F', 'H', 'V', 'W', 'Y'};
        char[] fivePointLetters = new char[] {'K'};
        char[] eightPointLetters = new char[] {'J', 'X'};
        char[] tenPointLetters = new char[] {'Q', 'Z'};

        int points = 0;

        foreach (var letter in wordLetters)
        {
            if (isInArray(letter, onePointLetters)) { points += 1; continue; }                        
            if (isInArray(letter, twoPointLetters)) { points += 2; continue; }                     
            if (isInArray(letter, threePointLetters)) { points += 3; continue; }                        
            if (isInArray(letter, fourPointLetters)) { points += 4; continue; }                        
            if (isInArray(letter, fivePointLetters)) { points += 5; continue; }                        
            if (isInArray(letter, eightPointLetters)) { points += 8; continue; }                       
            if (isInArray(letter, tenPointLetters)) { points += 10; continue; }                        
        }

        return points;
    }

    private static bool isInArray(char letter, char[] letters)
    {
        if (Array.IndexOf(letters, letter) > -1) return true;
        return false;  
    }
}