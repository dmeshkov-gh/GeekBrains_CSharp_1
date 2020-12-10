using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meshkov.CS_1
{
    class MinNumber
    {
        //Мешков Дмитрий

        //Написать метод, возвращающий минимальное из трех чисел.
        static void Main()
        {
            Console.WriteLine("Введите 3 числа: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int min = MinValue( a,  b,  c);
            Console.WriteLine($"Минимальное число из {a}, {b}, {c}: {min}");
            Console.ReadKey();
        }
        private static int MinValue( int a, int b, int c)
        {
            int min = a;
            if(min > b)
                min = b;
            if(min > c)
                min = c;
            return min;
        }
    }
}
