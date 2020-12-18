using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginChecker
{
    //Мешков Дмитрий
    //    1. Создать программу, которая будет проверять корректность ввода логина.
    
    class Program
    {
        static void Main()
        {
            string log = Console.ReadLine();
            Login login = new Login(log); //Проверка логина осуществляется в конструкторе

            Console.ReadKey();
        }
    }
}
