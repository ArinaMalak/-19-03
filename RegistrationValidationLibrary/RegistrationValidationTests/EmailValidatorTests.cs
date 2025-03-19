using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class EmailValidatorTests
{
    [TestMethod]
    public void ValidEmail_ShouldReturnTrue()
    {
        // Аргумент
        string validEmail = "test@example.com";

        // Действие
        bool result = EmailValidator.IsValidEmail(validEmail);

        // Утверждение
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void InvalidEmail_ShouldReturnFalse()
    {
        // Аргумент
        string invalidEmail = "invalidemail";

        // Действие
        bool result = EmailValidator.IsValidEmail(invalidEmail);

        // Утверждение
        Assert.IsFalse(result);
    }
}