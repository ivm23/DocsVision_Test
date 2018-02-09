using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registrstion.WinForms.Controlers
{
    public partial class ChangeReceiversControl : UserControl
    {
        private List<string> tempDelete = new List<string>();
        private List<string> tempAdd = new List<string>();

        public ChangeReceiversControl()
        {
            InitializeComponent();
        }

        private void SetReceivers(ref CheckedListBox LB, List<string> value)
        {
            LB.Items.Clear();
            foreach (var receiver in value)
            {
                LB.Items.Add(receiver);
            }
            LB.Refresh();
        }

        private void GetReceivers(ref List<string> receivers, ref CheckedListBox LB)
        {
            foreach (var item in LB.CheckedItems)
            {
                receivers.Add(Convert.ToString(item));
            }
        }

        public List<string> SetAllReceivers
        {
            set { SetReceivers(ref AllReceiversLB, value); }
        }

        public List<string> GetSelectAllReceivers
        {
            get
            {
                var selectReceivers = new List<string>();
                GetReceivers(ref selectReceivers, ref AllReceiversLB);
                return selectReceivers;
            }
        }

        public List<string> SetLetterReceivers
        {
            set { SetReceivers(ref LetterReceiversLB, value); }
        }
        public List<string> GetLetterReceivers
        {
            get
            {
                var letterReceivers = new List<string>();
                foreach(var rec in LetterReceiversLB.Items)
                {
                    letterReceivers.Add(Convert.ToString(rec));
                }
                return letterReceivers;
            }
        }

        public List<string> GetSelectLetterReceivers
        {
            get
            {
                var selectReceivers = new List<string>();
                GetReceivers(ref selectReceivers, ref LetterReceiversLB);
                return selectReceivers;
            }
        }
        public List<string> GetTempDelete
        {
            get { return tempDelete; }
        }
        public List<string> GetTempAdd
        {
            get { return tempAdd; }
        }
        private void AddReceiversB_Click(object sender, EventArgs e)
        {
            tempAdd = GetLetterReceivers;
            var temp = GetSelectAllReceivers;
            foreach (var t in temp)
            {
                if (tempAdd.IndexOf(t) == -1) tempAdd.Add(t);
            }
            SetLetterReceivers = tempAdd;
        }

        private void DeleteReceiversB_Click(object sender, EventArgs e)
        {
            tempDelete = GetLetterReceivers;
            var temp = GetSelectLetterReceivers;
            foreach(var t in temp)
            {
                if (tempDelete.IndexOf(t) != -1) tempDelete.Remove(t);
            }
            SetLetterReceivers = tempDelete;
        }
    }
}
