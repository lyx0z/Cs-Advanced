namespace Cs.Advanced.UnitTests;

using _05.Inheritance;

public class inheritace_Truck_UnitTests
{
    [Fact]
    public void Truck_CheckAccelerateMethod()
    {
        // Arrange
        var truck = new Truck(
            speed: 5,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            cargoWeight: 100
        );
        var expectedSpeed = 7;

        // Act
        truck.Accelerate();

        // Assert
        Assert.Equal(expectedSpeed, truck.Speed);
    }

    [Fact]
    public void Truck_CheckBrakeMethod()
    {
        // Arrange
        var truck = new Truck(
            speed: 10,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            cargoWeight: 100
        );
        var expectedSpeed = 4;

        // Act
        truck.Brake();

        // Assert
        Assert.Equal(expectedSpeed, truck.Speed);
    }

    [Fact]
    public void Truck_CheckBrakeMethod_WhenSpeedIsZero_StaysZero()
    {
        // Arrange
        var truck = new Truck(
            speed: 0,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            cargoWeight: 100
        );
        var expectedSpeed = 0;

        // Act
        truck.Brake();

        // Assert
        Assert.Equal(expectedSpeed, truck.Speed);
    }

    [Fact]
    public void Truck_CheckBrakeMethod_WhenResultingSpeedWouldBeNegative_SetToZero()
    {
        // Arrange
        var truck = new Truck(
            speed: 3,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            cargoWeight: 100
        );
        var expectedSpeed = -3;

        // Act
        truck.Brake();

        // Assert
        Assert.Equal(expectedSpeed, truck.Speed);
    }

    [Fact]
    public void Truck_CheckShiftGearMethod()
    {
        // Arrange
        var truck = new Truck(
            speed: 5,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            cargoWeight: 100
        );
        var expectedGear = 4;

        // Act
        truck.ShiftGear(4);

        // Assert
        Assert.Equal(expectedGear, truck.Gear);
    }

    [Fact]
    public void Truck_CheckIndicateMethod()
    {
        // Arrange
        var truck = new Truck(
            speed: 5,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            cargoWeight: 100
        );
        var expectedIndicatorState = IndicatorState.Right;

        // Act
        truck.Indicate(IndicatorState.Right);

        // Assert
        Assert.Equal(expectedIndicatorState, truck.IndicatorState);
    }

    [Fact]
    public void Truck_CheckLoadMethod()
    {
        // Arrange
        var truck = new Truck(
            speed: 0,
            gear: 1,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            cargoWeight: 100
        );
        var expectedCargoWeight = 150;

        // Act
        truck.Load(50);

        // Assert
        Assert.Equal(expectedCargoWeight, truck.CargoWeight);
    }

    [Fact]
    public void Truck_CheckUnloadMethod_WhenCargoWeightPositive_SubtractsWeight()
    {
        // Arrange
        var truck = new Truck(
            speed: 0,
            gear: 1,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            cargoWeight: 100
        );
        var expectedCargoWeight = 70;

        // Act
        truck.Unload(30);

        // Assert
        Assert.Equal(expectedCargoWeight, truck.CargoWeight);
    }

    [Fact]
    public void Truck_CheckUnloadMethod_WhenCargoWeightIsZero_StaysZero()
    {
        // Arrange
        var truck = new Truck(
            speed: 5,
            gear: 2,
            indicatorState: IndicatorState.Neutral,
            owner: "Pius",
            yearBuilt: 2010,
            licensePlate: "LZ1023",
            tankVolume: 40,
            tankContent: 20,
            cargoWeight: 0
        );
        var expectedCargoWeight = 0;

        // Act
        truck.Unload(10);

        // Assert
        Assert.Equal(expectedCargoWeight, truck.CargoWeight);
    }
}
