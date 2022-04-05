using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    public List<int> scoreList { get; }
    public HighScores(List<int> list) => scoreList = list;

    public List<int> Scores() => scoreList;

    public int Latest() => scoreList.Last();

    public int PersonalBest() => scoreList.Max();

    public List<int> PersonalTopThree() => scoreList.OrderByDescending(score => score).Take(3).ToList();
}