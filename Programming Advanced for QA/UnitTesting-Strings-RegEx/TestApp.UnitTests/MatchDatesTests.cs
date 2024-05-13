using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    // TODO: finish the test
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        // Arrange
        string validDate = "11.May.1992";
        string expectedResult = "Day: 11, Month: May, Year: 1992";

        // Act

        string actualResult = MatchDates.Match(validDate);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    // TODO: finish the test
    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        string invalidDateFormat = "Invalid date format";
        string expectedresult = string.Empty;

        // Act
        string actualResult = MatchDates.Match(invalidDateFormat);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedresult));
    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        // Arrange
        string validDate = "11.May.1992-12.May-1992.8-Mar-1992";
        string expectedResult = "Day: 11, Month: May, Year: 1992";

        // Act

        string actualResult = MatchDates.Match(validDate);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string validDate = string.Empty;
        string expectedResult = string.Empty;

        // Act

        string actualResult = MatchDates.Match(validDate);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        string validDate = null;
        
        Assert.Throws<ArgumentException>(() => MatchDates.Match(validDate));
    }
}
