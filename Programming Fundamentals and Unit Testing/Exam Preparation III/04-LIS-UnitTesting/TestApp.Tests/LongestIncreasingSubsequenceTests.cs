using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        int[] nullArray = null;

        Assert.That(() => LongestIncreasingSubsequence.GetLis(nullArray), Throws.ArgumentNullException);
        
       
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        int[] emptyArray = new int[0];

        string expectedResult = string.Empty;

        string actualResult = LongestIncreasingSubsequence.GetLis(emptyArray);

        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        int[] emptyArray = new int[] {2};

        string expectedResult = "2";

        string actualResult = LongestIncreasingSubsequence.GetLis(emptyArray);

        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        int[] emptyArray = new int[] { 3, 2, 1, 7, 9 };

        string expectedResult = "3 7 9";

        string actualResult = LongestIncreasingSubsequence.GetLis(emptyArray);

        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }



    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        int[] emptyArray = new int[] { 1, 3, 5, 7, 9 };

        string expectedResult = "1 3 5 7 9";

        string actualResult = LongestIncreasingSubsequence.GetLis(emptyArray);

        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }
}
