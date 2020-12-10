using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meshkov.CS_1
{
    class Recursion
    {
        //Мешков Дмитрий

        //a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
        //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Numbers(a, b);
            Console.WriteLine();
            Console.WriteLine(Sum(a, b));
            Console.ReadLine();

        }
        static int sum = 0; //Переменная для хранения суммы
        private static int Sum(int a, int b) // Задание б)
        {
            if (a == b)
            {
                return sum += b;
            }
            else
            {
                sum += a;
                a++;
                return Sum(a, b);
            }
        }

        private static void Numbers(int a, int b) // Задание а)
        {
            if (a == b)
            {
                Console.Write(b);
            }
            else
            {
                Console.Write(a + " ");
                a++;
                Numbers(a, b);
            }
        }
    }
}
