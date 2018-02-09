using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registrstion.WinForms.Forms
{
    public partial class NewWorker : Form
    {
        public NewWorker()
        {
            InitializeComponent();
        }

        public string SetLogin
        {
            set { newUserControl1.SetLogin = value; }
        }

        public string GetName
        {
            get { return newUserControl1.GetName; }
        }
        public string GetLogin
        {
            get { return newUserControl1.GetLogin; }
        }
        public bool SetEnable
        {
            set { newUserControl1.SetEnable = value; }
        }
    }
}
