using _05.Inheritance;

namespace Cs.Advanced.UnitTests.Inheritance.UnitTests;

public class InheritanceCarUnitTests
{
    [Fact]
    public void Car_CheckAccelerateMethod()
    {
        // Arrange
        const int expectedSpeed = 9;
        var car = GetDefaultCar(speed: 5);

        // Act
        car.Accelerate();

        // Assert
        Assert.Equal(expectedSpeed, car.Speed);
    }

    [Fact]
    public void Car_CheckBrakeMethod()
    {
        // Arrange
        const int expectedSpeed = 1;
        var car = GetDefaultCar(speed: 5);

        // Act
        car.Brake();

        // Assert
        Assert.Equal(expectedSpeed, car.Speed);
    }

    [Fact]
    public void Car_CheckBrakeMethod_CantGoBelowZero()
    {
        // Arrange
        const int expectedSpeed = 0;
        var car = GetDefaultCar(speed: 1);

        // Act
        car.Brake();

        // Assert
        Assert.Equal(expectedSpeed, car.Speed);
    }

    [Fact]
    public void Car_CheckShiftGearMethod()
    {
        // Arrange
        const int expectedGear = 4;
        var car = GetDefaultCar(speed: 5);

        // Act
        car.ShiftGear(4);

        // Assert
        Assert.Equal(expectedGear, car.Gear);
    }

    [Fact]
    public void Car_CheckIndicateMethod()
    {
        // Arrange
        const IndicatorState expectedIndicatorState = IndicatorState.Right;
        var car = GetDefaultCar();

        // Act
        car.Indicate(IndicatorState.Right);

        // Assert
        Assert.Equal(expectedIndicatorState, car.IndicatorState);
    }

    [Fact]
    public void Car_CheckBoardMethod()
    {
        // Arrange
        const int expectedOccupants = 2;
        var car = GetDefaultCar(speed: 0, gear: 1, occupants: 1);

        // Act
        car.Board();

        // Assert
        Assert.Equal(expectedOccupants, car.Occupants);
    }

    [Fact]
    public void Car_CheckExitMethod()
    {
        // Arrange
        const int expectedOccupants = 1;
        var car = GetDefaultCar(speed: 0, gear: 1, occupants: 2);

        // Act
        car.Exit();

        // Assert
        Assert.Equal(expectedOccupants, car.Occupants);
    }

    private static Car GetDefaultCar(
        int speed = 0,
        int gear = 2,
        IndicatorState indicatorState = IndicatorState.Neutral,
        string owner = "Pius",
        int productionYear = 2010,
        string licensePlate = "LZ1023",
        int tankVolume = 40,
        int tankContent = 20,
        int seatCount = 5,
        int occupants = 1
    )
    {
        return new Car(
            speed,
            gear,
            indicatorState,
            owner,
            productionYear,
            licensePlate,
            tankVolume,
            tankContent,
            seatCount,
            occupants
        );
    }
}