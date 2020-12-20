using System;
using System.IO;

namespace MinValueWithDelegates
{
    class FileHandler
    {
        public static void SaveFuncValuesToTheFile(string fileName, Function F, double a, double b, double h)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    double x = a;
                    while (x <= b)
                    {
                        bw.Write(F(x));
                        x += h;// x=x+h;
                    }
                }
            }
        }

        public static double[] LoadValuesFromFile(string fileName, out double min)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader bw = new BinaryReader(fs))
                {
                    double[] numbers = new double[fs.Length / sizeof(double)];
                    min = double.MaxValue;
                    double d;
                    for (int i = 0; i < fs.Length / sizeof(double); i++)
                    {
                        d = bw.ReadDouble();
                        numbers[i] = d;
                        if (d < min) min = d;
                    }
                    return numbers;
                }
            }

        }
    }
}
