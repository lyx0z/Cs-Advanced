namespace _05.Inheritance;

public class Bike(
    int speed,
    int gear,
    IndicatorState indicatorState,
    string owner,
    int yearBuilt,
    string licensePlate,
    int tankVolume,
    int tankContent,
    int leanAngle)
    : Vehicle(speed, gear, indicatorState, owner, yearBuilt, licensePlate, tankVolume, tankContent)
{
    private int LeanAngle = leanAngle;

    public override void Accelerate()
    {
        Speed += 6;
    }

    public override void Brake()
    {
        Speed -= 6;
    }

    public void Left()
    {
        LeanAngle -= 2;
    }

    public void Right()
    {
        LeanAngle += 2;
    }

    public override string GetTypeName()
    {
        return "Bike";
    }

    public override string ToString()
    {
        return $"Type:{nameof(Bike)}, Speed:{Speed}, Gear:{Gear}, Indicator:{IndicatorState}, Owner:{Owner}, " +
               $"Production Year:{YearBuilt}, License Plate:{LicensePlate}, Fuel Capacity:{TankVolume}, " +
               $"Fuel Level:{TankContent} Lean Angle:{LeanAngle}";
    }
}