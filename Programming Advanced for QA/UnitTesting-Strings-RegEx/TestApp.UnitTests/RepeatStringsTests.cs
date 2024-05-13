using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class RepeatStringsTests
{
    [Test]
    public void Test_Repeat_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();
        string expectedResult = string.Empty;

        // Act
        string actualResult = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Repeat_SingleInputString_ReturnsRepeatedString()
    {
        string[] input = {"one"};
        string expectedResult = "oneoneone";

        // Act
        string actualResult = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Repeat_MultipleInputStrings_ReturnsConcatenatedRepeatedStrings()
    {
        string[] input = new string[] { "one two" };
        string expectedResult = "one twoone twoone twoone twoone twoone twoone two";

        // Act
        string actualResult = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
