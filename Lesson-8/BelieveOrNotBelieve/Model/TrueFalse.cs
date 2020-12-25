using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BelieveOrNotBelieve.Model
{
    // Класс для хранения списка вопросов. А также для сериализации в XML и десериализации из XML
    public class TrueFalse
    {
        string _fileName;
        List<Question> questions;
        public string FileName {
            get 
            {
                return _fileName;
            }
            set 
            { 
                _fileName = value; 
            } 
        }
        public int Count { get => questions.Count; }

        public TrueFalse(string filename)
        {
            FileName = filename;
            questions = new List<Question>();
        }
        public void AddQuestion(string text, bool trueFalse)
        {
            questions.Add(new Question(text, trueFalse));
        }
        public void RemoveQuestion(int index)
        {
            if (questions != null && index < questions.Count && index > 0)
                questions.RemoveAt(index);
        }
        // Индексатор - свойство для доступа к закрытому объекту
        public Question this[int index]
        {
            get { return questions[index]; }
        }
        public void SaveAsXMLFormat()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            using(Stream fileStream = new FileStream(FileName, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(fileStream, questions);
            }
        }
        public void LoadFromXMLFormat()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            using (Stream fileStream = new FileStream(FileName, FileMode.Open, FileAccess.Read))
            {
                questions = xmlSerializer.Deserialize(fileStream) as List<Question>;
            }
        }
    }
}
