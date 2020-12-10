using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meshkov.CS_1
{
    class BodyMassIndex_BMI
    {
        //Мешков Дмитрий

        //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) 
        //по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах
        static void Main()
        {
            Console.Write("Введите Ваш вес в килограммах: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Ввеите Ваш рост в метрах: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Ваш индекс массы тела: {0}", BodyMassIndex(weight, height));
            Console.ReadKey();
        }
        static double BodyMassIndex(double weight, double height)
        {
            return weight / (height * height);
        }
    }
}
