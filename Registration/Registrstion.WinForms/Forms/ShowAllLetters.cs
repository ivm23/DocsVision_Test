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

namespace Registrstion.WinForms
{
    public partial class ShowAllLetters : Form
    {
        public ShowAllLetters()
        {
            InitializeComponent();
            Data.EventHandlerOrder = new Data.MyEventOrder(Order);
            Data.EventHandlerInfo = new Data.MyEventInfo(Info);
        }
        void Order(int index)
        {
          Data.EventHandlerOrderBy(this, index);
        }
        void Info(Guid id)
        {
            Data.EventHandlerInfoLetter(this, id);
        }

        public List<Letter> SetLetters
        {
            set
            {
                lettersControl1.SetLetters = value;
            }
        }

        public List<string> SetInfo
        {
            set
            {
                lettersControl1.SetInfo = value;
            }
        }

        private void ChangeLetter_Click(object sender, EventArgs e)
        {
            var letterToChange = lettersControl1.GetLetterChanged;
            if (letterToChange != null) Data.EventHandlerChangeLetter(letterToChange);
            else
            {
                MessageBox.Show("Необходимо выбрать письмо для изменения!");
            }
        }

        private void DeleteLetter_Click(object sender, EventArgs e)
        {
            var letterToChange = lettersControl1.GetLetterChanged;
            if (letterToChange != null)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить письмо?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Data.EventHandlerDeleteLetter(this, letterToChange.id);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать письмо для удаления!");
            }
            
        }
    }
}
