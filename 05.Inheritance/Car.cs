namespace _05.Inheritance;

public class Car(
    int speed,
    int gear,
    IndicatorState indicatorState,
    string owner,
    int yearBuilt,
    string licensePlate,
    int tankVolume,
    int tankContent,
    int seatCount,
    int occupants
) : Vehicle(speed, gear, indicatorState, owner, yearBuilt, licensePlate, tankVolume, tankContent)
{
    public int SeatCount = seatCount;
    public int Occupants = occupants;

    public override void Accelerate()
    {
        Speed += 4;
    }

    public override void Brake()
    {
        if (Speed > 0)
        {
            Speed -= 2;
        }
        else
        {
            Speed = 0;
        }
    }

    public void Board()
    {
        Occupants++;
    }

    public void Exit()
    {
        Occupants--;
    }

    public override string GetTypeName()
    {
        return "PKW";
    }

    public override string ToString()
    {
        return $"Type:{nameof(Car)}, Speed:{Speed}, Gear:{Gear}, Indicator:{IndicatorState}, Owner:{Owner}, "
            + $"Production Year:{YearBuilt}, License Plate:{LicensePlate}, Fuel Capacity:{TankVolume}, "
            + $"Fuel Level:{TankContent} Seat Count:{SeatCount}, Occupants:{Occupants}";
    }
}
