using System;
using System.Text.RegularExpressions;

namespace LoginChecker
{
    //    Корректным логином будет строка от 2 до 10 символов, 
    //    содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
    //    а) без использования регулярных выражений;
    //    б) с использованием регулярных выражений.
    class Login
    {
        private string _login;
        public string LogIn
        {
            get
            {
                return _login;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 10) _login = value;
                else throw new Exception("Логин должен содержать от 2 до 10 символов");
            }
        }
        public Login(string login)
        {
            if(IsCorrect(login)) LogIn = login;
        }

        private bool IsCorrect(string login) //без использования регулярных выражений
        {
            char[] letters = login.ToLower().ToCharArray();
            if (Char.IsNumber(letters[0])) throw new Exception("Логин не должен начиваться с цифры");
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] >= 'a' && letters[i] <= 'z') continue; //Содержит ли буквы латинского алфавита
                else if (Char.IsNumber(letters[i])) continue; // Содержит ли цифры
                else throw new Exception("Логин должен состоять из только из букв латинского алфавита и цифр");
            }
            Console.WriteLine("Логин введён корректно");
            return true;
        }

        private bool IsCorrectRegex(string login) //с использованием регулярных выражений
        {
            string pattern = @"^([a-z]{1})([0-9a-z]{1,9})$";
            if (Regex.IsMatch(login, pattern, RegexOptions.IgnoreCase))
            {
                Console.WriteLine("Логин корректен");
                return true;
            }
            else throw new Exception("Логин должен содержать от 2 до 10 символов - только букв латинского алфавита или цифры - но не должен начинаться с цифры");
        }
    }
}
