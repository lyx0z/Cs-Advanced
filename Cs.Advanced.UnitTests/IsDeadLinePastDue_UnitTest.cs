namespace Cs.Advanced.UnitTests;

using _03.DateTimeAndTimeSpan;

public class IsDeadLinePastDue_UnitTest
{
    [Fact]
    public void IsDeadlinePastDue_DueTime_SmallerThenToday()
    {
        // Arrange
        var dueTime = new DateTime(2026, 8, 10);
        // Act
        var result = Invoice.IsDeadLinePastDue(dueTime);
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void isDeadlinePastDue_DueTime_BiggerThenToday()
    {
        // Arrange
        var dueTime = new DateTime(2026, 10, 28);
        // Act
        var result = Invoice.IsDeadLinePastDue(dueTime);
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void isDeadlinePastDue_DueTime_SameAsToday()
    {
        // Arrange
        var dueTime = DateTime.Today;
        // Act
        var result = Invoice.IsDeadLinePastDue(dueTime);
        // Assert
        Assert.False(result);
    }
}
