using System;
using System.IO;

namespace MinValueWithDelegates
{
    //Мешков Дмитрий
    //2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
    //а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
    //б) Используйте массив(или список) делегатов, в котором хранятся различные функции.
    //в) * Переделайте функцию Load, чтобы она возвращала массив считанных значений.Пусть она
    //возвращает минимум через параметр.
    public delegate double Function(double x);
    class Program
    {
        public static double Func1(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double Func2(double x)
        {
            return x * x - 40 * x + 30;
        }
        public static double Func3(double x)
        {
            return x * x - 55 * x + 15;
        }
        public static void SaveFunc(string fileName, Function F, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        static void Main()
        {
            SaveFunc("data.bin", Func3, -100, 100, 0.5);
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();
        }

    }
}
