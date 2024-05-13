using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] emptyInput = {string.Empty};
        string expectedresult = string.Empty;

        // Act
        string actualResult = ReverseConcatenate.ReverseAndConcatenateStrings(emptyInput);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedresult));
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        string[] singleStringArray = { "Tenet" };
        string expectedresult = "Tenet";

        // Act
        string actualResult = ReverseConcatenate.ReverseAndConcatenateStrings(singleStringArray);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedresult));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] singleStringArray = { "Test code" };
        string expectedresult = "edoctseT";

        // Act
        string actualResult = ReverseConcatenate.ReverseAndConcatenateStrings(singleStringArray);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedresult));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        // TODO: finish the test
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        // TODO: finish the test
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        // TODO: finish the test
    }
}
