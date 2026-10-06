namespace Cs.Advanced.UnitTests;

using _05.Inheritance;

public class inheritace_Vehicle_UnitTests
{
    [Fact]
    public void Vehicle_CheckAccelerateMethod()
    {
        // Arrange
        var vehicle = new Vehicle(
            speed: 5,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20
        );
        var expectedSpeed = 6;

        // Act
        vehicle.Accelerate();

        // Assert
        Assert.Equal(expectedSpeed, vehicle.Speed);
    }

    [Fact]
    public void Vehicle_CheckBrakeMethod()
    {
        // Arrange
        var vehicle = new Vehicle(
            speed: 5,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20
        );
        var expectedSpeed = 4;

        // Act
        vehicle.Brake();

        // Assert
        Assert.Equal(expectedSpeed, vehicle.Speed);
    }

    [Fact]
    public void Vehicle_CheckBrakeMethod_DoesNotGoBelowZero()
    {
        // Arrange
        var vehicle = new Vehicle(
            speed: 0,
            gear: 1,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20
        );
        var expectedSpeed = 0;

        // Act
        vehicle.Brake();

        // Assert
        Assert.Equal(expectedSpeed, vehicle.Speed);
    }

    [Fact]
    public void Vehicle_CheckShiftGearMethod()
    {
        // Arrange
        var vehicle = new Vehicle(
            speed: 5,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20
        );
        var expectedGear = 4;

        // Act
        vehicle.ShiftGear(4);

        // Assert
        Assert.Equal(expectedGear, vehicle.Gear);
    }

    [Fact]
    public void Vehicle_CheckIndicateMethod()
    {
        // Arrange
        var vehicle = new Vehicle(
            speed: 5,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20
        );
        var expectedIndicatorState = IndicatorState.Left;

        // Act
        vehicle.Indicate(IndicatorState.Left);

        // Assert
        Assert.Equal(expectedIndicatorState, vehicle.IndicatorState);
    }
}
