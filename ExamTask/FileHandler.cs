using System;
using System.IO;

namespace ExamTask
{
    class FileHandler
    {
        internal static int ReadFromFile(string filename)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(filename))
                {
                    int numberOfStudents = int.Parse(streamReader.ReadLine());
                    if (numberOfStudents >= 10 && numberOfStudents <= 100)
                    {
                        Student[] students = new Student[numberOfStudents];
                    }
                    return numberOfStudents;
                }
               

            }
            finally { }
        }
    }
}
