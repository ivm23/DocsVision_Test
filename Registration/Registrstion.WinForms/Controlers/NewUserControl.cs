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
    public partial class NewUserControl : UserControl
    {
        public NewUserControl()
        {
            InitializeComponent();
        }

        public string SetLogin
        {
            set
            {
                LoginWorkerTB.Text = value;
                LoginWorkerTB.Enabled = false;
            }
        }

        public string GetName
        {
            get
            {
                return NameWorkerTB.Text;
            }
        }
        public string GetLogin
        {
            get
            {
                return LoginWorkerTB.Text;
            }
        }

        public bool SetEnable
        {
            set { LoginWorkerTB.Enabled = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
