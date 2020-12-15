using System;
using System.IO;

namespace AccountAuthorization_FromFile
{
    class FileHandler
    {
        Account accessData = new Account("root", "GeekBrains"); // Логин и пароль для сверки
        internal void WriteToFile(string filename)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(filename))
                {
                    streamWriter.WriteLine("{0}\n{1}", accessData.Login, accessData.Password);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        internal string[] ReadFromFile(string filename)
        {
            try
            {
                char[] buffer;
                using (StreamReader streamReader = new StreamReader(filename))
                {
                    buffer = new Char[(int)streamReader.BaseStream.Length];
                    streamReader.Read(buffer, 0, (int)streamReader.BaseStream.Length);
                }
                string authData = new string(buffer);
                string[] authotizationData = authData.Split('\n', '\r');

                return authotizationData;
            }
            finally { }
        }
    }
}
