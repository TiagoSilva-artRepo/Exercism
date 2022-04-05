using System;
using System.Collections.Generic;
using System.Linq;

public struct Coord
{

    public ushort X { get; }
    public ushort Y { get; }
    public ushort LongestSide { get; }

    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
        LongestSide = x >= y ? x : y;
    }
}

public struct Plot
{
    public Coord Coord1 { get; }
    public Coord Coord2 { get; }
    public Coord Coord3 { get; }
    public Coord Coord4 { get; }

    public Plot (Coord coord1, Coord coord2, Coord coord3, Coord coord4)
    {
        Coord1 = coord1;        
        Coord2 = coord2;        
        Coord3 = coord3;        
        Coord4 = coord4;
    }
    public Coord LongestSideCoord()
    {
        IList<Coord> CoordSides = new List<Coord>() { Coord1, Coord2, Coord3,Coord4 };
        CoordSides.OrderBy(coord => coord.LongestSide);
        return CoordSides.First();      
    }

}


public class ClaimsHandler
{
    private IList<Plot> claims = new List<Plot>(); 
    public void StakeClaim(Plot plot) => claims.Add(plot);

    public bool IsClaimStaked(Plot plot) => claims.Contains(plot);

    public bool IsLastClaim(Plot plot) => plot.Equals(claims.Last());

    public Plot GetClaimWithLongestSide()
    {
        int longestSide = 0;
        foreach (var claim in claims)
        {
            if (claim.LongestSideCoord().LongestSide > longestSide)
            {
                longestSide = claim.LongestSideCoord().LongestSide;
            }           
        }
        return claims.Where(claim => claim.LongestSideCoord().LongestSide == longestSide).First();
    }
}
