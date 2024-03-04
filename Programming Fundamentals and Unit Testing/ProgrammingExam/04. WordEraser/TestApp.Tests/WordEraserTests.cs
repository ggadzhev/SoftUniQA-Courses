using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class WordEraserTests
{
    [Test]
    public void Test_Erase_EmptyWordsList_ShouldReturnEmptyString() // празен лист който трябва да върне празен стринг - може с " " или с empty.String
    {
        List<string> emptyList = new List<string>();
        string eraserWord = string.Empty;
        string expectedResult = string.Empty;

        string actualResult = WordEraser.Erase(emptyList, eraserWord);
        // Act
       

        // Assert
        Assert.AreEqual(expectedResult, actualResult);

    }

    [Test]
    public void Test_Erase_NullWordsList_ShouldReturnEmptyString() // нулев лист (null) който трябва да върне празен стринг (string.Empty)
    {
        List<string> emptyList = null;
        string eraserWord = null;
        string expected = string.Empty;

        //Act
        string actualResult = WordEraser.Erase(emptyList, eraserWord);
        // Act

        // Assert
        Assert.AreEqual(expected, actualResult);
    }

    [Test]
    public void Test_Erase_NullOrEmptyWordToErase_ShouldReturnStringOfGivenWordsList() // нулев или празен лист който трябва да върне лист със всички останали думи който не са нулл или празен стринг
    {
        List<string> emptyList = new List<string>() { "test","test","one", null };
        string eraserWord = null;
        string expectedResult = "test test one ";

        // Act
        string actualResult = WordEraser.Erase(emptyList, eraserWord);
        // Act

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_Erase_ValidInput_ShouldReturnEmptyString_WhenAllWordsMatchedTheWordToErase() // лист от думи, трябва да върне празен лист като всички думи трябва да бъдат изтрити
    {
        List<string> emptyList = new List<string>() { "test", "test", "test" };
        string eraserWord = "test";
        string expectedResult = string.Empty;

        string actualResult = WordEraser.Erase(emptyList, eraserWord);
        // Act

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_Erase_ValidInput_ShouldReturnStringWithoutErasedWords_WhenFewOfWordsMatchedWordToArese() // лист със думи който не трябва да бъдат изтривани 
    {
        List<string> emptyList = new List<string>() { "two", "One", "two", "two", "One" };
        string eraserWord = "one"; ;
        string expectedResult = "two One two two One";

        string actualResult = WordEraser.Erase(emptyList, eraserWord);
        // Act

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}

