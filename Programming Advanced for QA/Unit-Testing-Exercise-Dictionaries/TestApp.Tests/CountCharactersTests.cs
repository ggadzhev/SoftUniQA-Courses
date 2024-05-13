using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string actualResult = CountCharacters.Count(input);

        // Assert
        Assert.That(actualResult, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        List<string> input = new List<string> { };

        // Act
        string actualResult = CountCharacters.Count(input);

        // Assert
        Assert.That(actualResult, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        List<string> input = new List<string> { "A" };
        string expectedResult = "A -> 1";

        // Act
        string actualResult = CountCharacters.Count(input);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        List<string> input = new List<string> { "AAA" };
        string expectedResult = "A -> 3";

        // Act
        string actualResult = CountCharacters.Count(input);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        List<string> input = new List<string> { "$$$" };
        string expectedResult = "$ -> 3";

        // Act
        string actualResult = CountCharacters.Count(input);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
