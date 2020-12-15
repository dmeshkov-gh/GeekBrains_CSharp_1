using System;
using System.IO;

namespace AccountAuthorization_FromFile
{
    // Мешков Дмитрий

    // Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив.
    // Создайте структуру Account, содержащую Login и Password.


    class Program
    {
        static void Main()
        {
            Console.WriteLine(Authorization.LogIn()); 
            Console.ReadKey();
        }
    }
}
