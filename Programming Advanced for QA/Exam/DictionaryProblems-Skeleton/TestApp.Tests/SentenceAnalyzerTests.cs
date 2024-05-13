using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class SentenceAnalyzerTests
{
    [Test]
    public void Test_Analyze_EmptyString_ReturnsEmptyDictionary()
    {
        //arrange
        string input = string.Empty;

        Dictionary<string, int> expected = new Dictionary<string, int>()
        {

        };


        //act
        var actual = SentenceAnalyzer.Analyze(input);


        //assert
        Assert.That(actual, Is.EqualTo(expected));


    }

    [Test]
    public void Test_Analyze_SingleLetter_ReturnsDictionaryWithSingleLetterEntry()
    {
        string input = "G";

        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            { "letters", 1 }
        };


        //act
        var actual = SentenceAnalyzer.Analyze(input);


        //assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_SingleDigit_ReturnsDictionaryWithSingleDigitEntry()
    {
        string input = "1";

        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            { "digits", 1 }
        };


        //act
        var actual = SentenceAnalyzer.Analyze(input);


        //assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_WholeSentence_ReturnsDictionaryWithAllSymbolTypesCount()
    {
        string input = "Georgi wrote 1-time article.";

        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            { "letters", 22 },
            { "digits", 1 },
            { "special characters", 2 },

        };


        //act
        var actual = SentenceAnalyzer.Analyze(input);


        //assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

