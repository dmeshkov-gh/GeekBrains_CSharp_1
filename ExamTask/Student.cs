using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask
{
    class Student
    {
        private int _numberOfStudents;
        private int[] _grades;
        private string _firstName;
        private string _lastName;
        public string FirstName 
        { 
            get 
            {
                return _firstName;
            } 
            set 
            {
                if (value.Length > 15) throw new Exception("Имя не должно быть длиннее 15 символов");
                _firstName = value;
            } 
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value.Length > 15) throw new Exception("Имя не должно быть длиннее 15 символов");
                _firstName = value;
            }
        }
    }
}
