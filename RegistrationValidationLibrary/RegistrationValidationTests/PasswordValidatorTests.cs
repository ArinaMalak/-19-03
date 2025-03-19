// PasswordValidatorTests.cs
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PasswordValidatorTests
{
    [TestMethod]
    public void ValidPassword_ShouldReturnTrue()
    {
        // Аргумент
        string validPassword = "StrongP@ssword1";

        // Действие
        bool result = PasswordValidator.IsValidPassword(validPassword);

        // Утверждение
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void InvalidPassword_ShouldReturnFalse()
    {
        // Аргумент
        string invalidPassword = "weakpassword";

        // Действие
        bool result = PasswordValidator.IsValidPassword(invalidPassword);

        // Утверждение
        Assert.IsFalse(result);
    }
}