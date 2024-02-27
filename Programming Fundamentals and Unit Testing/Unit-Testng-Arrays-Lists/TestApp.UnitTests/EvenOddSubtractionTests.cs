using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int actualResult = EvenOddSubtraction.FindDifference(emptyArray);
        int expectedResult = 0;

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }


    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] onlyEvenNumbersArray = { 20, 40, 60, 80 };

        // Act
        int actualResult = EvenOddSubtraction.FindDifference(onlyEvenNumbersArray);
        int expectedResult = 200;

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        //arrange
        int[] onlyOddNumbersArray = { -3, 1, 3, 5, };

        //act
        int actualResult = EvenOddSubtraction.FindDifference(onlyOddNumbersArray);
        int expectedResult = -6;

        //assert

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        //assert
        int[] mixedNumbersArray = { 5, 8, 11, 14 };

        //act
        int actualResult = EvenOddSubtraction.FindDifference(mixedNumbersArray);

        int expectedResult = 6;

        //assert

        Assert.That(actualResult, Is.EqualTo(expectedResult));


    }
}
