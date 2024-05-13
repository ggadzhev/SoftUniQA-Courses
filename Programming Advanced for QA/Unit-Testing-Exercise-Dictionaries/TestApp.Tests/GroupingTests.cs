using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{
    // TODO: finish test
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string actualResult = Grouping.GroupNumbers(emptyList);

        // Assert
        Assert.That(actualResult, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {

        List<int> evenOddList = new List<int>() { 4, 5, 2, 3 };
        string expectedResult = "Even numbers: 4, 2\r\nOdd numbers: 5, 3";

        string actualResult = Grouping.GroupNumbers(evenOddList);

        Assert.That(actualResult, Is.EqualTo(expectedResult));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        List<int> evenOddList = new List<int>() { 4, 6, 2, 8 };
        string expectedResult = "Even numbers: 4, 6, 2, 8";

        string actualResult = Grouping.GroupNumbers(evenOddList);

        Assert.That(actualResult, Is.EqualTo(expectedResult));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        List<int> evenOddList = new List<int>() { 9, 7, 3 };
        string expectedResult = "Odd numbers: 9, 7, 3";

        string actualResult = Grouping.GroupNumbers(evenOddList);

        Assert.That(actualResult, Is.EqualTo(expectedResult));

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        List<int> evenOddList = new List<int>() { -2, -4, -8,};
        string expectedResult = "Even numbers: -2, -4, -8";

        string actualResult = Grouping.GroupNumbers(evenOddList);

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
