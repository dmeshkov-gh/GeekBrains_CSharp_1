using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask
{
    //Мешков Дмитрий

    //На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней
    //школы.В первой строке сообщается количество учеников N, которое не меньше 10, но не
    //превосходит 100, каждая из следующих N строк имеет следующий формат:
    //<Фамилия> <Имя> <оценки>,
    //где<Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не
    //более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по
    //пятибалльной системе. <Фамилия> и<Имя>, а также<Имя> и<оценки> разделены одним пробелом.
    //Пример входной строки:
    //Иванов Петр 4 5 3
    //Требуется написать как можно более эффективную программу, которая будет выводить на экран
    //фамилии и имена трёх худших по среднему баллу учеников.Если среди остальных есть ученики,
    //набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
    //Достаточно решить 2 задачи.Старайтесь разбивать программы на подпрограммы.Переписывайте в
    //начало программы условие и свою фамилию. Все программы сделать в одном решении. Для решения
    //задач используйте неизменяемые строки (string)
    class Program
    {
        static void Main()
        {
            List<Student> students = FileHandler.ReadStudentsFromFile("students.txt");
            PrintStudentList(students);
            List<Student> worstStudents = GetTheWorstStudents(students);
            PrintTheWorstStudentList(worstStudents);

            Console.ReadKey();
        }

        private static List<Student> GetTheWorstStudents(List<Student> students)
        {
            List<Student> theWorstStudents = new List<Student>();
            double theWorstAverageGrade = 0;
            for (int count = 0; count < 3; count++) // Находим 3-х худших учеников. Если среди остальных есть ученики,
                                                    //набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
            {
                for (int i = 1; i < students.Count; i++)    //Находим наихудшую оценку
                    if (students[i - 1].GetAverageGrade() > students[i].GetAverageGrade()) theWorstAverageGrade = students[i].GetAverageGrade();
                for (int i = 0; i < students.Count; i++) // Находим студентов с наихудшей оценкой
                {
                    if (students[i].GetAverageGrade() == theWorstAverageGrade)
                    {
                        theWorstStudents.Add(students[i]); // Добавляет студента с наихудшей оценкой в список худших
                        students.Remove(students[i]); // Удаляем этого студента из общего списка
                    }
                }
            }
            return theWorstStudents;
        }


        private static void PrintStudentList(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.Write("{0} {1} ", student.LastName, student.Name);
                PrintGrades(student.Grades);
                Console.WriteLine();
            }

        }

        private static void PrintGrades(int[] grades)
        {
            foreach (var grade in grades)
            {
                Console.Write("{0} ", grade);
            }
        }

        private static void PrintTheWorstStudentList(List<Student> worstStudents)
        {
            foreach (var student in worstStudents)
            {
                Console.WriteLine("{0} {1}. Cредняя оценка: {2:0.00}", student.LastName, student.Name, student.GetAverageGrade());
            }
        }
    }
}
