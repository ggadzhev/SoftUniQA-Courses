using NUnit.Framework;

using System.Collections.Generic;
using System.Net;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string emptyUrl = "";
        string expectedResult = "";

        // Act
        List<string> actualResult = MatchUrls.ExtractUrls(emptyUrl);

        // Assert

        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        string emptyUrl = "this is not a";
        string expectedResult = "";

        // Act
        List<string> actualResult = MatchUrls.ExtractUrls(emptyUrl);

        // Assert

        CollectionAssert.AreEqual(expectedResult, actualResult);
        Assert.That(expectedResult, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        string validUrl = "https://www.abv.bg";
        string[] expectedResult = { "https://www.abv.bg" };

        // Act
        List<string> actualResult = MatchUrls.ExtractUrls(validUrl);

        // Assert

        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        string validUrl = "https://www.abv.bg https://www.netflix.com";
        string[] expectedResult = { "https://www.abv.bg", "https://www.netflix.com" };

        // Act
        List<string> actualResult = MatchUrls.ExtractUrls(validUrl);

        // Assert

        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        string validUrl = "https://www.abv.bg?id=1484";
        string[] expectedResult = { "https://www.abv.bg?id=1484" };

        // Act
        List<string> actualResult = MatchUrls.ExtractUrls(validUrl);

        // Assert

        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}
