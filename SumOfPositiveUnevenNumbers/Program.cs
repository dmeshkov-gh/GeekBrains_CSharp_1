using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPositiveUnevenNumbers
{
    //Мешков Дмитрий

    //а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
    //    Требуется подсчитать сумму всех нечетных положительных чисел.
    //    Сами числа и сумму вывести на экран, используя tryParse;
    //б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
    //    При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;
    class Program
    {
        static void Main()
        {
            int result = 0;
            bool IsZero = false;
            Console.WriteLine("Введите число и нажмите Enter. Для прерывания программы введите '0'");
            while (!IsZero)
            {
                string input = Console.ReadLine();
                bool IsNumber = Int32.TryParse(input, out int number);
                if (IsNumber)
                {
                    if (number == 0)
                    {
                        IsZero = true;
                    }
                    if (number > 0 && number % 2 != 0)
                    {
                        result += number;
                    }
                }
                else
                {
                    throw new Exception("Необходимо вводить численные значения");
                }
            }
            Console.WriteLine("Сумма всех нечетных положительных чисел: " + result);
            Console.ReadLine();
        }
    }
}
