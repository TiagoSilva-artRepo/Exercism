using System;

class RemoteControlCar
{
    private int carSpeed;
    private int batteryDrain;
    private int distanceDriven = 0;
    private int battery = 100;
    private const int nitroCarSpeed = 50;
    private const int nitroCarBatteryDrain = 4;
    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int carSpeed, int batteryDrain)
    {
        this.carSpeed = carSpeed;
        this.batteryDrain = batteryDrain;        
    }

    public bool BatteryDrained()
    {
        return (battery - batteryDrain) < 0;
    }

    public int DistanceDriven()
    {
        return this.distanceDriven;
    }

    public void Drive()
    {
        if (battery <= 0) return;
        
        if (battery - batteryDrain >= 0)
        {
            this.distanceDriven += this.carSpeed;
            this.battery -= batteryDrain;
        }
        else
        {
            this.battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(nitroCarSpeed, nitroCarBatteryDrain);
    }
}

class RaceTrack
{
    private int trackDistance;
    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int trackDistance)
    {
        this.trackDistance = trackDistance;
    }

    public bool CarCanFinish(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();             
        }

        return car.DistanceDriven() >= this.trackDistance;
    }
}
