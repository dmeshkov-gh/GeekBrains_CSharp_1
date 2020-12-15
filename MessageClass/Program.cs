using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageClass
{
    // Мешков Дмитрий
    //Разработать класс Message, содержащий следующие статические методы для обработки текста:
    //а) Вывести только те слова сообщения, которые содержат не более n букв.
    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //в) Найти самое длинное слово сообщения.
    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //Продемонстрируйте работу программы на текстовом файле с вашей программой.
    class Program
    {
        static void Main()
        {
            string brodskiy = "Не выходи из комнаты, не совершай ошибку.";
            Message.PrintOriginalText(brodskiy);
            Message.PrintTheWordsWithLessThanNLetters(brodskiy, 7);
            Message.DeleteAllWordsEndingWith(brodskiy, 'и');
            Message.TheLongestWord(brodskiy);
            Message.StringOfTheLongestWords(brodskiy);
        }
    }
}
