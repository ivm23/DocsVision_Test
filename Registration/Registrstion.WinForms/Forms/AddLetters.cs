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
    public partial class AddLetters : Form
    {

        public AddLetters()
        {
            InitializeComponent();
        }

        public List<string> SetWorkers
        {
            set
            {
                infoLetterControl1.SetWorkers = value;
            }
        }

        public string GetSender
        {
            get
            {
                return infoLetterControl1.GetSender;
            }
        }

    }
}
