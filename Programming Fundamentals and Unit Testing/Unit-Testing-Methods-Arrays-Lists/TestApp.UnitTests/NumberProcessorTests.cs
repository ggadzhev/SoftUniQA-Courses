using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        // Arrange
        List<int> evenNumbersList = new() { 2, 4, 6 };
        List<double> expectedResult = new() { 4, 16, 36 };

        // Act
        List<double> actualResult = NumberProcessor.ProcessNumbers(evenNumbersList);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        // Arrange
        List<int> oddNumbersList = new() { 3, 5, 7, 9 };
        List<double> expectedResult = new() { Math.Sqrt(3), Math.Sqrt(5), Math.Sqrt(7), Math.Sqrt(9) }; 

        // Act
        List<double> actualResult = NumberProcessor.ProcessNumbers(oddNumbersList);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {
        // Arrange
        List<int> input = new() { 0 };
        List<int> expected = new() { 0 };

        // Act
        List<double> actualResult = NumberProcessor.ProcessNumbers(input);


        // Assert
        CollectionAssert.AreEqual(expected, actualResult);
    }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        List<int> input = new();
        List<int> expected = new();

        // Act
        List<double> actualResult = NumberProcessor.ProcessNumbers(input);


        // Assert
        CollectionAssert.AreEqual(expected, actualResult);
    }
}
