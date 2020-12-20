using System;
using System.IO;
using System.Collections.Generic;

namespace MinValueWithDelegates
{
    //Мешков Дмитрий

    //2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
    //а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
    //б) Используйте массив(или список) делегатов, в котором хранятся различные функции.
    //в) * Переделайте функцию Load, чтобы она возвращала массив считанных значений.Пусть она
    //возвращает минимум через параметр.
    public delegate double Function(double x);
    class Program
    {
        static List<Function> functions = new List<Function>() { Func1, Func2, Func3 };        
        public static double Func1(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double Func2(double x)
        {
            return x * x - 40 * x + 30;
        }

        public static double Func3(double x)
        {
            return x * x - 55 * x + 15;
        }

        static void Main()
        {
            Console.WriteLine("1. x * x - 50 * x + 10 \t    2. x * x - 40 * x + 30  \t 3. x * x - 55 * x + 15");
            Console.WriteLine("Введите номер функции, которую хотите вычислить:");
            try
            {
                int choice = Int32.Parse(Console.ReadLine());
                double minimalValue;
                FileHandler.SaveFuncValuesToTheFile("data.bin", functions[choice-1], -100, 100, 0.5);
                double[] loadedDoubles = FileHandler.LoadValuesFromFile("data.bin", out minimalValue);
                foreach(double d in loadedDoubles)
                {
                    Console.Write("{0} ", d);
                }
                Console.WriteLine("\nMinimal value: " + minimalValue);
            }
            catch 
            {
                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нужно ввести число от 1 до 3");
                Console.ForegroundColor = color;
            }

            Console.ReadKey();
        }

    }
}
