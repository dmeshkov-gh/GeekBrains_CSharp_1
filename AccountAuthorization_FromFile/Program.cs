using System;
using System.IO;

namespace AccountAuthorization_FromFile
{
    // Мешков Дмитрий

    // Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив.
    // Создайте структуру Account, содержащую Login и Password.
    struct Account
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Account(string login, string password)
        {
            Login = login;
            Password = password;
        }
        internal void WriteToFile(string filename)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(filename))
                {
                    streamWriter.WriteLine("{0}\n{1}", Login, Password);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        internal string[] ReadFromFile(string filename)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(filename))
                {
                    string[] accessData = new string[2];
                    accessData[0] = streamReader.ReadLine();
                    accessData[1] = streamReader.ReadLine();
                    return accessData;
                }
            }
            finally { }
        }
    }
    class Program
    {
        static void Main()
        {
            Account accessData =  new Account("root", "GeekBrains");
            accessData.WriteToFile("data.txt");
            Console.WriteLine(Authorization(accessData));
            Console.ReadKey();

        }
        private static string Authorization(Account accessData)
        {
            string[] correctData = accessData.ReadFromFile("data.txt");
            string correctLogin = correctData[0];
            string correctPassword = correctData[1];

            for (int count = 3; count > 0; count--)
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();
                if (login == correctLogin && password == correctPassword)
                    return "Логин и пароль введены верно! Вы вошли в программу!";
                if (count == 1)
                    break;
                Console.WriteLine("У вас осталось {0} попытки(-ка).", count - 1);
            }
            return "Количество попыток превышено! В доступе отказано!";
        }
    }
}
