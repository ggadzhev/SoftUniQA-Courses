using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        List<int> oneElementArray = new() { 110 };

        int actualResult = MaxNumber.FindMax(oneElementArray);
        int expectedResult = 110;

        Assert.That(expectedResult == actualResult);


    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        List<int> oneElementArray = new() { 10, 20, 30 };

        int actualResult = MaxNumber.FindMax(oneElementArray);
        int expectedResult = 30;

        Assert.That(expectedResult == actualResult);
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        List<int> oneElementArray = new() { -10, -20, -30 };

        int actualResult = MaxNumber.FindMax(oneElementArray);
        int expectedResult = -10;

        Assert.That(expectedResult == actualResult);
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        List<int> oneElementArray = new() { -10, 25, -30, 0 };

        int actualResult = MaxNumber.FindMax(oneElementArray);
        int expectedResult = 25;

        Assert.That(expectedResult == actualResult);
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        List<int> oneElementArray = new() { -10, 25, -30, 25 };

        int actualResult = MaxNumber.FindMax(oneElementArray);
        int expectedResult = 25;

        Assert.That(expectedResult == actualResult);

        
    }
}
