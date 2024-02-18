using NUnit.Framework;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        //arrange
        int input = 0;

        //act
        int result = Factorial.CalculateFactorial(input);
        //assert
        Assert.AreEqual(1, result);

    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        //arrange
        int input = 3;

        //act
        int result = Factorial.CalculateFactorial(input);
        //assert
        Assert.AreEqual(6, result);
    }
}
