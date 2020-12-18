using System;
using System.IO;

namespace MessageClass
{
    class FileHandler //Класс для работы с файлами
    {
        internal static void WriteToFile(string filename, string content) //Записать в файл
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(filename, true))
                {
                    streamWriter.Write(content + " ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        internal static void DeleteFileIfExists(string filename)
        {
            if (File.Exists(filename))
                File.Delete(filename);
        }
    }
}
