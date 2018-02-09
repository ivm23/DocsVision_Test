using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registration.Model;

namespace Registrstion.WinForms.Forms
{
    public partial class ChangeLetter : Form
    {
        public ChangeLetter()
        {
            InitializeComponent();
        }

        public string NameLetter
        {
            set { NameLetterTB.Text = value; }
            get { return NameLetterTB.Text; }
        }

        public List<string> SetAllWorkers
        {
            set
            {
                LetterSenderCB.Items.Clear();
                foreach (var sender in value)
                {
                    LetterSenderCB.Items.Add(sender);
                }
                LetterSenderCB.Refresh();
            }
        }

        public string SetSender
        {
            set
            {
                LetterSenderCB.SelectedIndex = LetterSenderCB.FindStringExact(value);
            }
        }
        public string GetSender
        {
            get
            {
                return LetterSenderCB.Text;
            }
        }

        public List<string> SetAllReceivers
        {
            set { changeReceiversControl1.SetAllReceivers = value; }
        }
        public List<string> GetSelectAllReceivers
        {
            get { return changeReceiversControl1.GetSelectAllReceivers; }
        }
        public List<string> SetLetterReceivers
        {
            set { changeReceiversControl1.SetLetterReceivers = value; }
        }
        public List<string> GetSelectLetterReceivers
        {
            get { return changeReceiversControl1.GetSelectLetterReceivers; }
        }

        public string SetTextLetter
        {
            set { LetterTextTB.Text = value; }
        }
        public string GetTextLetter
        {
            get { return LetterTextTB.Text; }
        }
        public List<string> GetLetterReceivers
        {
            get { return changeReceiversControl1.GetLetterReceivers; }            
        }

        private void AddNewWorkerB_Click(object sender, EventArgs e)
        {
            Data.EventHandlerMakeWorker(this);
        }

        private void UpdateLetterB_Click(object sender, EventArgs e)
        {
            Data.EventHandlerUpdateLetter(this);
        }
    }
}
