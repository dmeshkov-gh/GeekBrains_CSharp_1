using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountAuthorization_FromFile
{
    class Authorization
    {
        public static string LogIn()
        {
            FileHandler fileHandler = new FileHandler();
            fileHandler.WriteToFile("data.txt");
            string[] authorizationData = fileHandler.ReadFromFile("data.txt");

            string correctLogin = authorizationData[0];
            string correctPassword = authorizationData[1];

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
