﻿using NUnit.Framework;

using System;

using TestApp.Vehicle;

namespace TestApp.UnitTests;

public class VehicleTests
{
    private Vehicles _vehicles;

    [SetUp]
    public void SetUp()
    {
        this._vehicles = new();
    }

    // TODO: finish test
    [Test]
    public void Test_AddAndGetCatalogue_ReturnsSortedCatalogue()
    {
        // Arrange
        string[] input =
        {
            "Car/Ford/Focus/120",
            "Truck/Volvo/VNL/500",
            "Car/Toyota/Camry/150"


        };

        string expected = $"Cars:{Environment.NewLine}Ford: Focus - 120hp{Environment.NewLine}Toyota: Camry - 150hp{Environment.NewLine}Trucks:{Environment.NewLine}Volvo: VNL - 500kg";

        // Act
        string result = this._vehicles.AddAndGetCatalogue(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsEmptyCatalogue_WhenNoDataGiven()
    {
        string[] input = Array.Empty<string>();

        string expected = $"Cars:{Environment.NewLine}Trucks:";

        string result = this._vehicles.AddAndGetCatalogue(input);

        Assert.That(result, Is.EqualTo(expected));


    }
}
