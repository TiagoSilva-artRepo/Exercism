public class RemoteControlCar
{
    public string CurrentSponsor { get; private set; }

    private Speed currentSpeed;

    public _Telemetry Telemetry { get; }

    public RemoteControlCar()
    {
        this.Telemetry = new _Telemetry(this);        
    }

    public string GetSpeed() => currentSpeed.ToString();

    private void SetSponsor(string sponsorName) => CurrentSponsor = sponsorName;

    private void SetSpeed(Speed speed) => currentSpeed = speed;

    public class _Telemetry
    {
        private RemoteControlCar remoteControlCar;

        public _Telemetry(RemoteControlCar remoteControlCar)
        {
            this.remoteControlCar = remoteControlCar;
        }

        public void Calibrate()
        {
        }

        public bool SelfTest()
        {
            return true;
        }

        public void ShowSponsor(string sponsorName)
        {
            remoteControlCar.SetSponsor(sponsorName);
        }

        public void SetSpeed(decimal amount, string unitsString)
        {
            SpeedUnits speedUnits = SpeedUnits.MetersPerSecond;
            if (unitsString == "cps")
            {
                speedUnits = SpeedUnits.CentimetersPerSecond;
            }

            remoteControlCar.SetSpeed(new Speed(amount, speedUnits));
        }
    }

    private enum SpeedUnits
    {
        MetersPerSecond,
        CentimetersPerSecond
    }

    private struct Speed
    {
        public decimal Amount { get; }
        public SpeedUnits SpeedUnits { get; }

        public Speed(decimal amount, SpeedUnits speedUnits)
        {
            Amount = amount;
            SpeedUnits = speedUnits;
        }

        public override string ToString()
        {
            string unitsString = "meters per second";
            if (SpeedUnits == SpeedUnits.CentimetersPerSecond)
            {
                unitsString = "centimeters per second";
            }

            return Amount + " " + unitsString;
        }
    }
}




