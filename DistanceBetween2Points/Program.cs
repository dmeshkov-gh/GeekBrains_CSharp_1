using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meshkov.CS_1
{
    class DistanceBetween2Points
    {
        //Мешков Дмитрий

        //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
        //по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
        //Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
        //б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
        static void Main()
        {
            Console.WriteLine("Введите координаты 1-й точки (X1, Y1): ");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты 2-й точки (X2, Y2): ");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Расстояние между двумя точками: {0:F2}", Distance(x1, y1, x2, y2));
            Console.ReadKey();
        }

        private static double Distance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
