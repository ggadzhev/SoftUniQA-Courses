using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class FoldSumTests
{
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, "5 5 13 13")] //2+3 1+4 5+8 6+7
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "7 7 7 19 19 19")]
    [TestCase(new int[] { 1, 1, 1, 1 }, "2 2")]
    [TestCase(new int[] { 1, -2, 3, -4, 5, -6, 7, -8 }, "1 -3 -3 1")]
    [TestCase(new int[] { -1, -2, -3, -4 }, "-3 -7")]
    public void Test_FoldArray_ReturnsCorrectString(int[] arr, string expected)
    {
        string actualResult = FoldSum.FoldArray(arr);

        Assert.AreEqual(expected, actualResult);
    }
}
