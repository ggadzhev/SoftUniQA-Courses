using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string reversedString = string.Empty;
        string expectedResult = string.Empty;
       

        // Act
        string actualResult = StringReverse.Reverse(reversedString);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestCase("a", "a")]
    [TestCase("$", "$")]
    [TestCase("A", "A")]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter(string input, string expectedResult)
    {

        //act

        string actual = StringReverse.Reverse(input);

        //assert

        Assert.AreEqual(expectedResult, actual);
       
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        string input = "test";
        string expectedResult = "tset";

        string actual = StringReverse.Reverse(input);

        Assert.AreEqual(expectedResult, actual);
        Assert.AreNotEqual(expectedResult, actual);
        Assert.AreEqual(input.Length, actual.Length);
        Assert.IsNotEmpty(actual);
        
    }
}
