using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rearrangement
{
    //Мешков Дмитрий
    //* Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
    //а) с использованием методов C#;
    //б) *разработав собственный алгоритм.
    // Например:
    //badc являются перестановкой abcd.
    class Program
    {
        static void Main()
        {
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();

            if (IsRearranged(string1, string2)) Console.WriteLine("Строка {0} является перестановкой {1}.", string1, string2);
                else Console.WriteLine("Строка {0} не является перестановкой {1}.", string1, string2);

            Console.ReadKey();
        }

        private static bool IsRearranged(string string1, string string2)
        {
            char[] array1 = string1.ToLower().ToCharArray();
            char[] array2 = string2.ToLower().ToCharArray();

            Array.Sort(array1);
            Array.Sort(array2);

            for(int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == array2[i]);
                else return false;
            }
            return true;
        }

    }
}
