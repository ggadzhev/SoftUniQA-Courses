using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        char[] chars = { '0', '1', 'a' };

        char[] actualResult = Fake.RemoveStringNumbers(chars);
        char[] expectedResult = { 'a' };

        Assert.AreEqual(expectedResult, actualResult);

    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        char[] noDigitsCharsArray = { '#', 'a', '+' };
            
        char[] actualResult = Fake.RemoveStringNumbers(noDigitsCharsArray);
        char[] expectedResult = { '#', 'a', '+' };

        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        char[] noDigitsCharsArray = Array.Empty<char>();

        char[] actualResult = Fake.RemoveStringNumbers(noDigitsCharsArray);
        char[] expectedResult = Array.Empty<char>();

        Assert.AreEqual(expectedResult, actualResult);
    }
}
