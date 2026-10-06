namespace _05.Inheritance;

public class Truck(
    int speed,
    int gear,
    IndicatorState indicatorState,
    string owner,
    int yearBuilt,
    string licensePlate,
    int tankVolume,
    int tankContent,
    int cargoWeight)
    : Vehicle(speed, gear, indicatorState, owner, yearBuilt, licensePlate, tankVolume, tankContent)
{
    public int CargoWeight = cargoWeight;

    public override void Accelerate()
    {
        Speed += 2;
    }

    public override void Brake()
    {
        Speed -= 2;
    }

    public void Load(int weight)
    {
        CargoWeight += weight;
    }

    public void Unload(int weight)
    {
        CargoWeight -= weight;
    }

    public override string GetTypeName()
    {
        return "LKW";
    }

    public override string ToString()
    {
        return $"Type:{nameof(Car)}, Speed:{Speed}, Gear:{Gear}, Indicator:{IndicatorState}, Owner:{Owner}, " +
               $"Production Year:{YearBuilt}, License Plate:{LicensePlate}, Fuel Capacity:{TankVolume}, " +
               $"Fuel Level:{TankContent} Cargo Weight:{CargoWeight}";
    }
}