using System;

namespace Meshkov.CS_1
{
    class SwapInts
    {
        //Мешков Дмитрий

        //Написать программу обмена значениями двух переменных.
        //а) с использованием третьей переменной;
        //б) *без использования третьей переменной.
        static void Main()
        {
            Console.Write("Введите X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите Y: ");
            int y = int.Parse(Console.ReadLine());
            Swap(ref x, ref y); //Значения передаются по ссылке
            Console.WriteLine("Меняем значения X и Y: X = {0}, Y = {1}", x, y);
            Console.ReadKey();
        }

        private static void Swap(ref int x, ref int y) //Без использования третьей переменной
        {
            x = x + y;
            y = x - y;
            x = x - y;
        }

        //private static void Swap(ref int x, ref int y) //C использованией третьей переменной
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
    }
}
