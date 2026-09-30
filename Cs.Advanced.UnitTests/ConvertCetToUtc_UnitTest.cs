namespace Cs.Advanced.UnitTests;

using _03.DateTimeAndTimeSpan;

public class ConvertCetToUtc_UnitTest
{
    [Fact]
    public void Convert_CetTimeToUtcTime_FirstDate()
    {
        // Arrange
        var firstTime = new DateTime(2021, 10, 6, 10, 10, 10);
        var targetTime = new DateTime(2021, 10, 6, 9, 10, 10);
        // Act
        var result = TimezoneConvert.ConvertCetToUtc(firstTime);
        // Assert
        Assert.True(targetTime == result);
    }
}
