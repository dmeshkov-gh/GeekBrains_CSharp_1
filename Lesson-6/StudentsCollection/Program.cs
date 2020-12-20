using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentsCollection
{
    //Мешков Дмитрий
    //3. Переделать программу «Пример использования коллекций» для решения следующих задач:
    //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
    //в) отсортировать список по возрасту студента;
    //г) * отсортировать список по курсу и возрасту студента;
    //д) разработать единый метод подсчета количества студентов по различным параметрам
    //выбора с помощью делегата и методов предикатов.
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();

            using (FileStream fileStream = new FileStream("students_1.csv", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    while (!streamReader.EndOfStream)
                    {
                        try
                        {
                            string[] studentData = streamReader.ReadLine().Split(';');
                            Student newStudent;
                            newStudent = new Student(studentData[0], studentData[1], studentData[2], studentData[3], studentData[4], Int32.Parse(studentData[5]),
                                Int32.Parse(studentData[6]), Int32.Parse(studentData[7]), studentData[8]);
                            studentList.Add(newStudent);
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            
            Console.WriteLine("Количество студентов на 5, 6 курсах: {0}", Student.CountStudents(studentList, Student.IsOnFifthOrSixthCourse));
            Student.CountStudentsOnCourses(studentList);

            studentList.Sort(new Comparison<Student>(Student.CompareByAge));

            //г) * отсортировать список по курсу и возрасту студента;
            List<Student> sortedStudentList = studentList.OrderBy(student => student.Course).ThenBy(student => student.Age).ToList();
            foreach(Student student in sortedStudentList)
            {
                Console.WriteLine($"{student.Course} {student.Age}");
            }

            Console.ReadKey();
        }

    }
}
