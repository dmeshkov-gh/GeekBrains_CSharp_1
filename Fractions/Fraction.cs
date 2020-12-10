using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Fraction
    {
        private int _denominator;
        private int? _integral; // Целая часть числа

        public int Numerator { get; private set; }      //Числитель
        public int Denominator 
        { 
            get 
            {
                return _denominator;
            } 
            private set
            {
                if (value <= 0) throw new ArgumentException("Знаменатель должен не должен быть отрицательным или равным 0");
                _denominator = value;
            }
        }
        public Fraction(int numerator, int denominator) //Конструктор с двумя свойствами
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction((int numerator, int denominator) p) // Конструктор с кортежем
        {
            Numerator = p.numerator;
            Denominator = p.denominator;
        }

        public void Sum(Fraction fraction) // Сложение
        {
            int lcm = LeastСommonMultiple(Denominator, fraction.Denominator);
            int calculatedNumerator = CalculateNumerator(Numerator, lcm, Denominator) + CalculateNumerator(fraction.Numerator, lcm, fraction.Denominator);
            Fraction result = new Fraction(calculatedNumerator, lcm);
            Simplify(result);
            Console.WriteLine(this + " прибавить " + fraction + " = " + result);
        }

        public void Deduct(Fraction fraction) //Вычитание
        {
            int lcm = LeastСommonMultiple(Denominator, fraction.Denominator);
            int calculatedNumerator = CalculateNumerator(Numerator, lcm, Denominator) - CalculateNumerator(fraction.Numerator, lcm, fraction.Denominator);
            Fraction result = new Fraction(calculatedNumerator, lcm);
            Simplify(result);
            Console.WriteLine(this + " вычесть " + fraction + " = " + result);
        }
        public void Multiply(Fraction fraction) // Умножение
        {
            int calculatedNumerator = Numerator * fraction.Numerator;
            int calculatedDenominator = Denominator * fraction.Denominator;
            Fraction result = new Fraction(calculatedNumerator, calculatedDenominator);
            Simplify(result);
            Console.WriteLine(this + " умножить на " + fraction + " = " + result);
        }
        public void Divide(Fraction fraction) //Деление
        {
            int calculatedNumerator = Numerator * fraction.Denominator;
            int calculatedDenominator = Denominator * fraction.Numerator;
            Fraction result = new Fraction(calculatedNumerator, calculatedDenominator);
            Simplify(result);
            Console.WriteLine(this + " разделить на " + fraction + " = " + result);
        }
        private void Simplify(Fraction fraction) // Метод, который упрощает дроби
        {
            if (fraction.Numerator % fraction.Denominator == 0) //Делится без остатка
            {
                fraction._integral = fraction.Numerator / fraction.Denominator; //Определяем целую часть
                fraction.Numerator = fraction.Denominator = 1;  //Устанавливаем значение 1, чтобы переопределить исполнение в ToString() - отбросить дробную часть в выводе;
            }
            else if (fraction.Numerator > fraction.Denominator) //Числитель больше знаменателя
            {
                fraction._integral = fraction.Numerator / fraction.Denominator;
                fraction.Numerator = fraction.Numerator % fraction.Denominator;
                int gcd = GreatestCommonDivisor(fraction.Numerator, fraction.Denominator); // Находим НОД для получившейся дроби
                fraction.Numerator /= gcd;
                fraction.Denominator /= gcd;
            }
            else if (fraction.Numerator < 0 && fraction._integral.HasValue)
            {
                fraction.Numerator = Math.Abs(fraction.Numerator); //Делаем число положительным
                Simplify(fraction); //Вызываем рекурсивно метод, который упрощает дроби
                int gcd = GreatestCommonDivisor(fraction.Numerator, fraction.Denominator); // Находим НОД для получившейся дроби
                fraction.Numerator /= gcd;
                fraction.Denominator /= gcd;
                fraction._integral *= -1; //Делаем число отрицательным
            }
            else if (fraction.Numerator < 0)
            {
                fraction.Numerator = Math.Abs(fraction.Numerator); //Делаем число положительным
                Simplify(fraction); //Вызываем рекурсивно метод, который упрощает дроби
                int gcd = GreatestCommonDivisor(fraction.Numerator, fraction.Denominator); // Находим НОД для получившейся дроби
                fraction.Numerator /= gcd;
                fraction.Denominator /= gcd;
                fraction.Numerator *= -1; //Делаем число отрицательным
            }
            else if(fraction.Numerator < fraction.Denominator)
            {
                int gcd = GreatestCommonDivisor(fraction.Numerator, fraction.Denominator); // Находим НОД для получившейся дроби
                fraction.Numerator /= gcd;
                fraction.Denominator /= gcd;
            }
        }

        private int LeastСommonMultiple(int num1, int num2) //НОК через НОД
        {
            return (num1 * num2) / GreatestCommonDivisor(num1, num2);
        }

        private int GreatestCommonDivisor(int num1, int num2) // НОД
        {
            if (num1 == num2)
                return num1;
            if (num1 > num2)
                return GreatestCommonDivisor(num1 - num2, num2);
            return GreatestCommonDivisor(num2 - num1, num1);
        }
        private static int CalculateNumerator(int numerator, int lcm, int denominator) // Определение числителя в методах Sum и Substruct
        {
            return numerator * (lcm / denominator);
        }
        public override string ToString()
        {
            if (_integral.HasValue && Numerator == 1 && Denominator == 1) 
                return $"{_integral}"; //Вывод, если получается целое число
            else if (_integral.HasValue) 
                return $"{_integral} " + $"{Numerator}" + "/" + $"{Denominator}"; //Вывод, если получается целое число и остаток
            return $"{Numerator}" + "/" + $"{Denominator}"; // Выводится, когда есть только дробная часть
        }
    }
}
