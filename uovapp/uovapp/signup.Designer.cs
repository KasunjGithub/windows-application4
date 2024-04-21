namespace uovapp
{
    partial class signupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelfn = new System.Windows.Forms.Label();
            this.txtfn = new System.Windows.Forms.TextBox();
            this.labelln = new System.Windows.Forms.Label();
            this.txtln = new System.Windows.Forms.TextBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.labelmobile = new System.Windows.Forms.Label();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelhostelnoti = new System.Windows.Forms.Label();
            this.labelexamnoti = new System.Windows.Forms.Label();
            this.labelcoursenoti = new System.Windows.Forms.Label();
            this.ckhostel = new System.Windows.Forms.CheckBox();
            this.ckexam = new System.Windows.Forms.CheckBox();
            this.ckcourse = new System.Windows.Forms.CheckBox();
            this.btnsignup = new System.Windows.Forms.Button();
            this.lbldob = new System.Windows.Forms.Label();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "SignUp-Form";
            // 
            // labelfn
            // 
            this.labelfn.AutoSize = true;
            this.labelfn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelfn.Location = new System.Drawing.Point(133, 57);
            this.labelfn.Name = "labelfn";
            this.labelfn.Size = new System.Drawing.Size(95, 24);
            this.labelfn.TabIndex = 1;
            this.labelfn.Text = "FirstName";
            // 
            // txtfn
            // 
            this.txtfn.Location = new System.Drawing.Point(281, 62);
            this.txtfn.Name = "txtfn";
            this.txtfn.Size = new System.Drawing.Size(179, 20);
            this.txtfn.TabIndex = 2;
            this.txtfn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelln
            // 
            this.labelln.AutoSize = true;
            this.labelln.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelln.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelln.Location = new System.Drawing.Point(133, 98);
            this.labelln.Name = "labelln";
            this.labelln.Size = new System.Drawing.Size(90, 24);
            this.labelln.TabIndex = 3;
            this.labelln.Text = "LastName";
            this.labelln.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtln
            // 
            this.txtln.Location = new System.Drawing.Point(281, 103);
            this.txtln.Name = "txtln";
            this.txtln.Size = new System.Drawing.Size(179, 20);
            this.txtln.TabIndex = 4;
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelemail.Location = new System.Drawing.Point(133, 140);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(121, 24);
            this.labelemail.TabIndex = 5;
            this.labelemail.Text = "EmailAddress";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(281, 145);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(179, 20);
            this.txtemail.TabIndex = 6;
            // 
            // labelmobile
            // 
            this.labelmobile.AutoSize = true;
            this.labelmobile.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelmobile.Location = new System.Drawing.Point(133, 190);
            this.labelmobile.Name = "labelmobile";
            this.labelmobile.Size = new System.Drawing.Size(132, 24);
            this.labelmobile.TabIndex = 7;
            this.labelmobile.Text = "MobileNumber";
            // 
            // txtmobile
            // 
            this.txtmobile.Location = new System.Drawing.Point(281, 195);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(179, 20);
            this.txtmobile.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelhostelnoti);
            this.groupBox1.Controls.Add(this.labelexamnoti);
            this.groupBox1.Controls.Add(this.labelcoursenoti);
            this.groupBox1.Controls.Add(this.ckhostel);
            this.groupBox1.Controls.Add(this.ckexam);
            this.groupBox1.Controls.Add(this.ckcourse);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(116, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 159);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelhostelnoti
            // 
            this.labelhostelnoti.AutoSize = true;
            this.labelhostelnoti.Location = new System.Drawing.Point(260, 96);
            this.labelhostelnoti.Name = "labelhostelnoti";
            this.labelhostelnoti.Size = new System.Drawing.Size(27, 20);
            this.labelhostelnoti.TabIndex = 5;
            this.labelhostelnoti.Text = "***";
            // 
            // labelexamnoti
            // 
            this.labelexamnoti.AutoSize = true;
            this.labelexamnoti.Location = new System.Drawing.Point(260, 67);
            this.labelexamnoti.Name = "labelexamnoti";
            this.labelexamnoti.Size = new System.Drawing.Size(27, 20);
            this.labelexamnoti.TabIndex = 4;
            this.labelexamnoti.Text = "***";
            // 
            // labelcoursenoti
            // 
            this.labelcoursenoti.AutoSize = true;
            this.labelcoursenoti.Location = new System.Drawing.Point(260, 38);
            this.labelcoursenoti.Name = "labelcoursenoti";
            this.labelcoursenoti.Size = new System.Drawing.Size(27, 20);
            this.labelcoursenoti.TabIndex = 3;
            this.labelcoursenoti.Text = "***";
            // 
            // ckhostel
            // 
            this.ckhostel.AutoSize = true;
            this.ckhostel.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckhostel.Location = new System.Drawing.Point(11, 96);
            this.ckhostel.Name = "ckhostel";
            this.ckhostel.Size = new System.Drawing.Size(214, 23);
            this.ckhostel.TabIndex = 2;
            this.ckhostel.Text = "Hostel Accommodation Form";
            this.ckhostel.UseVisualStyleBackColor = true;
            this.ckhostel.CheckedChanged += new System.EventHandler(this.ckhostel_CheckedChanged);
            // 
            // ckexam
            // 
            this.ckexam.AutoSize = true;
            this.ckexam.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckexam.Location = new System.Drawing.Point(11, 67);
            this.ckexam.Name = "ckexam";
            this.ckexam.Size = new System.Drawing.Size(141, 23);
            this.ckexam.TabIndex = 1;
            this.ckexam.Text = "Exam Entry Form";
            this.ckexam.UseVisualStyleBackColor = true;
            this.ckexam.CheckedChanged += new System.EventHandler(this.ckexam_CheckedChanged_1);
            // 
            // ckcourse
            // 
            this.ckcourse.AutoSize = true;
            this.ckcourse.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckcourse.Location = new System.Drawing.Point(11, 38);
            this.ckcourse.Name = "ckcourse";
            this.ckcourse.Size = new System.Drawing.Size(194, 23);
            this.ckcourse.TabIndex = 0;
            this.ckcourse.Text = "Course Registration Form";
            this.ckcourse.UseVisualStyleBackColor = true;
            this.ckcourse.CheckedChanged += new System.EventHandler(this.ckexam_CheckedChanged);
            // 
            // btnsignup
            // 
            this.btnsignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsignup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsignup.Location = new System.Drawing.Point(403, 436);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(91, 35);
            this.btnsignup.TabIndex = 8;
            this.btnsignup.Text = "SignUp";
            this.btnsignup.UseVisualStyleBackColor = false;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbldob.Location = new System.Drawing.Point(136, 230);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(116, 24);
            this.lbldob.TabIndex = 10;
            this.lbldob.Text = "Date of Birth";
            // 
            // dtpicker
            // 
            this.dtpicker.Location = new System.Drawing.Point(281, 230);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(179, 20);
            this.dtpicker.TabIndex = 11;
            // 
            // signupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(577, 466);
            this.Controls.Add(this.dtpicker);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtmobile);
            this.Controls.Add(this.labelmobile);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.txtln);
            this.Controls.Add(this.labelln);
            this.Controls.Add(this.txtfn);
            this.Controls.Add(this.labelfn);
            this.Controls.Add(this.label1);
            this.Name = "signupForm";
            this.Text = "signupForm";
            this.Load += new System.EventHandler(this.signupForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelfn;
        private System.Windows.Forms.TextBox txtfn;
        private System.Windows.Forms.Label labelln;
        private System.Windows.Forms.TextBox txtln;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label labelmobile;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckexam;
        private System.Windows.Forms.CheckBox ckcourse;
        private System.Windows.Forms.CheckBox ckhostel;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.Label labelhostelnoti;
        private System.Windows.Forms.Label labelexamnoti;
        private System.Windows.Forms.Label labelcoursenoti;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.DateTimePicker dtpicker;
    }
}