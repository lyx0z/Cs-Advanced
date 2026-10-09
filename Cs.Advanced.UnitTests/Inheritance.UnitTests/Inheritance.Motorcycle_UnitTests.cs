using _05.Inheritance;

namespace Cs.Advanced.UnitTests.Inheritance.UnitTests;

public class InheritanceMotorcycleUnitTests
{
    [Fact]
    public void Motorcycle_CheckAccelerateMethod()
    {
        // Arrange
        const int expectedSpeed = 11;
        var motorcycle = GetDefaultBike(speed: 5);

        // Act
        motorcycle.Accelerate();

        // Assert
        Assert.Equal(expectedSpeed, motorcycle.Speed);
    }

    [Fact]
    public void Motorcycle_CheckBrakeMethod()
    {
        // Arrange
        const int expectedSpeed = 4;
        var motorcycle = GetDefaultBike(speed: 10); 

        // Act
        motorcycle.Brake();

        // Assert
        Assert.Equal(expectedSpeed, motorcycle.Speed);
    }

    [Fact]
    public void Motorcycle_CheckBrakeMethod_DoesNotGoBelowZero()
    {
        // Arrange
        const int expectedSpeed = 0;
        var motorcycle = GetDefaultBike(speed: 3);

        // Act
        motorcycle.Brake();

        // Assert
        Assert.Equal(expectedSpeed, motorcycle.Speed);
    }

    [Fact]
    public void Motorcycle_CheckBrakeMethod_WhenSpeedIsZero_StaysZero()
    {
        // Arrange
        const int expectedSpeed = 0;
        var motorcycle = GetDefaultBike(speed: 0);
        
        // Act
        motorcycle.Brake();

        // Assert
        Assert.Equal(expectedSpeed, motorcycle.Speed);
    }

    [Fact] 
    public void Motorcycle_CheckShiftGearMethod()
    {
        // Arrange
        const int expectedGear = 4;
        var motorcycle = GetDefaultBike();

        // Act
        motorcycle.ShiftGear(expectedGear);

        // Assert
        Assert.Equal(expectedGear, motorcycle.Gear);
    }

    [Fact]
    public void Motorcycle_CheckIndicateMethod()
    {
        // Arrange
        const IndicatorState expectedIndicatorState = IndicatorState.Left;
        var motorcycle = GetDefaultBike();

        // Act
        motorcycle.Indicate(expectedIndicatorState);

        // Assert
        Assert.Equal(expectedIndicatorState, motorcycle.IndicatorState);
    }

    [Fact]
    public void Motorcycle_CheckLeftMethod()
    {
        // Arrange
        const int expectedLeanAngle = -2;
        var motorcycle = GetDefaultBike();

        // Act
        motorcycle.Left();

        // Assert
        Assert.Equal(expectedLeanAngle, motorcycle.LeanAngle);
    }

    [Fact]
    public void Motorcycle_CheckRightMethod()
    {
        // Arrange
        const int expectedLeanAngle = 2;
        var motorcycle = GetDefaultBike();

        // Act
        motorcycle.Right();

        // Assert
        Assert.Equal(expectedLeanAngle, motorcycle.LeanAngle);
    }
    
    private static Motorcycle GetDefaultBike(
        int speed = 0,
        int gear = 0,
        IndicatorState indicatorState = IndicatorState.Neutral,
        string owner = "How did we get here?",
        int yearBuild = 2026,
        string licensePlate = "ImBacon",
        int tankVolume = 42,
        int tankContent = 0,
        int leanAngle = 0
    )
    {
        return new Motorcycle(
            speed,
            gear,
            indicatorState,
            owner,
            yearBuild,
            licensePlate,
            tankVolume,
            tankContent,
            leanAngle
        );
    }
    
}
