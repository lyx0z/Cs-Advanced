using _05.Inheritance;

namespace Cs.Advanced.UnitTests.Inheritance.UnitTests;

public class InheritaceTruckUnitTests
{
    [Fact]
    public void Truck_CheckAccelerateMethod()
    {
        // Arrange
        const int expectedSpeed = 7;
        var truck = GetDefaultTruck(speed: 5);

        // Act
        truck.Accelerate();

        // Assert
        Assert.Equal(expectedSpeed, truck.Speed);
    }

    [Fact]
    public void Truck_CheckBrakeMethod()
    {
        // Arrange
        const int expectedSpeed = 8;
        var truck = GetDefaultTruck(speed: 10);

        // Act
        truck.Brake();

        // Assert
        Assert.Equal(expectedSpeed, truck.Speed);
    }

    [Fact]
    public void Truck_CheckBrakeMethod_WhenSpeedIsZero_StaysZero()
    {
        // Arrange
        const int expectedSpeed = 0;
        var truck = GetDefaultTruck(speed: 0);

        // Act
        truck.Brake();

        // Assert
        Assert.Equal(expectedSpeed, truck.Speed);
    }

    [Fact]
    public void Truck_CheckBrakeMethod_WhenResultingSpeedWouldBeNegative_SetToZero()
    {
        // Arrange
        const int expectedSpeed = 0;
        var truck = GetDefaultTruck(speed: 1);

        // Act
        truck.Brake();

        // Assert
        Assert.Equal(expectedSpeed, truck.Speed);
    }

    [Fact]
    public void Truck_CheckShiftGearMethod()
    {
        // Arrange
        const int expectedGear = 4;
        var truck = GetDefaultTruck();

        // Act
        truck.ShiftGear(4);

        // Assert
        Assert.Equal(expectedGear, truck.Gear);
    }

    [Fact]
    public void Truck_CheckIndicateMethod()
    {
        // Arrange
        const IndicatorState expectedIndicatorState = IndicatorState.Right;
        var truck = GetDefaultTruck();

        // Act
        truck.Indicate(IndicatorState.Right);

        // Assert
        Assert.Equal(expectedIndicatorState, truck.IndicatorState);
    }

    [Fact]
    public void Truck_CheckLoadMethod()
    {
        // Arrange
        const int expectedCargoWeight = 150;
        var truck = GetDefaultTruck(cargoWeight: 100);

        // Act
        truck.Load(50);

        // Assert
        Assert.Equal(expectedCargoWeight, truck.CargoWeight);
    }

    [Fact]
    public void Truck_CheckUnloadMethod_WhenCargoWeightPositive_SubtractsWeight()
    {
        // Arrange
        const int expectedCargoWeight = 70;
        var truck = GetDefaultTruck(cargoWeight: 100);

        // Act
        truck.Unload(30);

        // Assert
        Assert.Equal(expectedCargoWeight, truck.CargoWeight);
    }

    [Fact]
    public void Truck_CheckUnloadMethod_WhenCargoWeightIsZero_StaysZero()
    {
        // Arrange
        const int expectedCargoWeight = 0;
        var truck = GetDefaultTruck(cargoWeight: 0);

        // Act
        truck.Unload(10);

        // Assert
        Assert.Equal(expectedCargoWeight, truck.CargoWeight);
    }

    private static Truck GetDefaultTruck(
        int speed = 0,
        int gear = 2,
        IndicatorState indicatorState = IndicatorState.Neutral,
        string owner = "Pius",
        int productionYear = 2010,
        string licensePlate = "LZ1023",
        int tankVolume = 40,
        int tankContent = 20,
        int cargoWeight = 100
    )
    {
        return new Truck(
            speed,
            gear,
            indicatorState,
            owner,
            productionYear,
            licensePlate,
            tankVolume,
            tankContent,
            cargoWeight
        );
    }
}