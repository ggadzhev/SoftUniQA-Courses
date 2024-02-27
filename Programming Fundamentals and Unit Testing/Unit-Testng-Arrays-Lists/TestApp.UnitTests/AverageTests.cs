using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] OneElementArray = { 42 };
            
        // Act
        double actualResult = Average.CalculateAverage(OneElementArray);
        double expectedResult = 42;

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        int[] PositiveIntsArray = { 4, 6, 8, 10 };

        double actualResult = Average.CalculateAverage(PositiveIntsArray);
        double expectedResult = 7;

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        int[] NegativeIntsArray = { -4, -6, -8, -10 };

        double actualResult = Average.CalculateAverage(NegativeIntsArray);
        double expectedResult = -7;

        Assert.That(actualResult, Is.EqualTo(expectedResult));
        Assert.Negative(actualResult);
        

    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        int[] MixedIntsArray = { 40, -5, 30, -15 };

        double actualResult = Average.CalculateAverage(MixedIntsArray);
        double expectedResult = 12.5;

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
