using _05.Inheritance;

namespace Cs.Advanced.UnitTests.Inheritance.UnitTests;

public class inheritace_Motorcycle_UnitTests
{
    [Fact]
    public void Motorcycle_CheckAccelerateMethod()
    {
        // Arrange
        var motorcycle = new Motorcycle(
            speed: 5,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            productionYear: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            leanAngle: 0
        );
        var expectedSpeed = 11;

        // Act
        motorcycle.Accelerate();

        // Assert
        Assert.Equal(expectedSpeed, motorcycle.Speed);
    }

    [Fact]
    public void Motorcycle_CheckBrakeMethod()
    {
        // Arrange
        var motorcycle = new Motorcycle(
            speed: 10,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            productionYear: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            leanAngle: 0
        );
        var expectedSpeed = 4;

        // Act
        motorcycle.Brake();

        // Assert
        Assert.Equal(expectedSpeed, motorcycle.Speed);
    }

    [Fact]
    public void Motorcycle_CheckBrakeMethod_DoesNotGoBelowZero()
    {
        // Arrange
        var motorcycle = new Motorcycle(
            speed: 3,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            productionYear: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            leanAngle: 0
        );
        var expectedSpeed = 0;

        // Act
        motorcycle.Brake();

        // Assert
        Assert.Equal(expectedSpeed, motorcycle.Speed);
    }

    [Fact]
    public void Motorcycle_CheckBrakeMethod_WhenSpeedIsZero_StaysZero()
    {
        // Arrange
        var motorcycle = new Motorcycle(
            speed: 0,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            productionYear: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            leanAngle: 0
        );
        var expectedSpeed = 0;

        // Act
        motorcycle.Brake();

        // Assert
        Assert.Equal(expectedSpeed, motorcycle.Speed);
    }

    [Fact] public void Motorcycle_CheckShiftGearMethod()
    {
        // Arrange
        var motorcycle = new Motorcycle(
            speed: 5,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            productionYear: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            leanAngle: 0
        );
        var expectedGear = 4;

        // Act
        motorcycle.ShiftGear(4);

        // Assert
        Assert.Equal(expectedGear, motorcycle.Gear);
    }

    [Fact]
    public void Motorcycle_CheckIndicateMethod()
    {
        // Arrange
        var motorcycle = new Motorcycle(
            speed: 5,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            productionYear: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            leanAngle: 0
        );
        var expectedIndicatorState = IndicatorState.Left;

        // Act
        motorcycle.Indicate(IndicatorState.Left);

        // Assert
        Assert.Equal(expectedIndicatorState, motorcycle.IndicatorState);
    }

    [Fact]
    public void Motorcycle_CheckLeftMethod()
    {
        // Arrange
        var motorcycle = new Motorcycle(
            speed: 0,
            gear: 1,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            productionYear: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            leanAngle: 0
        );
        var expectedLeanAngle = 0;

        // Act
        motorcycle.Left();

        // Assert
        Assert.Equal(expectedLeanAngle, motorcycle.LeanAngle);
    }

    [Fact]
    public void Motorcycle_CheckRightMethod()
    {
        // Arrange
        var motorcycle = new Motorcycle(
            speed: 0,
            gear: 1,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            productionYear: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            leanAngle: 0
        );
        var expectedLeanAngle = 2;

        // Act
        motorcycle.Right();

        // Assert
        Assert.Equal(expectedLeanAngle, motorcycle.LeanAngle);
    }
}
