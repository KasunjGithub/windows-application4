namespace uovapp
{
    partial class WelcomeForm
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
            this.btnsignup = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsignup
            // 
            this.btnsignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsignup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsignup.Location = new System.Drawing.Point(208, 366);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(91, 35);
            this.btnsignup.TabIndex = 6;
            this.btnsignup.Text = "SignUp";
            this.btnsignup.UseVisualStyleBackColor = false;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnlogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnlogout.Location = new System.Drawing.Point(358, 366);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(91, 35);
            this.btnlogout.TabIndex = 7;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::uovapp.Properties.Resources.WELCOMEBOARDIMAGE;
            this.ClientSize = new System.Drawing.Size(576, 425);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnsignup);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.Button btnlogout;
    }
}