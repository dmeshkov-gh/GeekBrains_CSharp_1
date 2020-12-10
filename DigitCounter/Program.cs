using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meshkov.CS_1
{
    class DigitCounter
    {
        //Мешков Дмитрий
        //Написать метод подсчета количества цифр числа.
        static void Main()
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            int count = CountDigits(number);
            Print($"Количество цифр в числе {number}: {count}");
            Pause();
        }
        private static void Print(string str)
        {
            Console.WriteLine(str);
        }

        private static void Pause()
        {
            Console.ReadKey();
        }
        private static int CountDigitsLog(int number) // Решение задачи через десятичный логарифм
        {
            if (number % 10 == 0)
                return ((int)Math.Ceiling(Math.Log10(number))) + 1;
            else
                return (int)Math.Ceiling(Math.Log10(number));
        }

        private static int CountDigits(int number) // Решение задачи через цикл
        {
            int count = 1;  //Счётчик чисел. В любом числе есть минимум одна цифра.
            for (int i = 0; number >= 10; i++)
            {
                count++;
                number /= 10;
            }
            return count;
        }

    }
}
