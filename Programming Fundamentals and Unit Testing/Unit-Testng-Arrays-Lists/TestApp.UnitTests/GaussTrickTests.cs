using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> singleElementList = new() { 25 };

        // Act
        List<int> actualResult = GaussTrick.SumPairs(singleElementList);
        List<int> expectedResult = new() { 25 };


        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        List<int> evenCountElementList = new() { 22, 22, 8, 8, };

        // Act
        List<int> actualResult = GaussTrick.SumPairs(evenCountElementList);
    
        List<int> expectedResult = new() { 30, 30 };


        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        List<int> oddCountElementList = new() { 5, 5, 10, 10, 25, };

        // Act
        List<int> actualResult = GaussTrick.SumPairs(oddCountElementList);

        List<int> expectedResult = new() { 30, 15, 10 };


        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {

        List<int> evenCountElementList = new() { 5, 5, 10, 10, 25, 25, 30, 30 };

        // Act
        List<int> actualResult = GaussTrick.SumPairs(evenCountElementList);

        List<int> expectedResult = new() { 35, 35, 35, 35 };


        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);

        //Test with more than 4 elements
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        List<int> oddCountElementList = new() { 5, 5, 10, 10, 25, 25, 30, 30, 35 }; // 40, 35, 40, 35, 25,

        // Act
        List<int> actualResult = GaussTrick.SumPairs(oddCountElementList);

        List<int> expectedResult = new() { 40, 35, 40, 35, 25 };

        CollectionAssert.AreEqual(expectedResult, actualResult);

    }
}
