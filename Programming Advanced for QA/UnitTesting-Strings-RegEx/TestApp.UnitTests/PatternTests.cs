using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish the test cases
    [TestCase("test",2,"tEsTtEsT")]
    [TestCase("tes",1,"tEs")]
    [TestCase("te",3,"tEtEtE")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("", 0)]

    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException(string input,
        int repetitionFactor)
    {

        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));

    }

    [TestCase("test", -2)]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException(string input,
        int repetitionFactor)
    {
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }

    [TestCase("tes", 0)]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException(string input,
        int repetitionFactor)
    {
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }
}
