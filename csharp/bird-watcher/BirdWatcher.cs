using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] {0, 2, 5, 3, 7, 8, 4};
    }

    public int Today()
    {
        return this.birdsPerDay[this.birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        this.birdsPerDay[this.birdsPerDay.Length - 1]++; 
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int birdCount in birdsPerDay)
        {
            if (birdCount == 0) return true;            
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int numberOfBirds = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            numberOfBirds += this.birdsPerDay[i];             
        }
        return numberOfBirds;
    }

    public int BusyDays()
    {
        int numberOfBusyDays = 0;
        foreach (int birdCount in birdsPerDay)
        {
            if (birdCount >= 5) numberOfBusyDays++;            
        }
        return numberOfBusyDays;
    }
}
