using System;
using System.Text;

namespace MessageClass
{
    // Мешков Дмитрий
    //Разработать класс Message, содержащий следующие статические методы для обработки текста:

    class Message
    {
        public static void PrintTheWordsWithLessThanNLetters(string text, int n) //Вывести только те слова сообщения, которые содержат не более n букв.
        {
            FileHandler.DeleteFileIfExists("PrintTheWordsWithLessThanNLetters.txt"); //Удаляем файл, если он существует
            string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            foreach(string word in words)
            {
                if (word.Length < n) FileHandler.WriteToFile("PrintTheWordsWithLessThanNLetters.txt", word);
            }
        }
        public static void DeleteAllWordsEndingWith(string text, char symbol) //Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        {
            FileHandler.DeleteFileIfExists("DeleteAllWordsEndingWith.txt");
            string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                if(!word.EndsWith(symbol.ToString())) FileHandler.WriteToFile("DeleteAllWordsEndingWith.txt", word);
            }
        }
        public static void PrintOriginalText(string text) 
        {
            FileHandler.DeleteFileIfExists("OriginalText.txt");
            FileHandler.WriteToFile("OriginalText.txt", text);
        }
        public static void TheLongestWord(string text) //Найти самое длинное слово сообщения.
        {
            FileHandler.DeleteFileIfExists("TheLongestWord.txt");
            string theLongestWord = null;
            string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            for(int i =1; i < words.Length; i++)
            {
                if (words[i].Length > words[i - 1].Length) theLongestWord = words[i];     
            }
            FileHandler.WriteToFile("TheLongestWord.txt", theLongestWord);
        }
        public static void StringOfTheLongestWords(string text) //Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        {
            FileHandler.DeleteFileIfExists("StringOfTheLongestWords.txt");
            StringBuilder stringBuilder = new StringBuilder();
            int longestWordLenght = 0;
            string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > longestWordLenght)
                {
                    longestWordLenght = words[i].Length;
                    stringBuilder.Clear();
                    stringBuilder.Append(words[i]);
                }
                else if(words[i].Length == longestWordLenght)
                {
                    stringBuilder.Append(words[i]);
                }
            }
            FileHandler.WriteToFile("StringOfTheLongestWords.txt", stringBuilder.ToString());

        }
    }
}
