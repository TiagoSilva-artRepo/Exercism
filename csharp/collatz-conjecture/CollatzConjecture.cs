using System;
using System.Collections.Generic;
using System.Linq;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number < 1) throw new ArgumentOutOfRangeException("Invalid number.");
        if (number == 1) return 0;

        List<int> numbers = new(); 
        do
        {
            if (number % 2 == 0) 
            {
                number /= 2;
            }
            else
            {
                number = number * 3 + 1;
            }
            numbers.Add(number);
        } while (number > 1);
        return numbers.Count();
    }
}