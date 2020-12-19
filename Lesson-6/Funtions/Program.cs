using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funtions
{
    //Мешков Дмитрий

    //1. Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double). 
    //Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).

    class Program
    {

        static void Main()
        {
            Console.WriteLine("Таблица функции MyFunctionPow - a*x^2:");
            Mathematics.Table(new Function(Mathematics.MyFunctionPow), -2, 2);
            Console.WriteLine("Таблица функции MyFunctionSin - a*sin(x):");
            Mathematics.Table(Mathematics.MyFunctionSin, -2, 2);

            Console.ReadKey();
        }
    }
}
