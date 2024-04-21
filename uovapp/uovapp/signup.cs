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
    public partial class signupForm : Form
    {
        //public static string firstname;
        public string firstname;
        public static string lasttname;
        public static string email;
        public static string mobile;
        public static bool course;
        public static bool exam;
        public static bool hostel;
        public static string dob;

        //signupForm sf=new signupForm();
        //create the object for confirmation form to show the confirmation form
        
        public signupForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ckexam_CheckedChanged(object sender, EventArgs e)
        {
            if(ckcourse.Checked)
            {
                course = true;
                labelcoursenoti.Text = "check your mail";
            }
            else
            {
                course = false;
                labelcoursenoti.Text = "***";
            }
        }

        private void signupForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            ConfirmatinForm c = new ConfirmatinForm(txtfn.Text);
           // ConfirmatinForm c = new ConfirmatinForm();
            firstname =txtfn.Text;
            lasttname=txtln.Text;
            email=txtemail.Text;
            mobile = txtmobile.Text;
            dob=dtpicker.Value.ToShortDateString();

            this.Hide();
            c.Show();
        }

        private void ckexam_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ckexam.Checked)
            {
               exam = true;
                labelexamnoti.Text = "charges may apply";
            }
            else
            {
                exam = false;
                labelexamnoti.Text = "***";
            }

        }

        private void ckhostel_CheckedChanged(object sender, EventArgs e)
        {
            if (ckhostel.Checked)
            {
                hostel = true;
                labelhostelnoti.Text = "charges may apply";
            }
            else
            {
                hostel = false;
                labelhostelnoti.Text = "***";
            }

        }
    }
}
