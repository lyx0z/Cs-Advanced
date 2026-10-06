namespace _05.Inheritance;

public static class Program
{
    public static void Main()
    {
        var bike = new Bike(speed: 10, gear: 1, indicatorState: IndicatorState.Neutral, owner: "Pius", yearBuilt: 2010,
            licensePlate: "LZ1023", tankVolume: 40, tankContent: 20, leanAngle: 0);
        
        var car = new Car(speed: 10, gear: 1, indicatorState: IndicatorState.Neutral, owner: "Eray", yearBuilt: 2000,
            licensePlate: "ZH9219", tankVolume: 50, tankContent: 10, seatCount: 4, occupants: 4);

        var truck = new Truck(speed: 8, gear: 2, IndicatorState.Left, owner: "Victor", yearBuilt: 1990,
            licensePlate: "ZH6767", tankVolume: 67, tankContent: 40, cargoWeight: 50);
        
        bike.Accelerate();
        car.Exit();
        truck.Load(20);
        
        var bikeContents = bike.ToString();
        var carContents = car.ToString();
        var truckContents = truck.ToString();
        
        Console.WriteLine(bikeContents);
        Console.WriteLine(carContents);
        Console.WriteLine(truckContents);
    }
}