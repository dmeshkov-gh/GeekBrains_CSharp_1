using System;
using System.Collections.Generic;
using System.IO;

namespace ExamTask
{
    class FileHandler
    {
        public static List<Student> ReadStudentsFromFile(string filename)
        {
            StreamReader stream = new StreamReader(filename);
            string stringFromFile;
            List<Student> students = new List<Student>();
            while ((stringFromFile = stream.ReadLine()) != null)    //Считываем построчно
            {
                string[] data = stringFromFile.Split(' ');  //Разделяем массив на подстроки
                int[] grades = new int[3]; // Записываем оценки в массив                 
                for (int i = 0; i < grades.Length; i++)
                {
                    grades[i] = Convert.ToInt32(data[i + 2]);
                }
                Student student = new Student(data[1], data[0], grades); //Через конструктор записываем данные студента - фамилию, имя, оценки
                students.Add(student);  //Добавляем студента в список
            }
            if (students.Count < 10 || students.Count > 100) throw new Exception("Количество студентов не должно быть меньше 10 или больше 100");
            stream.Close();
            return students;
        }
    }
}
