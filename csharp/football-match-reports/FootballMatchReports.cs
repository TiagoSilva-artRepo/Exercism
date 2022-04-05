using System;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum) => shirtNum switch
    {
        1 => "goalie",
        2 => "left back",
        >= 3 and <= 4 =>  "center back",
        5 => "right back",
        >= 6 and <= 8 =>  "midfielder",
        9 => "left wing",
        10 => "striker",
        11 => "right wing",
        _ => throw new ArgumentOutOfRangeException("Invalid shirt number.")
    };


    public static string AnalyzeOffField(object report) => report switch
    {
        int numberOfSupporters => $"There are {numberOfSupporters} supporters at the match.",
        string announcement  => announcement,
        Injury injury  => $"Oh no! {injury.GetDescription()} Medics are on the field.",
        Foul foul  => $"The referee deemed a foul.",
        Incident incident => $"An incident happened.",
        Manager managerWithoutClub when managerWithoutClub.Club == null => managerWithoutClub.Name,
        Manager managerWithClub => $"{managerWithClub.Name} ({managerWithClub.Club})",
        _ => throw new ArgumentException("Unknown type of data")
    };
}
