using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meshkov.CS_1
{
    class BodyMassIndex_Advanced
    {
        //Мешков Дмитрий

        //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
        //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        static void Main()
        {
            Console.Write("Введите Ваш вес в килограммах: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Ввеите Ваш рост в метрах: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(BodyMassIndex(weight, height));
            Console.ReadKey();
        }
        static string BodyMassIndex(double weight, double height)
        {
            double bmi = weight / (height * height);
            if (bmi < 18.5)
            {
                return "ИМТ: " + String.Format("{0:F2}", bmi) + ". Ваш вес ниже нормального. Вам надо набрать " + HowMuchToGain(height, bmi) + " килограмм.";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                return "ИМТ: " + String.Format("{0:F2}", bmi) + ". У Вас нормальный вес.";
            }
            else
            {
                return "ИМТ: " + String.Format("{0:F2}", bmi) + ". У Вас избыточный вес. Вам надо сбросить " + HowMuchToLose(height, bmi) + " килограмм.";
            }
        }

        static double HowMuchToLose(double height, double bmi)
        {
            return (bmi - 25) * height * height;
        }

        static double HowMuchToGain(double height, double bmi)
        {
            return (18.5 - bmi) * height * height;
        }
    }
}
