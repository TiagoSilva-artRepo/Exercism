using System;
using System.Collections.Generic;
using System.Linq;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int min = 0;
        int max = input.Length - 1;

        while (min <= max)
        {
            int mid = (min + max) / 2;
            if (value == input[mid])
            {
                return mid;
            }
            else if (value < input[mid])
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }
        return -1;
    }
}