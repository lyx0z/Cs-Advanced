using _05.Inheritance;

namespace Cs.Advanced.UnitTests.Inheritance.UnitTests;

public class InheritanceVehicleUnitTests
{
    [Fact]
    public void Vehicle_CheckAccelerateMethod()
    {
        // Arrange
        const int expectedSpeed = 6;
        var vehicle = GetDefaultVehicle(speed: 5);

        // Act
        vehicle.Accelerate();

        // Assert
        Assert.Equal(expectedSpeed, vehicle.Speed);
    }

    [Fact]
    public void Vehicle_CheckBrakeMethod()
    {
        // Arrange
        const int expectedSpeed = 4;
        var vehicle = GetDefaultVehicle(speed: 5);

        // Act
        vehicle.Brake();

        // Assert
        Assert.Equal(expectedSpeed, vehicle.Speed);
    }

    [Fact]
    public void Vehicle_CheckBrakeMethod_WhenSpeedIsZero_StaysZero()
    {
        // Arrange
        const int expectedSpeed = 0;
        var vehicle = GetDefaultVehicle(speed: 0);

        // Act
        vehicle.Brake();

        // Assert
        Assert.Equal(expectedSpeed, vehicle.Speed);
    }

    [Fact]
    public void Vehicle_CheckShiftGearMethod()
    {
        // Arrange
        const int expectedGear = 3;
        var vehicle = GetDefaultVehicle();

        // Act
        vehicle.ShiftGear(3);

        // Assert
        Assert.Equal(expectedGear, vehicle.Gear);
    }

    [Fact]
    public void Vehicle_CheckIndicateMethod()
    {
        // Arrange
        const IndicatorState expectedIndicatorState = IndicatorState.Left;
        var vehicle = GetDefaultVehicle();

        // Act
        vehicle.Indicate(IndicatorState.Left);

        // Assert
        Assert.Equal(expectedIndicatorState, vehicle.IndicatorState);
    }

    [Fact]
    public void Vehicle_CheckRefuelMethod_AddsFuelCorrectly()
    {
        // Arrange
        const int expectedTankContent = 30;
        var vehicle = GetDefaultVehicle(tankVolume: 50, tankContent: 10);

        // Act
        vehicle.Refuel(20);

        // Assert
        Assert.Equal(expectedTankContent, vehicle.TankContent);
    }

    [Fact]
    public void Vehicle_CheckRefuelMethod_CapsAtTankVolume()
    {
        // Arrange
        const int expectedTankContent = 50;
        var vehicle = GetDefaultVehicle(tankVolume: 50, tankContent: 40);

        // Act
        vehicle.Refuel(20);

        // Assert
        Assert.Equal(expectedTankContent, vehicle.TankContent);
    }
    
    private static UnitTestVehicle GetDefaultVehicle(
        int speed = 0,
        int gear = 0,
        IndicatorState indicatorState = IndicatorState.Neutral,
        string owner = "Pius",
        int productionYear = 2010,
        string licensePlate = "LZ1023",
        int tankVolume = 40,
        int tankContent = 20
    )
    {
        return new UnitTestVehicle(
            speed,
            gear,
            indicatorState,
            owner,
            productionYear,
            licensePlate,
            tankVolume,
            tankContent
        );
    }
    
    private class UnitTestVehicle(
        int speed,
        int gear,
        IndicatorState indicatorState,
        string owner,
        int productionYear,
        string licensePlate,
        int tankVolume,
        int tankContent)
        : Vehicle(speed, gear, indicatorState, owner, productionYear, licensePlate, tankVolume, tankContent);
}