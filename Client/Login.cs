using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btConnect_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.UserName = textUserName.Text;
            f1.Show();
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
