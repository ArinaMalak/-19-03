using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PhoneNumberValidator
{
    public static bool IsValidPhoneNumber(string phoneNumber)
    {
        // Проверяем, чтобы номер состоял только из цифр и имел длину от 10 до 15 символов
        if (string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length < 10 || phoneNumber.Length > 15)
        {
            return false;
        }

        foreach (char c in phoneNumber)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }

        return true;
    }
}
