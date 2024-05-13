using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class SubstringExtractorTests
{
    [Test]
    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
    {
        string input = "Georgi";
        string start = "G";
        string end = "i";

        string expected = "eorg";

        string actualResult = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        Assert.That(actualResult, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
    {
        string input = "Georgi";
        string start = "01";
        string end = "i";

        string expected = "Substring not found";

        string actualResult = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        Assert.That(actualResult, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
    {
        string input = "Georgi";
        string start = "Ge";
        string end = "01";

        string expected = "Substring not found";

        string actualResult = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        Assert.That(actualResult, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
    {
        string input = "Georgi";
        string start = "11";
        string end = "12";

        string expected = "Substring not found";

        string actualResult = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        Assert.That(actualResult, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
    {
        string input = "";
        string start = "Ge";
        string end = "gi";

        string expected = "Substring not found";

        string actualResult = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        Assert.That(actualResult, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
    {
        string input = "";
        string start = "or";
        string end = "or";

        string expected = "Substring not found";

        string actualResult = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        Assert.That(actualResult, Is.EqualTo(expected));
    }
}
