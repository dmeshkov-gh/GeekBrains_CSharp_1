using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddPositiveNumbers
{
    class Program
    {
        //Мешков Дмитрий

        //С клавиатуры вводятся числа, пока не будет введен 0. 
        //Подсчитать сумму всех нечетных положительных чисел.
        static void Main()
        {
            Console.WriteLine("Сумма всех нечетных положительных чисел: {0}", OddPositiveNumbers());
            Pause();
        }

        private static void Pause()
        {
            Console.ReadKey();
        }

        private static int OddPositiveNumbers()
        {
            Console.WriteLine("Программа подсчитывает сумму всех нечетных положительных чисел. Для прерывания программы введите 0. " +
                "\nВведите число и нажмите клавишу Enter: ");
            int number;
            int sum = 0;
            do
            {
                number = int.Parse(Console.ReadLine());
                if (number > 0 && number % 2 != 0)
                {
                    sum += number;
                }
            }
            while (number != 0);
            return sum;
        }
    }
}
