using _05.Inheritance;

namespace Cs.Advanced.UnitTests.Inheritance.UnitTests;

public class inheritace_Car_UnitTests
{
    [Fact]
    public void Car_CheckAccelerateMethod()
    {
        // Arrange
        var car = new Car(
            speed: 5,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            productionYear: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            seatCount: 5,
            occupants: 1
        );
        var expectedSpeed = 9;

        // Act
        car.Accelerate();

        // Assert
        Assert.Equal(expectedSpeed, car.Speed);
    }

    [Fact]
    public void Car_CheckBrakeMethod()
    {
        // Arrange
        var car = new Car(
            speed: 5,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            productionYear: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            seatCount: 5,
            occupants: 1
        );
        var expectedSpeed = 1;

        // Act
        car.Brake();

        // Assert
        Assert.Equal(expectedSpeed, car.Speed);
    }

    [Fact]
    public void Car_CheckBrakeMethod_CantGoBelowZero()
    {
        // Arrange
        var car = new Car(
            speed: 1,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            productionYear: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            seatCount: 5,
            occupants: 1
        );
        var expectedSpeed = 0;

        // Act
        car.Brake();

        // Assert
        Assert.Equal(expectedSpeed, car.Speed);
    }

    [Fact]
    public void Car_CheckShiftGearMethod()
    {
        // Arrange
        var car = new Car(
            speed: 5,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            productionYear: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            seatCount: 5,
            occupants: 1
        );
        var expectedGear = 4;

        // Act
        car.ShiftGear(4);

        // Assert
        Assert.Equal(expectedGear, car.Gear);
    }

    [Fact]
    public void Car_CheckIndicateMethod()
    {
        // Arrange
        var car = new Car(
            speed: 5,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            productionYear: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            seatCount: 5,
            occupants: 1
        );
        var expectedIndicatorState = IndicatorState.Right;

        // Act
        car.Indicate(IndicatorState.Right);

        // Assert
        Assert.Equal(expectedIndicatorState, car.IndicatorState);
    }

    [Fact]
    public void Car_CheckBoardMethod()
    {
        // Arrange
        var car = new Car(
            speed: 0,
            gear: 1,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            productionYear: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            seatCount: 5,
            occupants: 1
        );
        var expectedOccupants = 2;

        // Act
        car.Board();

        // Assert
        Assert.Equal(expectedOccupants, car.Occupants);
    }

    [Fact]
    public void Car_CheckExitMethod()
    {
        // Arrange
        var car = new Car(
            speed: 0,
            gear: 1,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            productionYear: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            seatCount: 5,
            occupants: 2
        );
        var expectedOccupants = 1;

        // Act
        car.Exit();

        // Assert
        Assert.Equal(expectedOccupants, car.Occupants);
    }
}
