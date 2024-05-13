using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        string input = string.Empty;
        int position = 3;


        string actualResult = StringRotator.RotateRight(input, position);


        Assert.IsEmpty(actualResult);
        Assert.That(actualResult, Is.Empty);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        string input = "Ome si ome";
        int position = 0;
        string expectedResult = "Ome si ome";

        string actualResult = StringRotator.RotateRight(input, position);


        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        string input = "Ome si ome";
        int position = 2;
        string expectedResult = "meOme si o";

        string actualResult = StringRotator.RotateRight(input, position);


        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        string input = "Ome si ome";
        int position = -1;
        string expectedResult = "eOme si om";

        string actualResult = StringRotator.RotateRight(input, position);


        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        string input = "EmoCuck";
        int position = 11;
        string expectedResult = "CuckEmo";

        string actualResult = StringRotator.RotateRight(input, position);


        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
