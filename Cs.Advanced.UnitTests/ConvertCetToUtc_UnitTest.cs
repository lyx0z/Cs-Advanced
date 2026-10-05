namespace Cs.Advanced.UnitTests;

using _03.DateTimeAndTimeSpan;

public class ConvertCetToUtc_UnitTest
{
    [Fact]
    public void ConvertCetToUtc_SummerTime_SubtractsTwoHours()
    {
        //Arrange
        var cetTime = new DateTime(2021, 6, 6, 10, 10, 10);
        var expected = new DateTime(2021, 6, 6, 8, 10, 10);

        //Act
        var result = TimezoneConvert.ConvertCetToUtc(cetTime);

        //Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ConvertCetToUtc_WinterTime_SubtractsOneHour()
    {
        //Arrange
        var cetTime = new DateTime(2021, 12, 6, 10, 10, 10);
        var expected = new DateTime(2021, 12, 6, 9, 10, 10);

        //Act
        var result = TimezoneConvert.ConvertCetToUtc(cetTime);

        //Assert
        Assert.Equal(expected, result);
    }
}
