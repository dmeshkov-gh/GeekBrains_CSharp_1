using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funtions
{
    public delegate double Function(double x, double y);
    class Mathematics
    {
        public static void Table(Function F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, b));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        public static double MyFunctionPow(double x, double y)
        {
            return y * Math.Pow(x, 2);

        }
        public static double MyFunctionSin(double x, double y)
        {
            return y * Math.Sin(x);
        }
    }
}
