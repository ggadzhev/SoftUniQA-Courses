using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        string result = Reverse.ReverseArray(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));

      //  throw new NotImplementedException();
    }

    
    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] oneElementArray = { 42 };
        // Act
        string actualResult = Reverse.ReverseArray(oneElementArray);
        string expectedResult = "42";

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));

       // throw new NotImplementedException();
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        // arrange

        int[] multipleElementsArray = { -10, 21, 101, 0 };

        //Act

        string actualResult = Reverse.ReverseArray(multipleElementsArray);
        string expectedResult = "0 101 21 -10";

        //arrange

        Assert.That(actualResult, Is.EqualTo(expectedResult));


        //throw new NotImplementedException();
    }
}
