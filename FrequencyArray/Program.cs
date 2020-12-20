using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyArray
{
    // В частотном массиве мы как бы выворачиваем массив наизнанку.
    // В частотном массиве индексы массива соответствуют его элементам.
    // Значения - это количество элементов.
    // Поэтому нужно понять, что размер частотного массива связан с диапазоном чисел, которые мы //подсчитываем
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int N = 10;
            int[] a = new int[N];
            // Заполняем массив случайными числами
            for (int i = 0; i < N; i++)
                a[i] = rnd.Next(1, 11);
            // Выводим массив на экран
            //foreach (var v in a)
            //    Console.Write(v + " ");
            // Создаем частотный массив от 0 до 99 
            int[] mass = new int[10];
            // Подсчитываем вхождение элементов 
            foreach (var v in a) mass[v]++;//Элемент массива a является номером в частотном массиве mass
            // Находим максимальный элемент в частотном массиве
            int imax = 0;
            for (int i = 0; i < mass.Length; i++)
                if (mass[i] > mass[imax]) imax = i;
            // Выводим все элементы, которые в частотном массиве встречались то же количество раз, что и imax
            for (int i = 0; i < mass.Length; i++)
                if (mass[i] == mass[imax]) Console.WriteLine("\n" + i);
            Console.ReadKey();
        }
    }
}
