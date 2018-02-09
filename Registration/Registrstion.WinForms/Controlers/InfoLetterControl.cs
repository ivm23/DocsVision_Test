using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registration.Model;
using Registration.DataInterface;

namespace Registrstion.WinForms.Controlers
{
    public partial class InfoLetterControl : UserControl
    {
        private List<string> allReceivers = new List<string>();
        private bool addSender = false;
        private bool addReceiver = false;

        public InfoLetterControl()
        {
            InitializeComponent();
            SenderCB.KeyPress += SenderCB_Entry;
            NameLetterTB.KeyPress += NameLetterTB_Entry;
            TextLetterTB.TextChanged += TextLetterTB_TextChanged;
        }
        public bool AddSender
        {
            set  { addSender = value; }
            get  { return addSender; }
        }
        public bool AddReceiver
        {
            set { addReceiver = value; }
            get { return addReceiver; }
        }
        public string GetNameLetter
        {
            get { return NameLetterTB.Text; }
        }

        public List<string> SetWorkers
        {
            set
            {
                foreach (var worker in value)
                {
                    SenderCB.Items.Add(worker);
                    ReceiversCB.Items.Add(worker);
                }
            }
        }

        public string GetSender
        {
            get { return SenderCB.Text; }
        }
        public string GetReceiver
        {
            get { return ReceiversCB.Text; }
        }

        public string SetValueToTextBox
        {
            set { InfoLetterTB.Text = value; }
        }

        public string GetValueToTextBox
        {
            get { return InfoLetterTB.Text; }
        }

        public string GetText
        {
            get { return TextLetterTB.Text; }
        }

        public string AddToAllReceivers
        {
            set { allReceivers.Add(value); }
        }

        public void ChangeText(ref string str, string tag, string newValue)
        {
            var index = str.IndexOf(tag);
            if (index == -1 || str == null)
            {
                str += tag + newValue + Environment.NewLine;
            }
            else
            {
                string strChange = "";
                while (str[index] != '\n')
                {
                    strChange += str[index];
                    ++index;
                }
                if (tag == "Содержание: ")
                    while (index < str.Length)
                    {
                        strChange += str[index];
                        ++index;
                    }
                str = str.Replace(strChange, tag + newValue + Environment.NewLine);
            }

        }

        private void SenderCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = GetValueToTextBox;
            ChangeText(ref str, "Отправитель: ", GetSender);

            SetValueToTextBox = str;
            ReceiversCB.Enabled = true;
            AddReceiverB.Enabled = true;
            NewReceiverB.Enabled = true;
        }

        private void SenderCB_Entry(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Data.EventHandlerAddWorker(this, true);
                if (addSender)
                {
                    ReceiversCB.Enabled = true;
                    AddReceiverB.Enabled = true;
                    NewReceiverB.Enabled = true;
                }
            }
        }

        private void NameLetterTB_Entry(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string str = GetValueToTextBox;
                ChangeText(ref str, "Название: ", GetNameLetter);
                SetValueToTextBox = str;
                SenderCB.Enabled = true;
            }
        }

        public void NameReceivers(ref string str, string newReceiver)
        {
            int index;
            if ((index = str.IndexOf("Получатели: ")) == -1)
            {
                str += "Получатели: " + newReceiver + ";" + Environment.NewLine;
            }
            else
            {
                while (str[index] != ';' && str[index + 1] != '\r')
                {
                    ++index;
                }
                str = str.Replace(";\r", "; " + newReceiver + ";" + Environment.NewLine);
            }
        }
        private void AddReceiver_Click(object sender, EventArgs e)
        {
            string str = GetValueToTextBox;
            var receiver = GetReceiver;
            var index = allReceivers.IndexOf(receiver);
            if (index == -1)
            {
                NameReceivers(ref str, receiver);
                SetValueToTextBox = str;
                TextLetterTB.Enabled = true;
                allReceivers.Add(receiver);
            }
        }

        private void TextLetterTB_TextChanged(object sender, EventArgs e)
        {
            string str = GetValueToTextBox;
            ChangeText(ref str, "Содержание: ", GetText);
            SetValueToTextBox = str;

            AddLetter.Enabled = true;
        }

        private void AddLetter_Click(object sender, EventArgs e)
        {
            Data.EventHandlerCreateLetter(GetNameLetter, GetSender, allReceivers, GetText);
        }

        private void NewReceiverB_Click(object sender, EventArgs e)
        {
            Data.EventHandlerAddWorker(this, false);
            if (addReceiver)
            {
                TextLetterTB.Enabled = true;
            }
        }
    }
}
