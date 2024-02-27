using NUnit.Framework;

namespace TestApp.UnitTests;

public class CalculateTests
{
    [Test]
    public void Test_AdditionWhenParamsArePositive()
    {
        // Arrange
        Calculate calculator = new();


        // Act
        int actual = calculator.Addition(5, 2);

        // Assert
        Assert.AreEqual(7, actual);
        Assert.Greater(actual, 0);
    }

    [Test]
    public void Test_AdditionWhenParamsAreNegative()
    {
        Calculate calculator = new();

        //act

        int actual = calculator.Addition(-5, -2);

        //assert

        Assert.AreEqual(-7, actual);
        Assert.Less(actual, 0);


    }

    [Test]
    public void Test_Subtraction()
    {
        Calculate calculator = new();
        //act

        int actual = calculator.Subtraction(5, 2);

        //assert
        Assert.AreEqual(3, actual);
        Assert.AreNotEqual(actual, 1, "These two objects are not equal");
        Assert.IsTrue(actual > 0);
    }
}
