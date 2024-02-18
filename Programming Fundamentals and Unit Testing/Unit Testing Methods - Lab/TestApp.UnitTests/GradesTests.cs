using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [TestCase(2.0, "Fail")]
    [TestCase(3.0, "Average")]
    [TestCase(3.50, "Good")]
    [TestCase(4.0, "Very Good")]
    [TestCase(4.50, "Excellent")]                           //1st parameter, 2nd parameter)
        public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange
               
        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestCase(2.99, "Fail")]
    [TestCase(3.49, "Average")]
    [TestCase(3.99, "Good")]
    [TestCase(4.49, "Very Good")]
    [TestCase(4.99, "Excellent")]
    [TestCase(0, "Invalid!")]
    [TestCase(33.0, "Invalid!")]
    [TestCase(-2, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
