using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uovapp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm lf=new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            signupForm sf=new signupForm();
            sf.Show();
            this.Hide();
        }
    }
}
