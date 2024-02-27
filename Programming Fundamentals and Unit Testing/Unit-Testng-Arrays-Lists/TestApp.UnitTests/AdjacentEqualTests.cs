using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string actualResult = AdjacentEqual.Sum(emptyList);
        string expectedResult = string.Empty;

        // Assert

        Assert.That(actualResult, Is.EqualTo(expectedResult));

    }

    // TODO: finish test
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> numbers = new() { 1, 2, 3, 4, 5 };
        
        // Act

        string actualResult = AdjacentEqual.Sum(numbers);
        string expectedResult = "1 2 3 4 5";

        // Assert
        Assert.That(actualResult == expectedResult);
        Assert.That(actualResult.Length, Is.EqualTo(expectedResult.Length));
        
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new() { 4, 4, 5, 5,}; // 4 +4 5+5

        // Act

        string actualResult = AdjacentEqual.Sum(numbers);
        string expectedResult = "8 10";

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
        Assert.That(actualResult.Length, Is.EqualTo(4));

    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        List<int> numbers = new() { 6, 6, 6, 6, };

        // Act

        string actualResult = AdjacentEqual.Sum(numbers);
        string expectedResult = "24";

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        List<int> numbers = new() { 6, 6, 5, 3, 7, 9 };

        // Act

        string actualResult = AdjacentEqual.Sum(numbers);
        string expectedResult = "12 5 3 7 9";

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        List<int> numbers = new() { 6, 1, 5, 3, 9, 9 };

        // Act

        string actualResult = AdjacentEqual.Sum(numbers);
        string expectedResult = "6 1 5 3 18";

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        List<int> numbers = new() { 6, 1, 5, 5, 9, 11 };

        // Act

        string actualResult = AdjacentEqual.Sum(numbers);
        string expectedResult = "6 1 10 9 11";

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
