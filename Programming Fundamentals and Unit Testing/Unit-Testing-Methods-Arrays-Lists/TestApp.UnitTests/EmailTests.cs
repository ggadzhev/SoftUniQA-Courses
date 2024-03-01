using NUnit.Framework;
using System.Net.Mail;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [TestCase("personal@abv.bg")]
    [TestCase("personal@gmail.com")]

    public void Test_IsValidEmail_ValidEmail(string email)
    {
        // Arrange
     

        // Act
        bool actualResult = Email.IsValidEmail(email);
       

        // Assert
        Assert.IsTrue(actualResult);
        

    }

    [TestCase("test.example com")]
    [TestCase("personal")]
    [TestCase("company@.de")]
    public void Test_IsValidEmail_InvalidEmail(string email)
    {
        bool actualResult = Email.IsValidEmail(email);

        Assert.IsFalse(actualResult);
        
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        string noEmail = " ";

        bool actualResult = Email.IsValidEmail(noEmail);

        Assert.IsFalse(actualResult);
    }
}
