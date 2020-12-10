using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meshkov.CS_1
{
    class Questionary
    {
        //Мешков Дмитрий

        //Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). 
        //В результате вся информация выводится в одну строчку.
        //а) используя склеивание;
        //б) используя форматированный вывод;
        //в) *используя вывод со знаком $.
        static void Main()
        {
            Console.Write("Введите Ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите Вашу фамилию: ");
            string lastname = Console.ReadLine();
            Console.Write("Введите Ваш возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Введите Ваш рост: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Введите Ваш вес: ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Имя: " + name + "\nФамилия: " + lastname                         //Склеивание
                + "\nВозраст: " + age + "\nРост: " + height + "\nВес: " + weight);
            Console.WriteLine("Имя: {0} \nФамилия: {1} \nВозраст: {2} \nРост: {3} \nВес: {4}", //Форматирование
                name, lastname, age, height, weight);
            Console.WriteLine($"Имя: {name} \nФамилия: {lastname} \nВозраст: {age} " +          //Интерполяция
                $"\nРост: {height} \nВес: {weight}");  
            Console.ReadLine();
        }
    }
}
