using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask
{
    class Student
    {
        private string _name;
        private string _lastName;
        public string Name 
        {
            get 
            {
                return _name;
            }
            private set
            {
                if (value.Length >= 15) throw new Exception("Имя должно состоять не более чем из 15 символов");
                _name = value;
            } 
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            private set
            {
                if (value.Length >= 20) throw new Exception("Имя должно состоять не более чем из 20 символов");
                _lastName = value;
            }
        }
        public int[] Grades { get; private set; }
        public Student(string name, string lastname, int[] grades)
        {
            Name = name;
            LastName = lastname;
            Grades = grades;
        }
        public double GetAverageGrade()
        {
            int sum = 0;
            for(int i = 0; i < Grades.Length; i++)
                sum += Grades[i];
            double averageGrade = (double)sum / Grades.Length;
            return averageGrade;
        }
    }
}
