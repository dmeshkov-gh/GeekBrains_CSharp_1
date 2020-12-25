using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelieveOrNotBelieve
{
    //Мешков Дмитрий

    //Игра Верю не верю
    //Можно создать собственную игру через вкладу Create New > Автоматически добавляется первый вопрос > далее в поле текст пишем 
    //новый вопрос и с помощью checkbox True задаем правильный ответ > повторяем несколько раз и сохраняем

    //Для игры открываем файл GuessWhatIsTrue или новый созданный файл. Выбираем true или false И нажимаем Answer!
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
