using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationValidationLibrary
{
    public class NameValidator
    {
        public static bool IsValidName(string name)
        {
            // Проверяем, чтобы имя было непустым и содержало только допустимые символы (буквы, пробелы и дефисы)
            if (string.IsNullOrEmpty(name) || name.Length < 2)
            {
                return false;
            }

            foreach (char c in name)
            {
                if (!(char.IsLetter(c) || char.IsWhiteSpace(c) || c == '-'))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
