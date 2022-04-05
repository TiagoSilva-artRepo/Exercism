using System;
using System.Globalization;

class WeighingMachine
{
    // TODO: define the 'Precision' property
    public int Precision { get;}

    // TODO: define the 'Weight' property
    private double weight;
    public double Weight
    { 
        get { return weight; } 
        set
        { 
            if (value < 0) throw new ArgumentOutOfRangeException();
            weight = value;
        }
    }

    // TODO: define the 'DisplayWeight' property
    public string DisplayWeight
    {
        get { return $"{String.Format(CultureInfo.InvariantCulture, $"{{0:F{Precision}}}", Weight-TareAdjustment)} kg"; }
    }

    // TODO: define the 'TareAdjustment' property
    public double TareAdjustment { get; set; } = 5;

    public WeighingMachine(int precision)
    {
        this.Precision = precision;
    }
}
