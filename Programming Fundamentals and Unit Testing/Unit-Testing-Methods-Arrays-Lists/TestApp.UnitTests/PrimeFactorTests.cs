using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        long primeNumber = 7;
        long expectedResult = 7;

        long actualResult = PrimeFactor.FindLargestPrimeFactor(primeNumber);

        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        long primeNumber = 100;
        long expectedResult = 5;

        long actualResult = PrimeFactor.FindLargestPrimeFactor(primeNumber);

        Assert.AreEqual(expectedResult, actualResult);
    }
}
