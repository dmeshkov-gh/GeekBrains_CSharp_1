using System;
using System.IO;

namespace MessageClass
{
    class FileHandler
    {
        internal static void WriteToFile(string filename, string content)
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
