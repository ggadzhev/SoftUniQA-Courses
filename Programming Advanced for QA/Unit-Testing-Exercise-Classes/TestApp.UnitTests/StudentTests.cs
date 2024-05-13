﻿using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class StudentTests
{
    private Student _student;

    [SetUp]
    public void SetUp()
    {
        this._student = new();
    }

    // TODO: finish test
    [Test]
    public void Test_AddAndGetByCity_ReturnsStudentsInCity_WhenCityExists()
    {
        // Arrange
        string[] students = { "John Doe 25 Sofia", "Jane Smith 22 Varna", "Alice Johnson 20 Sofia" };
        string expected = $"John Doe is 25 years old.{Environment.NewLine}Alice Johnson is 20 years old.";

        // Act

        string actualResult = this._student.AddAndGetByCity(students, "Sofia");

        // Assert
        Assert.That(actualResult, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetByCity_ReturnsEmptyString_WhenCityDoesNotExist()
    {
        // Arrange
        string[] students = { "John Doe 25 Sofia", "Jane Smith 22 Varna", "Alice Johnson 20 Sofia" };
        string expected = string.Empty;

        // Act

        string actualResult = this._student.AddAndGetByCity(students, "Ihtiman");

        // Assert
        Assert.That(actualResult, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetByCity_ReturnsEmptyString_WhenNoStudentsGiven()
    {
        string[] students = Array.Empty<string>();
        string expected = string.Empty;

        // Act

        string actualResult = this._student.AddAndGetByCity(students, "Ihtiman");

        // Assert
        Assert.That(actualResult, Is.EqualTo(expected));
    }
}
