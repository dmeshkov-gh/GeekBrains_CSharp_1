using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meshkov.CS_1
{
    class GoodNumbers
    {
        //Дмитрий Мешков

        //*Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
        //Хорошим называется число, которое делится на сумму своих цифр.
        //Реализовать подсчет времени выполнения программы, используя структуру DateTime.
        static void Main()
        {
            DateTime start = DateTime.Now;
            int number = 1000000000;
            DateTime finish = DateTime.Now;
            TimeSpan timeSpan = finish - start;
            Console.WriteLine("Количество 'хороших' чисел: {0}", CountGoodNumbers(number));
            Console.WriteLine("Время выполнения программы {0}", timeSpan);
            Console.ReadKey();
        }
        private static int CountGoodNumbers(int number)
        {
            int count = 0; // Cчётчик
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int j = i;
                while (j > 0)
                {
                    sum += j % 10;
                    j /= 10;
                }
                if (i%sum == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
