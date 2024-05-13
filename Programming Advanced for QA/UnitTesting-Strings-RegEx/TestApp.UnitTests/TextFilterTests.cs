using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] noBannedWords = { };
        string text = "I am testing this code";
        string expectedResult = "I am testing this code";

        // Act
        string actualResult = TextFilter.Filter(noBannedWords, text);


        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        string[] bannedWords = { "testing"};
        string text = "I am testing this code";
        string expectedResult = "I am ******* this code";

        // Act
        string actualResult = TextFilter.Filter(bannedWords, text);


        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = { " " };
        string text = "Iamtestingthiscode";
        string expectedResult = "Iamtestingthiscode";

        // Act
        string actualResult = TextFilter.Filter(bannedWords, text);


        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        string[] bannedWords = { " " };
        string text = "I am testing this code";
        string expectedResult = "I*am*testing*this*code";

        // Act
        string actualResult = TextFilter.Filter(bannedWords, text);


        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
