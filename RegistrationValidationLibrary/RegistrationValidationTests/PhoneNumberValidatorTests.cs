using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

public static class LocalPhoneNumberValidator
{
    public static bool IsValidPhoneNumber(string phoneNumber)
    {
        // Убираем лишние пробелы и дефисы для единообразия проверки
        phoneNumber = phoneNumber.Replace(" ", "").Replace("-", "");

        // Используем регулярное выражение для проверки формата +7XXXXXXXXXX
        const string pattern = @"\+7\d{10}";
        return Regex.IsMatch(phoneNumber, pattern);
    }
}

[TestClass]
public class PhoneNumberValidatorTests
{
    [TestMethod]
    public void ValidPhoneNumber_ShouldReturnTrue()
    {
        // Аргумент
        string validPhoneNumber = "+7 999 1234567";

        // Действие
        bool result = LocalPhoneNumberValidator.IsValidPhoneNumber(validPhoneNumber);

        // Утверждение
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void InvalidPhoneNumber_ShouldReturnFalse()
    {
        // Аргумент
        string invalidPhoneNumber = "abcde";

        // Действие
        bool result = LocalPhoneNumberValidator.IsValidPhoneNumber(invalidPhoneNumber);

        // Утверждение
        Assert.IsFalse(result);
    }
}