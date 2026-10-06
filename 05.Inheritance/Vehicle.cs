namespace _05.Inheritance;

public enum IndicatorState
{
    Left,
    Right,
    Neutral
}

public class Vehicle
{
    public int Speed;
    public int Gear;
    public IndicatorState IndicatorState;
    public string Owner;
    public int YearBuilt;
    public string LicensePlate;
    public int TankVolume;
    public int TankContent;

    public Vehicle(int speed, int gear, IndicatorState indicatorState, string owner,
        int yearBuilt, string licensePlate, int tankVolume, int tankContent)
    {
        Speed = speed;
        Gear = gear;
        IndicatorState = indicatorState;
        Owner = owner;
        YearBuilt = yearBuilt;
        LicensePlate = licensePlate;
        TankVolume = tankVolume;
        TankContent = tankContent;
    }

    public virtual void Accelerate()
    {
        Speed++;
    }

    public virtual void Brake()
    {
        if (Speed > 0)
        {
            Speed--;
        }
    }

    public void ShiftGear(int gear)
    {
        Gear = gear;
    }

    public void Indicate(IndicatorState indicatorState)
    {
        IndicatorState = indicatorState;
    }

    public void Refuel(int liters)
    {
        TankContent += liters;
    }

    public virtual string GetTypeName()
    {
        return "Vehicle";
    }
}