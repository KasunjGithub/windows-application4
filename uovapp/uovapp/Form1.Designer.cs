namespace uovapp
{
    partial class LoginForm
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
            this.labeluserid = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labeluserid
            // 
            this.labeluserid.AutoSize = true;
            this.labeluserid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluserid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labeluserid.Location = new System.Drawing.Point(195, 215);
            this.labeluserid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeluserid.Name = "labeluserid";
            this.labeluserid.Size = new System.Drawing.Size(105, 32);
            this.labeluserid.TabIndex = 1;
            this.labeluserid.Text = "UserID :";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelpassword.Location = new System.Drawing.Point(195, 267);
            this.labelpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(136, 32);
            this.labelpassword.TabIndex = 2;
            this.labelpassword.Text = "Password :";
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(355, 215);
            this.txtuserid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(172, 22);
            this.txtuserid.TabIndex = 3;
            this.txtuserid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(355, 274);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(172, 22);
            this.txtpassword.TabIndex = 4;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnlogin.Location = new System.Drawing.Point(280, 352);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(121, 43);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnreset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnreset.Location = new System.Drawing.Point(453, 352);
            this.btnreset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(121, 43);
            this.btnreset.TabIndex = 6;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::uovapp.Properties.Resources.uovlogo;
            this.pictureBox1.Location = new System.Drawing.Point(252, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 475);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.labeluserid);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labeluserid;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnreset;
    }
}

