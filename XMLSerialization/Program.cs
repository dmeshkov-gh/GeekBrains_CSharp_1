using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace XMLSerialization
{
    [Serializable]
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Student()
        {
        }
        public Student(string firstname, string lastname, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }
    }
    class Program
    {
        public static void SaveAsXMLFormat(Student student, string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            using (FileStream fileStream = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(fileStream, student);
            }
        }
        public static Student LoadFromXMLFormat(string filename)
        {
            Student student = new Student();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            using (FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                student = xmlSerializer.Deserialize(fileStream) as Student; // приведение типов при помощи ключевого слова as
                                                                                // возвращает null, если приведение не удалось
            }
            return student;

        }
        static void Main(string[] args)
        {
            Student student = new Student("Dmitry", "Meshkov", 29);
            SaveAsXMLFormat(student, "data.xml");

        }
    }
}
