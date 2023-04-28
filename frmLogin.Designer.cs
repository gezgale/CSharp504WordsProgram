namespace Logat504
{
    partial class frmLogin
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
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Txt_UserName = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Lbl_UserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(73, 33);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(180, 22);
            this.Txt_Password.TabIndex = 26;
            this.Txt_Password.UseSystemPasswordChar = true;
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Location = new System.Drawing.Point(73, 10);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Size = new System.Drawing.Size(180, 22);
            this.Txt_UserName.TabIndex = 25;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(272, 37);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(67, 16);
            this.Lbl_Password.TabIndex = 30;
            this.Lbl_Password.Text = "كلمه عبور:";
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.AutoSize = true;
            this.Lbl_UserName.Location = new System.Drawing.Point(272, 13);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.Size = new System.Drawing.Size(68, 16);
            this.Lbl_UserName.TabIndex = 29;
            this.Lbl_UserName.Text = "نام كاربري:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Logat504.Properties.Resources.Login0Manager;
            this.pictureBox1.Location = new System.Drawing.Point(5, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Image = global::Logat504.Properties.Resources.ZarbDarS;
            this.Btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cancel.Location = new System.Drawing.Point(84, 60);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(79, 25);
            this.Btn_Cancel.TabIndex = 28;
            this.Btn_Cancel.Text = "لغو";
            this.Btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Login.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Login.Image = global::Logat504.Properties.Resources.CheckMarkS;
            this.Btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Login.Location = new System.Drawing.Point(169, 60);
            this.Btn_Login.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(80, 25);
            this.Btn_Login.TabIndex = 27;
            this.Btn_Login.Text = "ورود";
            this.Btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 94);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_UserName);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Lbl_UserName);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Login);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود به سیستم";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.TextBox Txt_UserName;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.Label Lbl_UserName;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Login;
    }
}

