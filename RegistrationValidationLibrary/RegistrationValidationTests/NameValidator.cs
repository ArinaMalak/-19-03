using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistrationValidationLibrary; // Здесь должно быть ваше конкретное пространство имен

[TestClass]
public class NameValidatorTests
{
    [TestMethod]
    public void ValidName_ShouldReturnTrue()
    {
        // Аргумент
        string validName = "Ivan Ivanov";

        // Действие
        bool result = NameValidator.IsValidName(validName);

        // Утверждение
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void InvalidName_ShouldReturnFalse()
    {
        // Аргумент
        string invalidName = "123";

        // Действие
        bool result = NameValidator.IsValidName(invalidName);

        // Утверждение
        Assert.IsFalse(result);
    }
}