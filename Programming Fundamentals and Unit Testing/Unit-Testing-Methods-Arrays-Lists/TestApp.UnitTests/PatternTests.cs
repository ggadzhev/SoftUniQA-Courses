using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        int[] intsArray = new int[] { 1, 2, 3, 4, 5 };

        int[] actualResult = Pattern.SortInPattern(intsArray);
        int[] expectedResult = new int[] { 1, 5, 2, 4, 3 };

        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        int[] intsArray = Array.Empty<int>();

        int[] actualResult = Pattern.SortInPattern(intsArray);
        int[] expectedResult = Array.Empty<int>();

        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        int[] intsArray = new int[] { 100 };

        int[] actualResult = Pattern.SortInPattern(intsArray);
        int[] expectedResult = new int[] { 100 };

        Assert.AreEqual(expectedResult, actualResult);
    }
    [Test]
    public void Test_SortInPattern_RemoveDuplicates_Then_ReturnSortedArray()
    {
        int[] intsArray = new int[] { 5, 3, 4, 4, 18, 2, 2, 3, 5 };
                                    //5, 3, 4, 18, 2  - removing duplicates
                                    //2, 3, 4, 5, 18  - asc sort
                                    //2, 18, 3, 5, 4  - pattern sort

        int[] actualResult = Pattern.SortInPattern(intsArray);
        int[] expectedResult = new int[] { 2, 18, 3, 5, 4 };

        Assert.AreEqual(expectedResult, actualResult);
    }
}


