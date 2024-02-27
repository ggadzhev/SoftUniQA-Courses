using NUnit.Framework;
using System.Net.Mail;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [TestCase("test@example.com")]
    [TestCase("personal@abv.bg")]
    [TestCase("company@company-name.de")]
    public void Test_IsValidEmail_ValidEmail(string email)
    {
        // Arrange
     

        // Act
        bool actualResult = Email.IsValidEmail(email);
       

        // Assert
        Assert.IsTrue(actualResult);
        Assert.AreEqual(true, actualResult);

    }

    [TestCase("test.example com")]
    [TestCase("personal")]
    [TestCase("company@.de")]
    public void Test_IsValidEmail_InvalidEmail(string email)
    {
        bool actualResult = Email.IsValidEmail(email);

        Assert.IsFalse(actualResult);
        Assert.AreEqual(false, actualResult);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        string noEmail = " ";

        bool actualResult = Email.IsValidEmail(noEmail);

        Assert.IsFalse(actualResult);
    }
}
