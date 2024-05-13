using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    // TODO: finish test
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = { };
        string expectedResult = string.Empty;

        // Act
        string actualResult = CountRealNumbers.Count(emptyArray);

        // Assert
        Assert.That(actualResult, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] singleDigitArray = {1};
        string expectedResult = "1 -> 1";

        // Act
        string actualResult = CountRealNumbers.Count(singleDigitArray);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] singleDigitArray = { 1, 1, 1 };
        string expectedResult = "1 -> 3";

        // Act
        string actualResult = CountRealNumbers.Count(singleDigitArray);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] singleDigitArray = {-1,-1,-1 };
        string expectedResult = "-1 -> 3";

        // Act
        string actualResult = CountRealNumbers.Count(singleDigitArray);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] singleDigitArray = { 0 };
        string expectedResult = "0 -> 1";

        // Act
        string actualResult = CountRealNumbers.Count(singleDigitArray);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
