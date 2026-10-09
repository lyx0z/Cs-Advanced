namespace _05.Inheritance;

public class Car(
    int speed,
    int gear,
    IndicatorState indicatorState,
    string owner,
    int productionYear,
    string licensePlate,
    int tankVolume,
    int tankContent,
    int seatCount,
    int occupants
) : Vehicle(speed, gear, indicatorState, owner, productionYear, licensePlate, tankVolume, tankContent)
{
    private readonly int seatCount = seatCount;
    public int Occupants = occupants;

    public override void Accelerate()
    {
        Speed += 4;
    }

    public override void Brake()
    {
        Speed -= 4;
    
        if (Speed < 0)
        {
            Speed = 0;
        }
    }

    public void Board()
    {
        if (Occupants < seatCount)
        {
            Occupants++;
        }
    }

    public void Exit()
    {
        if (Occupants > 0)
        {
            Occupants--;
        }
    }

    public override string GetTypeName()
    {
        return nameof(Car);
    }

    public override string ToString()
    {
        return $"Type:{nameof(Car)}, Speed:{Speed}, Gear:{Gear}, Indicator:{IndicatorState}, Owner:{Owner}, "
            + $"Production Year:{ProductionYear}, License Plate:{LicensePlate}, Fuel Capacity:{TankVolume}, "
            + $"Fuel Level:{TankContent} Seat Count:{seatCount}, Occupants:{Occupants}";
    }
}
