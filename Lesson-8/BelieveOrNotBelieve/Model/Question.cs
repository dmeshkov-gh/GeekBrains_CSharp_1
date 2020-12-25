using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelieveOrNotBelieve.Model
{
    [Serializable]
    public class Question
    {
        public string  Text { get; set; } // Текст вопроса
        public bool TrueFalse { get; set; } // Правда или нет

        public Question()
        {
        }

        public Question(string text, bool answer)
        {
            Text = text;
            TrueFalse = answer;
        }
    }
}
