namespace _05.Inheritance;

public class Motorcycle(
    int speed,
    int gear,
    IndicatorState indicatorState,
    string owner,
    int productionYear,
    string licensePlate,
    int tankVolume,
    int tankContent,
    int leanAngle
) : Vehicle(speed, gear, indicatorState, owner, productionYear, licensePlate, tankVolume, tankContent)
{
    public int LeanAngle = leanAngle;

    public override void Accelerate()
    {
        Speed += 6;
    }

    public override void Brake()
    {
        Speed -= 6;
    
        if (Speed < 0)
        {
            Speed = 0;
        }
    }

    public void Left()
    {
        LeanAngle -= 2;
        
        if (LeanAngle < 0)
        {
            LeanAngle = 0;
        }
    }

    public void Right()
    {
        LeanAngle += 2;
    }

    public override string GetTypeName()
    {
        return "Motorcycle";
    }

    public override string ToString()
    {
        return $"Type:{nameof(Motorcycle)}, Speed:{Speed}, Gear:{Gear}, Indicator:{IndicatorState}, Owner:{Owner}, "
            + $"Production Year:{ProductionYear}, License Plate:{LicensePlate}, Fuel Capacity:{TankVolume}, "
            + $"Fuel Level:{TankContent} Lean Angle:{LeanAngle}";
    }
}
