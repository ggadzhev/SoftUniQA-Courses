using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringModifierTests
{
    [Test]
    public void Test_Modify_EmptyString_ReturnsEmptyString()
    {
        //arrange
        string input = string.Empty;
        string expectedResult = string.Empty;

        //act
        string actualResult = StringModifier.Modify(input);


        //assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));

    }

    [Test]
    public void Test_Modify_SingleWordWithEvenLength_ReturnsUppperCaseWord()
    {
        //arrange
        string input = "georgi";
        string expectedResult = "GEORGI";

        //act
        string actualResult = StringModifier.Modify(input);


        //assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Modify_SingleWordWithOddLength_ReturnsToLowerCaseWord()
    {
        //arrange
        string input = "GEORG";
        string expectedResult = "georg";

        //act
        string actualResult = StringModifier.Modify(input);


        //assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Modify_MultipleWords_ReturnsModifiedString()
    {
        //arrange
        string input = "georgi is READY";
        string expectedResult = "GEORGI IS ready";

        //act
        string actualResult = StringModifier.Modify(input);


        //assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}

