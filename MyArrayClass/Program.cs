using System;
using System.IO;

namespace MyArrayClass
{
    class Program
    {
        //Мешков Дмитрий

        //Дописать класс MyArray для работы с одномерным массивом. В Main продемонстрировать работу класса.

        static void Main()
        {
            MyArray array = new MyArray(5, 5, 3);
            array.ToConsole();
            Console.WriteLine("Сумма элементов массива: " + array.Sum + ". Максимальное значение: " + array.Max);
            array.Inverse();
            Console.WriteLine("Инвертированный массив: ");
            array.ToConsole();
            Console.WriteLine("Массив с множителем 3: ");
            array.Multi(3);
            array.ToConsole();
            Console.WriteLine("Другой массив: ");
            MyArray anotherArray = new MyArray(7, 10, 7);
            anotherArray.ToConsole();
            array.MergeWith(anotherArray);
            Console.WriteLine("Объединенный массив: ");
            array.ToConsole();
            Console.WriteLine("Массив, увеличенный до 20 символов: ");
            array.Resize(20);
            array.ToConsole();

            array.WriteToFile("data.txt"); 
            MyArray arrayFromFile = new MyArray("data.txt");

            Console.ReadKey();
        }
    }
}
