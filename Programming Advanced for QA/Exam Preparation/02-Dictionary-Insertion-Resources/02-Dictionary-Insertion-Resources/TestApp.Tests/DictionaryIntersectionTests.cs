using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        //arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        Dictionary<string, int> dict2 = new Dictionary<string, int>();
        Dictionary<string, int> expected = new Dictionary<string, int>();

        //act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //assert

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        //arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {
            {"dog", 1},
            {"cat", 2},
            {"pigeon", 3},
            {"rabbit", 4}
        };
        Dictionary<string, int> dict2 = new Dictionary<string, int>();
        Dictionary<string, int> expected = new Dictionary<string, int>();

        //act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //assert

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {
            {"dog", 1},
            {"cat", 2},
            {"pigeon", 3},
            {"rabbit", 4}
        };
        Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            {"puppy", 12 },
            {"young", 13 },
            {"old", 14 },
            {"sick", 15 }
        };
        Dictionary<string, int> expected = new();

        //act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //assert

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {
            {"dog", 1},
            {"cat", 2},
            {"pigeon", 3},
            {"rabbit", 4}
        };
        Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            {"puppy", 12 },
            {"cat", 2 },
            {"old", 14 },
            {"rabbit", 4 }
        };
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            {"cat", 2 },
            { "rabbit", 4 }
        };

        //act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //assert

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {
            {"dog", 1},
            {"cat", 2},
            {"pigeon", 3},
            {"rabbit", 4}
        };
        Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            {"puppy", 12 },
            {"pigeon", 14 },
            {"rabbit", 15 }
        };
        Dictionary<string, int> expected = new();


        //act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //assert

        Assert.That(result, Is.EqualTo(expected));
    }
}
