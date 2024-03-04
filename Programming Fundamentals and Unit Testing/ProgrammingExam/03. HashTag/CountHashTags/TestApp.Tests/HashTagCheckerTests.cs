using NUnit.Framework;

namespace TestApp.Tests
{
    public class HashTagCheckerTests
    {
        [Test]
        public void Test_GetHashTags_ValidTextWithOneHashTag_ReturnMessageForOneHashTags()
        {
            string textOneHashtag = "#hcl";
            string expectedResult = "Only one! You know exactly what you #tag.";

            string actualResult = HashTagChecker.GetHashTags(textOneHashtag);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void Test_GetHashTags_ValidText_ReturnMessageForEvenHashTags()
        {
            string textTwoHashtag = "#hcl and #c3i";
            string expectedResult = "The text contains an even number of #tags (2 in total).";

            string actualResult = HashTagChecker.GetHashTags(textTwoHashtag);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Test_GetHashTags_ValidText_ReturnMessageForOddHashTags()
        {
            string textTwoHashtag = "#hcl and #c3i and #me";
            string expectedResult = "The text contains an odd number of #tags (3 in total).";

            string actualResult = HashTagChecker.GetHashTags(textTwoHashtag);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Test_GetHashTags_NullOrEmptyText_ReturnsErrorMessage()
        {
            string textNoHashtag = string.Empty;
            string expectedResult = "No content...";

            string actualResult = HashTagChecker.GetHashTags(textNoHashtag);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Test_GetHashTags_TestWithoutHashTags_ReturnsErrorMessage()
        {
            string textNoHashtag = "hcl and c3i and me";
            string expectedResult = "The text does not contain #tags.";

            string actualResult = HashTagChecker.GetHashTags(textNoHashtag);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

