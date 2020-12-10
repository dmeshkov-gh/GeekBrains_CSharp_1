using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    //Мешков Дмитрий

    // Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
    // Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
    // Написать программу, демонстрирующую все разработанные элементы класса.
    // **Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение - ArgumentException("Знаменатель не может быть равен 0");
    // **Добавить упрощение дробей.
    class Program
    {
        static void Main()
        {
            Fraction A = new Fraction(GetNumAndDenomFromConsole());
            Fraction B = new Fraction(GetNumAndDenomFromConsole());
            A.Sum(B);
            A.Deduct(B);
            A.Multiply(B);
            A.Divide(B);
            Console.ReadKey();
        }
        private static (int num, int denom) GetNumAndDenomFromConsole() // Метод, который позволяет задать числитель и знаменатель с консоли
        {
            int numerator = GetNumber("числитель");
            int denumerator = GetNumber("знаменатель");
            var result = (numerator, denumerator); //Возвращаем из метода кортеж (int, int)
            return result;
        }

        private static int GetNumber(string str)
        {
            string input;
            int number;
            bool isNumber;
            do
            {
                Console.Write("Введите " + str + " дроби: ");
                input = Console.ReadLine();
                isNumber = Int32.TryParse(input, out number);
                if (!isNumber)
                {
                    Console.WriteLine("Необходимо ввести целочисленное положительное значение!");
                }
            }
            while (!isNumber);
            return number;
        }
    }
}
