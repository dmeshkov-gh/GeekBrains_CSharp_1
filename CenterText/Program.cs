using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meshkov.CS_1
{
    class CenterText
    {
        //Мешков Дмитрий

        //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        //б) Сделать задание, только вывод организуйте в центре экрана
        //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
        static void Main()
        {
            Console.Write("Введите Ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите Вашу фамилию: ");
            string lastname = Console.ReadLine();
            Console.Write("В каком городе Вы живете? ");
            string city = Console.ReadLine();
            string output = name + " " + lastname + " из города " + city;
            PrintInCenter(output);
            Console.ReadLine();
        }
        private static void PrintInCenter(string str)
        {
            int originWidth, originHeight;
            originHeight = Console.WindowHeight; // Получаем текущие размеры окна
            originWidth = Console.WindowWidth;
            Console.SetCursorPosition((originWidth / 2) - (str.Length / 2), originHeight / 2); // Задаем положение курсора 
            Console.WriteLine(str);
            Console.CursorVisible = false;
        }
    }
}
