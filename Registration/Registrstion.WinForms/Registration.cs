using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registration.WinForms;
using Registration.Model;

namespace Registrstion.WinForms
{
    public partial class Registration : Form
    {
        private ServiceClient _serviceClient;
        private Guid IdChangeLetter;
        public Registration()
        {
            InitializeComponent();
            Data.EventHandlerCreateLetter = new Data.MyEventCreateLetter(CreateLetter);
            Data.EventHandlerOrderBy = new Data.MyEventOrderBy(OrderBy);
            Data.EventHandlerInfoLetter = new Data.MyEventInfoLetter(InfoLetter);
            Data.EventHandlerChangeLetter = new Data.MyEventChangeLetter(ChangeLetter);
            Data.EventHandlerAddWorker = new Data.MyEventAddWorker(AddWorker);
            Data.EventHandlerMakeWorker = new Data.MyEventMakeWorker(MakeWorker);
            Data.EventHandlerUpdateLetter = new Data.MyEventUpdateLetter(UpdateLetter);
            Data.EventHandlerDeleteLetter = new Data.MyEventDeleteLetter(DeleteLetter);
        }
        void GetNameLogin(ref string nameWorker, ref string loginWorker, string nameValues)
        {
            int isBkt = nameValues.IndexOf('(');
            if (isBkt != -1)
            {
                int index = 0;
                while (nameValues[index] != ' ' && nameValues[index + 1] != '(')
                {
                    nameWorker += nameValues[index];
                    ++index;
                }
                index+=2;

                while (nameValues[index] != ')')
                {
                    loginWorker += nameValues[index];
                    ++index;
                }
            }
            else
            {
                nameWorker = "";
                loginWorker = nameValues;
            }
        }

        void AddWorker(Controlers.InfoLetterControl infoLetterControl, bool isSender)
        {
            string nameWorker = "";
            string loginWorker = "";
            var nameSender = "";
            var worker = new User { name = nameWorker, login = loginWorker };
            var senderToCreate = new User();

            if (isSender)
            {
                nameSender = infoLetterControl.GetSender;
                GetNameLogin(ref nameWorker, ref loginWorker, nameSender);
                worker.name = nameWorker;
                worker.login = loginWorker;
                senderToCreate = _serviceClient.GetWorker(loginWorker);
            }

            if (senderToCreate == null || !isSender)
            {
                using (var form = new Forms.NewWorker())
                {
                    bool isWorkerExist = true;
                    while (worker.name == "" || worker.login == "" || isWorkerExist)
                    {
                        isWorkerExist = false;
                        if (isSender) form.SetLogin = loginWorker;
                        else
                            form.SetEnable = true;

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            worker.name = form.GetName;
                            if (!isSender)
                            {
                                worker.login = form.GetLogin;
                                if (worker.login == "")
                                {
                                    MessageBox.Show("Необходимо указать логин сотрудника!");
                                    continue;
                                }
                                senderToCreate = _serviceClient.GetWorker(worker.login);
                                if (senderToCreate != null)
                                {
                                    isWorkerExist = true;
                                    MessageBox.Show("Сотрудник с таким логином уже существует!");
                                    continue;
                                }
                            }
                            if (worker.name != "")
                            {
                                if (worker.login != "")
                                {
                                    senderToCreate = _serviceClient.CreateWorker(worker);
                                    MessageBox.Show("Сотрудник добавлен!");
                                    if (isSender)
                                    {
                                        string str = infoLetterControl.GetValueToTextBox;

                                        infoLetterControl.ChangeText(ref str, "Отправитель: ", worker.name + " (" + worker.login + ")");

                                        infoLetterControl.SetValueToTextBox = str;
                                        infoLetterControl.AddSender = true;

                                        var nameUsers = GetAllWorkers();
                                        infoLetterControl.SetWorkers = nameUsers;
                                        infoLetterControl.Refresh();
                                    }
                                    else
                                    {
                                        string str = infoLetterControl.GetValueToTextBox;
                                        infoLetterControl.NameReceivers(ref str, worker.name + " (" + worker.login + ")");
                                        infoLetterControl.SetValueToTextBox = str;
                                        infoLetterControl.AddToAllReceivers = worker.name + " (" + worker.login + ")";
                                        infoLetterControl.AddReceiver = true;
                                    }
                                }
                                else MessageBox.Show("Необходимо указать логин сотрудника!");
                            }
                            else
                            {
                                MessageBox.Show("Необходимо указать имя сотрудника!");
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
                string str = infoLetterControl.GetValueToTextBox;
                infoLetterControl.ChangeText(ref str, "Отправитель: ", nameSender);
                infoLetterControl.SetValueToTextBox = str;
            }

        }
        void CreateLetter(string nameLetter, string nameSender, List<string> nameReceivers, string textLetter)
        {
            string nameWorker = "";
            string loginWorker = "";
            GetNameLogin(ref nameWorker, ref loginWorker, nameSender);
            var senderToCreate = _serviceClient.GetWorker(loginWorker);
            List<Guid> idRec = new List<Guid>();

            foreach (var receiver in nameReceivers)
            {
                nameWorker = "";
                loginWorker = "";
                GetNameLogin(ref nameWorker, ref loginWorker, receiver);
                var receiverToCreate = _serviceClient.CreateWorker(new User { name = nameWorker, login = loginWorker });
                idRec.Add(receiverToCreate.id);
            }

            _serviceClient.CreateLetter(new Letter { name = nameLetter, idSender = senderToCreate.id, idReceiver = idRec, text = textLetter });
            MessageBox.Show("Сообщение добавлено!");
        }

        void OrderBy(ShowAllLetters showAllLettersForm, int index)
        {
            List<Letter> letters = new List<Letter>();
            switch (index)
            {
                case 0:
                    letters = _serviceClient.GetLettersOrderByName();
                    break;
                case 1:
                    letters = _serviceClient.GetLettersOrderByDate();
                    break;
                case 2:
                    letters = _serviceClient.GetLettersOrderBySender();
                    break;
            }

            List<string> nameLetters = new List<string>();
            foreach (var letter in letters)
            {
                nameLetters.Add(letter.name);
            }

            showAllLettersForm.SetLetters = letters;
            showAllLettersForm.Refresh();
        }
        void InfoLetter(ShowAllLetters showAllLettersForm, Guid id)
        {
            List<string> InfoLetter = new List<string>();
            try
            {
                var letter = _serviceClient.GetLetter(id);
                InfoLetter.Add("Название: " + letter.name);
                InfoLetter.Add("Дата: " + letter.date);
                InfoLetter.Add("Отправитель: " + _serviceClient.GetSender(id));
                var nameReceivers = _serviceClient.GetReceivers(id);

                bool isPrint = false;
                foreach (var receiver in nameReceivers)
                {
                    if (!isPrint)
                    {
                        InfoLetter.Add("Получатели: " + receiver);
                        isPrint = true;
                    }
                    else
                    {
                        InfoLetter.Add(receiver);
                    }
                }
                InfoLetter.Add("Содержание : " + letter.text);
                showAllLettersForm.SetInfo = InfoLetter;
            }
            catch
            {

            }
        }

        void ChangeLetter(Letter letter)
        {
            IdChangeLetter = letter.id;
            using (var form = new Forms.ChangeLetter())
            {
                form.SetAllWorkers = GetAllWorkers();
                form.SetSender = _serviceClient.GetSender(letter.id);
                form.NameLetter = letter.name;
                form.SetAllReceivers = GetAllWorkers();
                form.SetLetterReceivers = _serviceClient.GetReceivers(letter.id);
                form.SetTextLetter = letter.text;
                form.ShowDialog();
            }
        }

        void MakeWorker(Forms.ChangeLetter changeLetterForm)
        {
            using (var form = new Forms.NewWorker() )
            {
                form.SetEnable = true;

                var worker = new User { name = "", login = "" };
                while (worker.name == "" || worker.login == "" )
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        worker.name = form.GetName;
                        worker.login = form.GetLogin;

                        if (_serviceClient.GetWorker(worker.login) == null)
                        {
                            _serviceClient.CreateWorker(worker);
                            MessageBox.Show("Пользователь добавлен!");
                            changeLetterForm.SetAllReceivers = GetAllWorkers();
                            changeLetterForm.SetAllWorkers = GetAllWorkers();
                        }
                        else
                        {
                            MessageBox.Show("Такой пользователь уже существует!");
                            worker.name = "";
                            worker.login = "";
                        }
                    }
                    else
                    {
                        break;
                    }
                }

            }
        }

        void UpdateLetter(Forms.ChangeLetter changeLetter)
        {
            string nameWorker = "";
            string loginWorker = "";
            GetNameLogin(ref nameWorker, ref loginWorker, changeLetter.GetSender);

            var letter = new Letter
            {
                name = changeLetter.NameLetter,
                text = changeLetter.GetTextLetter,
                idSender = _serviceClient.GetWorker(loginWorker).id,
                idReceiver = new List<Guid>()
            };

            var receivers = changeLetter.GetLetterReceivers;
            
            foreach(var rec in receivers)
            {
                nameWorker = "";
                loginWorker = "";
                GetNameLogin(ref nameWorker, ref loginWorker, rec);
                letter.idReceiver.Add(_serviceClient.GetWorker(loginWorker).id);
            }
            
            var l = _serviceClient.UpdateSingleValue<string>(IdChangeLetter, letter.name, "newName");
            l = _serviceClient.UpdateSingleValue<string>(IdChangeLetter, letter.text, "newText");
            l = _serviceClient.UpdateSingleValue<Guid>(IdChangeLetter, letter.idSender, "newIdSender");
            l = _serviceClient.UpdateSingleValue<List<Guid>>(IdChangeLetter, letter.idReceiver, "newIdReceivers");
        }
        void DeleteLetter(ShowAllLetters allLettersForm, Guid id)
        {
            _serviceClient.DeleteLetter(id);
            MessageBox.Show("Письмо удалено!");
            List<Letter> letters = _serviceClient.GetLettersOrderByDate();
            List<string> nameLetters = new List<string>();
            foreach (var letter in letters)
            {
                nameLetters.Add(letter.name);
            }

            allLettersForm.SetLetters = letters;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new ShowAllLetters())
            {
                List<Letter> letters = _serviceClient.GetLettersOrderByDate();
                List<string> nameLetters = new List<string>();
                foreach (var letter in letters)
                {
                    nameLetters.Add(letter.name);
                }

                form.SetLetters = letters;
                form.ShowDialog();
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            _serviceClient = new ServiceClient("http://localhost:57893/api/");
        }
        private List<string> GetAllWorkers()
        {
            List<User> users = _serviceClient.GetWorkers();
            List<string> nameUsers = new List<string>();
            foreach (var user in users)
            {
                nameUsers.Add(user.name + " (" + user.login + ")");
            }
            return nameUsers;
        }
        private void AddLetter_Click(object sender, EventArgs e)
        {
            var nameUsers = GetAllWorkers();

            using (var form = new AddLetters())
            {
                form.SetWorkers = nameUsers;
                form.ShowDialog();
            }
        }
    }
}
