using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("", actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        string input = "a";

        //act

        string actual = StringReverse.Reverse(input);

        //assert

        Assert.AreEqual("a", actual);
        Assert.AreEqual(1, actual.Length);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        string input = "test";

        string actual = StringReverse.Reverse(input);

        Assert.AreEqual("tset", actual);
        Assert.AreNotEqual("test", actual);
        Assert.AreEqual(input.Length, actual.Length);
        Assert.IsNotEmpty(actual);
        
    }
}
