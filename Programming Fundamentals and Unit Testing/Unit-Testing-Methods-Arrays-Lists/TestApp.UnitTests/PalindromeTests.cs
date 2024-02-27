using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> validPalindrome = new() { "Tenet" };
        

        // Act
        bool actualResult = Palindrome.IsPalindrome(validPalindrome);

        // Assert
        Assert.IsTrue(actualResult);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> emptyList = new();
        

        // Act
        bool actualResult = Palindrome.IsPalindrome(emptyList);

        // Assert
        Assert.IsTrue(actualResult);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> randomWord = new() { "zaraz" };
        

        // Act
        bool actualResult = Palindrome.IsPalindrome(randomWord);

        // Assert
        Assert.IsTrue(actualResult);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        List<string> notPalindrome = new() { "Something" };


        // Act
        bool actualResult = Palindrome.IsPalindrome(notPalindrome);

        // Assert
        Assert.IsFalse(actualResult);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        List<string> notPalindrome = new() { "TeNeT" };


        // Act
        bool actualResult = Palindrome.IsPalindrome(notPalindrome);

        // Assert
        Assert.IsTrue(actualResult);
    }
}
