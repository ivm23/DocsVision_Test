using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registration.Model;

namespace Registrstion.WinForms
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Registration());
        }

    }
    public static class Data
    {
        public delegate void MyEventCreateLetter(string nameLetter, string nameSender, List<string> nameReceivers, string text);
        public static MyEventCreateLetter EventHandlerCreateLetter;

        public delegate void MyEventOrderBy(ShowAllLetters showAllLettersForm, int index);
        public static MyEventOrderBy EventHandlerOrderBy;

        public delegate void MyEventOrder(int index);
        public static MyEventOrder EventHandlerOrder;

        public delegate void MyEventInfoLetter(ShowAllLetters showAllLettersForm, Guid id);
        public static MyEventInfoLetter EventHandlerInfoLetter;

        public delegate void MyEventInfo(Guid id);
        public static MyEventInfo EventHandlerInfo;

        public delegate void MyEventChangeLetter(Letter letter);
        public static MyEventChangeLetter EventHandlerChangeLetter;

        public delegate void MyEventAddWorker(Controlers.InfoLetterControl infoLetterControl, bool isSender);
        public static MyEventAddWorker EventHandlerAddWorker;

        public delegate void MyEventMakeWorker(Forms.ChangeLetter changeLetterForm);
        public static MyEventMakeWorker EventHandlerMakeWorker;

        public delegate void MyEventUpdateLetter(Forms.ChangeLetter changeLetter);
        public static MyEventUpdateLetter EventHandlerUpdateLetter;

        public delegate void MyEventDeleteLetter(ShowAllLetters allLettersForm, Guid id);
        public static MyEventDeleteLetter EventHandlerDeleteLetter;
    }


}
