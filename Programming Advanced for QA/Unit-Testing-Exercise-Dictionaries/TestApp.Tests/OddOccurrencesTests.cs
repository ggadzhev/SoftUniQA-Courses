using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        string[] emptyArray = Array.Empty<string>();
        string expectedResult = string.Empty;

        string actualResult = OddOccurrences.FindOdd(emptyArray);

        Assert.That(actualResult, Is.EqualTo(expectedResult));


    }

    // TODO: finish test
    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        string[] noOddOccurrancesArray = { "one", "one", "two", "two"};
        string expectedResult = string.Empty;

        string actualResult = OddOccurrences.FindOdd(noOddOccurrancesArray);

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        string[] noOddOccurrancesArray = { "one", "two", "two" };
        string expectedResult = "one";

        string actualResult = OddOccurrences.FindOdd(noOddOccurrancesArray);

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        string[] noOddOccurrancesArray = { "one", "two" };
        string expectedResult = "one two";

        string actualResult = OddOccurrences.FindOdd(noOddOccurrancesArray);

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        string[] noOddOccurrancesArray = { "one", "two", "two", "ONE", "One" };
        string expectedResult = "one";

        string actualResult = OddOccurrences.FindOdd(noOddOccurrancesArray);

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
