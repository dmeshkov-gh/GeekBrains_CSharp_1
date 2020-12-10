using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meshkov.CS_1
{
    class AccessAuthorization
    {
        //Мешков Дмитрий

        //Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
        //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
        //Используя метод проверки логина и пароля, написать программу:
        //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
        //С помощью цикла do while ограничить ввод пароля тремя попытками.
        static void Main()
        {
            Console.WriteLine(Authotization());
            Pause();
        }
        private static string Authotization()
        {
            string correctLogin = "root", correctPassword = "GeekBrains";
            for(int count = 3; count > 0; count--)
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();
                if (login == correctLogin && password == correctPassword)
                    return "Логин и пароль введены верно! Вы вошли в программу!";
                if (count == 1)
                    break;
                Console.WriteLine("У вас осталось {0} попытки(-ка).", count-1);
            }
            return "Количество попыток превышено! В доступе отказано!";
        }
        private static void Pause()
        {
            Console.ReadKey();
        }
    }
}
