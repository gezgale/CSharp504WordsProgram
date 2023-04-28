namespace Logat504
{
    partial class frmEditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditProfile));
            this.Lbl_UserName = new System.Windows.Forms.Label();
            this.Lbl_Pass = new System.Windows.Forms.Label();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_Family = new System.Windows.Forms.Label();
            this.Lbl_Tell = new System.Windows.Forms.Label();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Txt_UserName = new System.Windows.Forms.TextBox();
            this.Txt_Pass = new System.Windows.Forms.TextBox();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Txt_Family = new System.Windows.Forms.TextBox();
            this.Txt_Tell = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.AutoSize = true;
            this.Lbl_UserName.Location = new System.Drawing.Point(339, 24);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.Size = new System.Drawing.Size(60, 13);
            this.Lbl_UserName.TabIndex = 0;
            this.Lbl_UserName.Text = "نام کاربری :";
            // 
            // Lbl_Pass
            // 
            this.Lbl_Pass.AutoSize = true;
            this.Lbl_Pass.Location = new System.Drawing.Point(340, 56);
            this.Lbl_Pass.Name = "Lbl_Pass";
            this.Lbl_Pass.Size = new System.Drawing.Size(59, 13);
            this.Lbl_Pass.TabIndex = 1;
            this.Lbl_Pass.Text = "کلمه عبور :";
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(340, 89);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(27, 13);
            this.Lbl_Name.TabIndex = 2;
            this.Lbl_Name.Text = "نام :";
            // 
            // Lbl_Family
            // 
            this.Lbl_Family.AutoSize = true;
            this.Lbl_Family.Location = new System.Drawing.Point(339, 124);
            this.Lbl_Family.Name = "Lbl_Family";
            this.Lbl_Family.Size = new System.Drawing.Size(72, 13);
            this.Lbl_Family.TabIndex = 3;
            this.Lbl_Family.Text = "نام خانوادگی :";
            // 
            // Lbl_Tell
            // 
            this.Lbl_Tell.AutoSize = true;
            this.Lbl_Tell.Location = new System.Drawing.Point(339, 157);
            this.Lbl_Tell.Name = "Lbl_Tell";
            this.Lbl_Tell.Size = new System.Drawing.Size(64, 13);
            this.Lbl_Tell.TabIndex = 4;
            this.Lbl_Tell.Text = "تلفن تماس :";
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Location = new System.Drawing.Point(339, 187);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(67, 13);
            this.Lbl_Email.TabIndex = 5;
            this.Lbl_Email.Text = "آدرس ایمیل :";
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Location = new System.Drawing.Point(233, 21);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.ReadOnly = true;
            this.Txt_UserName.Size = new System.Drawing.Size(100, 21);
            this.Txt_UserName.TabIndex = 6;
            // 
            // Txt_Pass
            // 
            this.Txt_Pass.Location = new System.Drawing.Point(233, 51);
            this.Txt_Pass.Name = "Txt_Pass";
            this.Txt_Pass.Size = new System.Drawing.Size(100, 21);
            this.Txt_Pass.TabIndex = 7;
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(234, 85);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(100, 21);
            this.Txt_Name.TabIndex = 8;
            // 
            // Txt_Family
            // 
            this.Txt_Family.Location = new System.Drawing.Point(233, 120);
            this.Txt_Family.Name = "Txt_Family";
            this.Txt_Family.Size = new System.Drawing.Size(100, 21);
            this.Txt_Family.TabIndex = 9;
            // 
            // Txt_Tell
            // 
            this.Txt_Tell.Location = new System.Drawing.Point(157, 153);
            this.Txt_Tell.Name = "Txt_Tell";
            this.Txt_Tell.Size = new System.Drawing.Size(176, 21);
            this.Txt_Tell.TabIndex = 10;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(58, 187);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(275, 21);
            this.Txt_Email.TabIndex = 11;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Save.Image")));
            this.Btn_Save.Location = new System.Drawing.Point(173, 214);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(101, 82);
            this.Btn_Save.TabIndex = 12;
            this.Btn_Save.Text = "ویرایش مشخصات";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // frmEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 308);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Txt_Tell);
            this.Controls.Add(this.Txt_Family);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.Txt_Pass);
            this.Controls.Add(this.Txt_UserName);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Lbl_Tell);
            this.Controls.Add(this.Lbl_Family);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Lbl_Pass);
            this.Controls.Add(this.Lbl_UserName);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEditProfile";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ویرایش مشخصات کاربری";
            this.Load += new System.EventHandler(this.frmEditProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_UserName;
        private System.Windows.Forms.Label Lbl_Pass;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_Family;
        private System.Windows.Forms.Label Lbl_Tell;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.TextBox Txt_UserName;
        private System.Windows.Forms.TextBox Txt_Pass;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.TextBox Txt_Family;
        private System.Windows.Forms.TextBox Txt_Tell;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Button Btn_Save;
    }
}