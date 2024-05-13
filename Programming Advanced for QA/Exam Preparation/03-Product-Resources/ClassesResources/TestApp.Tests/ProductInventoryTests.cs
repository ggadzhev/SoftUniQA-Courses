using NUnit.Framework;
using System;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        //arrange
        string productName = "orange";
        double productPrice = 5;
        int productQuantity = 2;

        string expectedResult = $"Product Inventory:{Environment.NewLine}" +
            $"orange - Price: $5.00 - Quantity: 2";



        //act
        _inventory.AddProduct(productName, productPrice, productQuantity);
        string output = _inventory.DisplayInventory();


        //assert
        Assert.That(expectedResult, Is.EqualTo(output));

    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        //arrange
        string productName = "orange";
        string productName2 = "mango";
        double productPrice = 5;
        double productPrice2 = 3;
        int productQuantity = 2;
        int productQuantity2 = 4;

        string expectedResult = $"Product Inventory:{Environment.NewLine}" +
            $"orange - Price: $5.00 - Quantity: 2{Environment.NewLine}" +
            $"mango - Price: $3.00 - Quantity: 4";




        //act
        _inventory.AddProduct(productName, productPrice, productQuantity);
        string output = _inventory.DisplayInventory();


        //assert
        Assert.That(expectedResult, Is.EqualTo(output));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // TODO: finish the test
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // TODO: finish the test
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // TODO: finish the test
    }
}
