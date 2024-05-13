using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        string[] emptyArray = { };
        string expectedResult = string.Empty;

        string actualResult = Orders.Order(emptyArray);

        Assert.That(actualResult, Is.EqualTo(expectedResult));



    }

    // TODO: finish test
    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] multiOrderArray = { "apple 5.97 1", "banana 3.75 1", "orange 1.98 1" };
        string expectedResult = $"apple -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98";
        // Act
        string actualResult = Orders.Order(multiOrderArray);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] multiOrderArray = { "apple 2.00 3", "banana 2.00 2", "orange 1.00 2" };
        string expectedResult = $"apple -> 6.00{Environment.NewLine}banana -> 4.00{Environment.NewLine}orange -> 2.00";
        // Act
        string actualResult = Orders.Order(multiOrderArray);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        string[] multiOrderArray = { "apple 2.00 1.5", "banana 2.00 2.5", "orange 1.00 2.5" };
        string expectedResult = $"apple -> 3.00{Environment.NewLine}banana -> 5.00{Environment.NewLine}orange -> 2.50";
        // Act
        string actualResult = Orders.Order(multiOrderArray);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
