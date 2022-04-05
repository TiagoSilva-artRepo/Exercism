using System;

class RemoteControlCar
{
    private int battery = 100;
    private int distanceDriven = 0;
    public const int driveMeters = 20;
    public const int drainBattery = -1;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {distanceDriven} meters";
    }

    public string BatteryDisplay()
    {
        return battery > 0 ? $"Battery at {battery}%" : "Battery empty";
    }

    public void Drive()
    {
        if (battery > 0)
        {
            distanceDriven += driveMeters;
            battery += drainBattery;
        }
    }
}
