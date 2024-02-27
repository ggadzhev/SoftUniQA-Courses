using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int[] actualResult = Duplicates.RemoveDuplicates(emptyArray);
        int[] expectedResult = Array.Empty<int>();

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] noDuplicatesArray = new int[] { 1, 2, 3, 4 };

        // Act
        int[] actualResult = Duplicates.RemoveDuplicates(noDuplicatesArray);
        int[] expectedResult = new int[] { 1, 2, 3, 4 };

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
        Assert.That(actualResult.Length == expectedResult.Length);
        Assert.That(actualResult[1]  == expectedResult[1]);
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] someDuplicatesArray = new int[] { 2, 2, 3, 3, 5, 7 };

        // Act
        int[] actualResult = Duplicates.RemoveDuplicates(someDuplicatesArray);
        int[] expectedResult = new int[] { 2, 3, 5, 7};

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
        
        
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int[] allDuplicatesArray = new int[] { 2, 2, 2, 2, 2, };

        // Act
        int[] actualResult = Duplicates.RemoveDuplicates(allDuplicatesArray);
        int[] expectedResult = new int[] { 2 };

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
