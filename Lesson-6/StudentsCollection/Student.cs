using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCollection
{
    delegate bool Is(Student student);
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string University { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
        public int Course { get; set; }
        public int Group { get; set; }
        public string City { get; set; }

        public Student(string firstName, string lastName, string university, string faculty,
            string department, int age, int course, int group, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            University = university;
            Faculty = faculty;
            Department = department;
            Age = age;
            Course = course;
            Group = group;
            City = city;
        }
        public override string ToString()
        {
            return String.Format("{0,15},{1,15},{2,15},{3,15},{4,15},{5,15},{6,15},{7,5},{8,10}", 
                FirstName, LastName, University, Faculty, Department, Age, Course, Group, City);

        }
        public static int CompareByAge(Student firstStudent, Student secondStudent)
        {
            if (firstStudent.Age > secondStudent.Age) return 1;
            if (firstStudent.Age < secondStudent.Age) return -1;
            return 0;
        }
        public static int CompareByCourse(Student firstStudent, Student secondStudent)
        {
            if (firstStudent.Course > secondStudent.Course) return 1;
            if (firstStudent.Course < secondStudent.Course) return -1;
            return 0;
        }
        public static bool IsOnFifthOrSixthCourse(Student student) //Находит студентов 5 и 6 курсов
        {
            if (student.Course == 5 || student.Course == 6) return true;
                else return false;
        }
        //д) разработать единый метод подсчета количества студентов по различным параметрам
        //выбора с помощью делегата и методов предикатов.
        public static int CountStudents(List<Student> studentList, Is IsDel)
        {
            int counter = 0;
            foreach(Student student in studentList)
            {
                if (IsDel(student) == true) counter++;
            }
            return counter;
        }
        //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
        public static void CountStudentsOnCourses(List<Student> students) 
        {
            int[] courses = new int[6];
            for(int i = 0; i < students.Count; i++)
            {
                if (students[i].Age >= 18 && students[i].Age <= 20)
                    courses[students[i].Course]++;
            }
            for (int i = 1; i < courses.Length; i++)
            {
                Console.WriteLine("Количество студентов в возрасте от 18 до 20 лет на {0} курсе: {1}", i, courses[i]);
            }
        }

    }
}
