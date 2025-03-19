using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PasswordValidator
{
    public static bool IsValidPassword(string password)
    {
        // Пароль должен быть длиной от 8 до 20 символов, содержать заглавные и строчные буквы, цифры и специальные символы
        if (string.IsNullOrEmpty(password) || password.Length < 8 || password.Length > 20)
        {
            return false;
        }

        bool hasUpperCase = password.Any(char.IsUpper);
        bool hasLowerCase = password.Any(char.IsLower);
        bool hasDigit = password.Any(char.IsDigit);
        bool hasSpecialChar = password.Any(c => "!@#$%^&*()_+=-.,?/{}[]~`\"!@#$%^&*();<>?,./".Contains(c)); 

        return hasUpperCase && hasLowerCase && hasDigit && hasSpecialChar;
    }
}