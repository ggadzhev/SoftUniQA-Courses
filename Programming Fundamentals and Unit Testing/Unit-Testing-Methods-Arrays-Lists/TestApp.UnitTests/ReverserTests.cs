using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        string[] inputArray = Array.Empty<string>();

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        // Arrange
        string[] singleStringArray = new string[] { "Inception" };

        // Act
        string[] actualResult = Reverser.ReverseStrings(singleStringArray);
        string[] expectedResult = new string[] { "noitpecnI" };

        // Assert

        Assert.That(actualResult, Is.EqualTo(expectedResult));
        
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        string[] multiStringArray = new string[] { "Happy", "Sunday" };

        // Act
        string[] actualResult = Reverser.ReverseStrings(multiStringArray);
        string[] expectedResult = new string[] { "yppaH", "yadnuS" };

        // Assert

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        string[] charStringArray = new string[] { "M@d", "$ollar" };

        // Act
        string[] actualResult = Reverser.ReverseStrings(charStringArray);
        string[] expectedResult = new string[] { "d@M", "rallo$" };

        // Assert

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
