namespace Cs.Advanced.UnitTests;

using _03.DateTimeAndTimeSpan;

public class IsDeadLinePastDue_UnitTest
{
    [Fact]
    public void IsDeadlinePastDue_DueDateBeforeToday_ReturnsTrue()
    {
        // Arrange
        var invoice = new Invoice { dueDate = DateTime.Today.AddDays(-10) };

        // Act
        var result = invoice.IsDeadLinePastDue();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsDeadlinePastDue_DueDateAfterToday_ReturnsFalse()
    {
        //Arrange
        var invoice = new Invoice { dueDate = DateTime.Today.AddDays(10) };

        //Act
        var result = invoice.IsDeadLinePastDue();

        //Assert
        Assert.False(result);
    }

    [Fact]
    public void IsDeadlinePastDue_DueDateIsToday_ReturnsFalse()
    {
        //Arrange
        var invoice = new Invoice { dueDate = DateTime.Today };

        //Act
        var result = invoice.IsDeadLinePastDue();

        //Assert
        Assert.False(result);
    }
}
