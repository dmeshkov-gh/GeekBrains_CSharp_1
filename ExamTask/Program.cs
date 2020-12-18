using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask
{
    class Program
    {
        static void Main()
        {
            int students = FileHandler.ReadFromFile("data.txt");
        }
    }
}
