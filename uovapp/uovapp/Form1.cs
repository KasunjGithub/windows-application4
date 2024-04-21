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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string userid=txtuserid.Text;
            string password=txtpassword.Text;

            if(userid=="uov125"&&password=="uov2023")
            {
                WelcomeForm wf= new WelcomeForm();
                wf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("UserID or Password is incorrect..");
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtuserid.Text = " ";
            txtpassword.Text = " ";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
