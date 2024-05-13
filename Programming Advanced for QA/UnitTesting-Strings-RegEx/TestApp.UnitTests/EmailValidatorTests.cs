using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    // TODO: finish the test
    [TestCase("gadjev1@abv.bg")]
    [TestCase("gadjev123@abv.bg")]
    [TestCase("1gadzhev1@abv12.bg")]
    [TestCase("gadzhev_1@abv-tester.bg")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    // TODO: finish the test
    [TestCase("123@testingmail.")]
    [TestCase("")]
    [TestCase("testing@.com")]
    [TestCase("testing@112233$.com")]
    [TestCase("testing@1122$.com")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
