using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PairingOfNumbers
{
    class Program
    {
        //Мешков Дмитрий

        //Дан целочисленный массив из 20 элементов. 
        //Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
        //Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.

        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            FillTheArray(numbers);
            PrintArray(numbers);
            int numberOfPairs = HowMuchPairsCanBeDividedOnThree(numbers);
            Console.WriteLine();
            Console.WriteLine("Количество пар элементов массива, в которых хотя бы одно число делится на 3: " + numberOfPairs);
            Console.ReadKey();
        }

        private static void PrintArray(int[] numbers) //Метод вывода массива на консоль
        {
            foreach(int number in numbers)
                Console.Write(number + " ");
        }

        private static int HowMuchPairsCanBeDividedOnThree(int[] numbers)
        {
            int counter = 0; // Счётчик пар
            for(int i =0; i < numbers.Length-1; i++)
            {
                if (numbers[i] % 3 == 0 || numbers[i + 1] % 3 == 0)
                    counter++;
            }
            return counter;
        }

        private static void FillTheArray(int[] numbers) //Метод заполнения массива
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Random random = new Random();
                numbers[i] = random.Next(-10000, 10001);
                Thread.Sleep(50);
            }
        }
    }
}
