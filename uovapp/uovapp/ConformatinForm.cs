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
    public partial class ConfirmatinForm : Form
    {
       /* public ConfirmatinForm()
        {
            InitializeComponent();
            
        }*/
        public ConfirmatinForm(string fname)
        {
            InitializeComponent();
            labelfncon.Text = fname;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            
        }

        private void ConfirmatinForm_Load(object sender, EventArgs e)
        {
            //labelfncon.Text = signupForm.firstname;
            labellnconf.Text = signupForm.lasttname;
            labelemailcon.Text = signupForm.email;
            labelmobilecon.Text = signupForm.mobile;
            labeldobcf.Text= signupForm.dob;
            if (signupForm.course)
            {
                labelcoursecon.Text = "✓";
            }

            if (signupForm.exam)
            {
                labelexamcon.Text = "✓";
            }

            if (signupForm.hostel)
            {
                labelhostelcon.Text = "✓";
            }


        }

        private void labelfncon_Click(object sender, EventArgs e)
        {

        }
    }
}
