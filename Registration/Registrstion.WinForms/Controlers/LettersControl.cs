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

namespace Registrstion.WinForms.Controlers
{
    public partial class LettersControl : UserControl
    {
        private List<Letter> letters = new List<Letter>();

        public LettersControl()
        {            
            InitializeComponent();
            AllLetters.SelectedIndexChanged += AllLetters_SelectedIndexChanged;   
        }

        public List<Letter> SetLetters
        {
            set
            {
                AllLetters.Items.Clear();
                letters.Clear();
                foreach(var letter in value)
                {
                    AllLetters.Items.Add(letter.name);
                    letters.Add(letter);
                }   
                
            }
        }        

        public List<string> SetInfo
        {
            set
            {
                InfoLetter.Text = "";
                if (null != value)
                {
                    foreach (var letter in value)
                    {
                        InfoLetter.Text += letter + Environment.NewLine;
                    }
                }
            }
        }

        public Letter GetLetterChanged
        {
            get
            {
                var index = AllLetters.SelectedIndex;
                return (index != -1 ? letters[index] : null);
            }
        }

        private void Sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetInfo = null;
            Data.EventHandlerOrder(SortCB.SelectedIndex);
        }

        private void AllLetters_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = AllLetters.SelectedIndex;
            if (index != -1)
            {
                Data.EventHandlerInfo(letters[index].id);
            }
        }
    }
}
