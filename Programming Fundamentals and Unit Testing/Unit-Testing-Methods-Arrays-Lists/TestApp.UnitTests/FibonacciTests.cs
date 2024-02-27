using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        int noInputFibonacci = 0;

        int actualResult = Fibonacci.CalculateFibonacci(noInputFibonacci);
        int expectedResult = 0;

        Assert.That(actualResult == expectedResult);

    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        int fibonacci = 7;

        int actualResult = Fibonacci.CalculateFibonacci(fibonacci);
        int expectedResult = 13;

        Assert.AreEqual(expectedResult, actualResult);
    }
}