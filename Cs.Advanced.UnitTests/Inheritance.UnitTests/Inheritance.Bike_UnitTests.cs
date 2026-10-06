namespace Cs.Advanced.UnitTests;

using _05.Inheritance;

public class inheritace_Bike_UnitTests
{
    [Fact]
    public void Bike_CheckAccelerateMethod()
    {
        // Arrange
        var bike = new Bike(
            speed: 5,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            leanAngle: 0
        );
        var expectedSpeed = 11;

        // Act
        bike.Accelerate();

        // Assert
        Assert.Equal(expectedSpeed, bike.Speed);
    }

    [Fact]
    public void Bike_CheckBrakeMethod()
    {
        // Arrange
        var bike = new Bike(
            speed: 10,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            leanAngle: 0
        );
        var expectedSpeed = 4;

        // Act
        bike.Brake();

        // Assert
        Assert.Equal(expectedSpeed, bike.Speed);
    }

    [Fact]
    public void Bike_CheckBrakeMethod_DoesNotGoBelowZero()
    {
        // Arrange
        var bike = new Bike(
            speed: 3,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            leanAngle: 0
        );
        var expectedSpeed = 0;

        // Act
        bike.Brake();

        // Assert
        Assert.Equal(expectedSpeed, bike.Speed);
    }

    [Fact]
    public void Bike_CheckBrakeMethod_WhenSpeedIsZero_StaysZero()
    {
        // Arrange
        var bike = new Bike(
            speed: 0,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            leanAngle: 0
        );
        var expectedSpeed = 0;

        // Act
        bike.Brake();

        // Assert
        Assert.Equal(expectedSpeed, bike.Speed);
    }

    [Fact]
    public void Bike_CheckShiftGearMethod()
    {
        // Arrange
        var bike = new Bike(
            speed: 5,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            leanAngle: 0
        );
        var expectedGear = 4;

        // Act
        bike.ShiftGear(4);

        // Assert
        Assert.Equal(expectedGear, bike.Gear);
    }

    [Fact]
    public void Bike_CheckIndicateMethod()
    {
        // Arrange
        var bike = new Bike(
            speed: 5,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            leanAngle: 0
        );
        var expectedIndicatorState = IndicatorState.Left;

        // Act
        bike.Indicate(IndicatorState.Left);

        // Assert
        Assert.Equal(expectedIndicatorState, bike.IndicatorState);
    }

    [Fact]
    public void Bike_CheckLeftMethod()
    {
        // Arrange
        var bike = new Bike(
            speed: 0,
            gear: 1,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            leanAngle: 0
        );
        var expectedLeanAngle = 0;

        // Act
        bike.Left();

        // Assert
        Assert.Equal(expectedLeanAngle, bike.LeanAngle);
    }

    [Fact]
    public void Bike_CheckRightMethod()
    {
        // Arrange
        var bike = new Bike(
            speed: 0,
            gear: 1,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            leanAngle: 0
        );
        var expectedLeanAngle = 2;

        // Act
        bike.Right();

        // Assert
        Assert.Equal(expectedLeanAngle, bike.LeanAngle);
    }
}
