namespace _05.Inheritance;

public class Truck(
    int speed,
    int gear,
    IndicatorState indicatorState,
    string owner,
    int productionYear,
    string licensePlate,
    int tankVolume,
    int tankContent,
    int cargoWeight
) : Vehicle(speed, gear, indicatorState, owner, productionYear, licensePlate, tankVolume, tankContent)
{
    public int CargoWeight = cargoWeight;

    public override void Accelerate()
    {
        Speed += 2;
    }

    public override void Brake()
    {
        Speed -= 2;
    
        if (Speed < 0)
        {
            Speed = 0;
        }
    }

    public void Load(int weight)
    {
        CargoWeight += weight;
    }

    public void Unload(int weight)
    {
        if (CargoWeight - weight >= 0)
        {
            CargoWeight -= weight;
        }
    }

    public override string GetTypeName()
    {
        return nameof(Truck);
    }

    public override string ToString()
    {
        return $"Type:{nameof(Truck)}, Speed:{Speed}, Gear:{Gear}, Indicator:{IndicatorState}, Owner:{Owner}, "
            + $"Production Year:{ProductionYear}, License Plate:{LicensePlate}, Fuel Capacity:{TankVolume}, "
            + $"Fuel Level:{TankContent} Cargo Weight:{CargoWeight}";
    }
}
