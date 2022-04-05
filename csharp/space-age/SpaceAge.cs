using System;

public class SpaceAge
{
    private const double EARTH_ORBITALPERIOD_SECONDS = 31557600;
    private const double MERCURY_ORBITALPERIOD_YEARS = 0.2408467;
    private const double VENUS_ORBITALPERIOD_YEARS = 0.61519726;
    private const double MARS_ORBITALPERIOD_YEARS = 1.8808158;
    private const double JUPITER_ORBITALPERIOD_YEARS = 11.862615;
    private const double SATURN_ORBITALPERIOD_YEARS = 29.447498;
    private const double URANUS_ORBITALPERIOD_YEARS = 84.016846;
    private const double NEPTUNE_ORBITALPERIOD_YEARS = 164.79132;
    public int AgeInSeconds { get;}

    public SpaceAge(int seconds)
    {
        AgeInSeconds = seconds;
    }

    public double OnEarth() => AgeInSeconds / EARTH_ORBITALPERIOD_SECONDS;

    public double OnMercury() => AgeInSeconds / (EARTH_ORBITALPERIOD_SECONDS * MERCURY_ORBITALPERIOD_YEARS);

    public double OnVenus() => AgeInSeconds / (EARTH_ORBITALPERIOD_SECONDS * VENUS_ORBITALPERIOD_YEARS);

    public double OnMars() => AgeInSeconds / (EARTH_ORBITALPERIOD_SECONDS * MARS_ORBITALPERIOD_YEARS);

    public double OnJupiter() => AgeInSeconds / (EARTH_ORBITALPERIOD_SECONDS * JUPITER_ORBITALPERIOD_YEARS);

    public double OnSaturn() => AgeInSeconds / (EARTH_ORBITALPERIOD_SECONDS * SATURN_ORBITALPERIOD_YEARS);

    public double OnUranus() => AgeInSeconds / (EARTH_ORBITALPERIOD_SECONDS * URANUS_ORBITALPERIOD_YEARS);

    public double OnNeptune() => AgeInSeconds / (EARTH_ORBITALPERIOD_SECONDS * NEPTUNE_ORBITALPERIOD_YEARS);
}