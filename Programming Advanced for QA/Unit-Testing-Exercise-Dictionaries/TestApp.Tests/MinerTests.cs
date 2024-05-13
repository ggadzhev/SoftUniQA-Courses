using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        string[] emptyArray = { };
        string expectedResult = string.Empty;

        string actualResult = Miner.Mine(emptyArray);
        
        Assert.AreEqual(expectedResult, actualResult);

    }

    // TODO: finish test
    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] mixedResources = { "gold 8", "SILVER 30" };
        string expectedResult = $"gold -> 8{Environment.NewLine}silver -> 30";

        string result = Miner.Mine(mixedResources);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        string[] mixedResources = { "metal 8", "zinc 20", "zinc 10" };
        string expectedResult = $"metal -> 8{Environment.NewLine}zinc -> 30";

        string result = Miner.Mine(mixedResources);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
