using System;
using System.Globalization;
using System.Runtime.InteropServices;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        var timeZoneInfo = GetTimeZoneInfo(location);
        return DateTime.TryParse(appointmentDateDescription, out DateTime appointmentDate) ? 
                TimeZoneInfo.ConvertTimeToUtc(appointmentDate, timeZoneInfo) :
                throw new FormatException();
    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel) => alertLevel switch
    {
        AlertLevel.Early => appointment.AddDays(-1),
        AlertLevel.Standard => appointment.AddHours(-1).AddMinutes(-45),
        AlertLevel.Late => appointment.AddMinutes(-30) ,
        _ => throw new ArgumentException()
    };

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        var timeZoneInfo = GetTimeZoneInfo(location);
        var startDate = dt.AddDays(-7);
        return timeZoneInfo.IsDaylightSavingTime(startDate) != timeZoneInfo.IsDaylightSavingTime(dt);
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        CultureInfo cultureInfo = GetCultureInfo(location);
        try
        {
            return Convert.ToDateTime(dtStr, cultureInfo);            
        }
        catch (FormatException)
        {
            return new DateTime(1,1,1);
        }             
    }

    private static TimeZoneInfo GetTimeZoneInfo (Location location)
    {
        bool isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        string timeZoneId = location switch
        {
            Location.London => isWindows ? "GMT Standard Time" : "Europe/London",
            Location.NewYork => isWindows ? "Eastern Standard Time" : "America/New_York",
            Location.Paris => isWindows ? "W. Europe Standard Time" : "Europe/Paris",
            _ => throw new ArgumentException()
        };
        return TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
    }

    private static CultureInfo GetCultureInfo (Location location) => location switch
    {
        Location.London => new CultureInfo("en-GB"),
        Location.NewYork => new CultureInfo("en-US"),
        Location.Paris =>  new CultureInfo("fr-FR"),
        _ => throw new ArgumentException()
    };
}
