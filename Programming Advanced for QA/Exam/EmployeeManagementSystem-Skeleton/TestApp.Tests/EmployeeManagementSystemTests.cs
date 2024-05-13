using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class EmployeeManagementSystemTests
{
    [Test]
    public void Test_Constructor_CheckInitialEmptyEmployeeCollectionAndCount()
    {
        //arrange 
        EmployeeManagementSystem employees = new();
        int expected = 0;

        //act

        var result = employees.GetAllEmployees();

        //assert
        Assert.That(result.Count, Is.EqualTo(expected));

    }

    [Test]
    public void Test_AddEmployee_ValidEmployeeName_AddNewEmployee()
    {
        EmployeeManagementSystem employees = new();
        employees.AddEmployee("Georgi");

        //act

        var result = employees.GetAllEmployees();

        //assert
        Assert.That(result.Count, Is.EqualTo(employees.EmployeeCount));
    }

    [Test]
    [TestCase(" ")]
    [TestCase(null)]
    public void Test_AddEmployee_NullOrEmptyEmployeeName_ThrowsArgumentException(string employeeName)
    {
        EmployeeManagementSystem employees = new();
        

        //act

        //assert
        Assert.Throws<ArgumentException>(() => employees.AddEmployee(employeeName));
    }

    [Test]
    public void Test_RemoveEmployee_ValidEmployeeName_RemoveFirstEmployeeName()
    {
        EmployeeManagementSystem employees = new();
        employees.AddEmployee("Georgi");
        employees.AddEmployee("Emo");
        employees.AddEmployee("BatMancho");
        employees.AddEmployee("Galin");

        //expectedEmployeeCount = 3;

        //act
        employees.RemoveEmployee("Georgi");
        var result = employees.GetAllEmployees();

        //assert

        Assert.That(result.Count, Is.EqualTo(employees.EmployeeCount)); 
    }

    [Test]
    [TestCase(" ")]
    [TestCase(null)]
    public void Test_RemoveEmployee_NullOrEmptyEmployeeName_ThrowsArgumentException(string employeeName)
    {
        EmployeeManagementSystem employees = new();
        employees.AddEmployee("Georgi");
        employees.AddEmployee("Emo");
        employees.AddEmployee("BatMancho");
        employees.AddEmployee("Galin");


        //act
     

        //assert
        Assert.Throws<ArgumentException>(() => employees.RemoveEmployee(employeeName));
    }

    [Test]
    public void Test_GetAllEmployees_AddedAndRemovedEmployees_ReturnsExpectedEmployeeCollection()
    {
        EmployeeManagementSystem employees = new();
        employees.AddEmployee("Georgi");
        employees.AddEmployee("Emo");
        employees.AddEmployee("BatMancho");
        employees.AddEmployee("Galin");

        //expectedEmployeeCount = 2
       
        List<string> expectedEmployees = new List<string> { "BatMancho", "Galin" };;

        //act
        employees.RemoveEmployee("Georgi");
        employees.RemoveEmployee("Emo");
       

        //assert

        CollectionAssert.AreEqual(expectedEmployees, employees.GetAllEmployees());
    }   
}

