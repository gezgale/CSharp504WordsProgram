namespace Logat504
{
    partial class frmMainMdi
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Mnu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSabtLogatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_File_Serach = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnu_File_DefExam = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_File_AzmoonType = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_File_DefExamDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Exam = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Exam_Ex = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnu_Exam_Savabegh = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Secur = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Secur_EditProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnu_Secur_EditUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Reports = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Reports_Azmoonah = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_File,
            this.Mnu_Exam,
            this.Mnu_Secur,
            this.Mnu_Reports});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(892, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // Mnu_File
            // 
            this.Mnu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileSabtLogatToolStripMenuItem,
            this.Mnu_File_Serach,
            this.toolStripMenuItem1,
            this.Mnu_File_DefExam,
            this.Mnu_File_AzmoonType,
            this.Mnu_File_DefExamDetails,
            this.toolStripMenuItem2,
            this.Mnu_File_Exit});
            this.Mnu_File.Image = global::Logat504.Properties.Resources.application_form_edit;
            this.Mnu_File.Name = "Mnu_File";
            this.Mnu_File.Size = new System.Drawing.Size(85, 21);
            this.Mnu_File.Text = "پرونده     |";
            // 
            // mnuFileSabtLogatToolStripMenuItem
            // 
            this.mnuFileSabtLogatToolStripMenuItem.Image = global::Logat504.Properties.Resources.save11;
            this.mnuFileSabtLogatToolStripMenuItem.Name = "mnuFileSabtLogatToolStripMenuItem";
            this.mnuFileSabtLogatToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.mnuFileSabtLogatToolStripMenuItem.Text = "ثبت لغات و اصطلاحات";
            this.mnuFileSabtLogatToolStripMenuItem.Click += new System.EventHandler(this.mnuFileSabtLogatToolStripMenuItem_Click);
            // 
            // Mnu_File_Serach
            // 
            this.Mnu_File_Serach.Image = global::Logat504.Properties.Resources.Windows_Explorer_icon;
            this.Mnu_File_Serach.Name = "Mnu_File_Serach";
            this.Mnu_File_Serach.Size = new System.Drawing.Size(202, 22);
            this.Mnu_File_Serach.Text = "جستجوی لغات و اصطلاحات";
            this.Mnu_File_Serach.Click += new System.EventHandler(this.Mnu_File_Serach_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 6);
            // 
            // Mnu_File_DefExam
            // 
            this.Mnu_File_DefExam.Image = global::Logat504.Properties.Resources.Exam;
            this.Mnu_File_DefExam.Name = "Mnu_File_DefExam";
            this.Mnu_File_DefExam.Size = new System.Drawing.Size(202, 22);
            this.Mnu_File_DefExam.Text = "تعریف آزمون";
            this.Mnu_File_DefExam.Click += new System.EventHandler(this.Mnu_File_DefExam_Click);
            // 
            // Mnu_File_AzmoonType
            // 
            this.Mnu_File_AzmoonType.Image = global::Logat504.Properties.Resources.AddressBook;
            this.Mnu_File_AzmoonType.Name = "Mnu_File_AzmoonType";
            this.Mnu_File_AzmoonType.Size = new System.Drawing.Size(202, 22);
            this.Mnu_File_AzmoonType.Text = "نوع آزمون";
            this.Mnu_File_AzmoonType.Click += new System.EventHandler(this.Mnu_File_AzmoonType_Click);
            // 
            // Mnu_File_DefExamDetails
            // 
            this.Mnu_File_DefExamDetails.Image = global::Logat504.Properties.Resources.check_spelling;
            this.Mnu_File_DefExamDetails.Name = "Mnu_File_DefExamDetails";
            this.Mnu_File_DefExamDetails.Size = new System.Drawing.Size(202, 22);
            this.Mnu_File_DefExamDetails.Text = "تعریف جزئیات آزمونها";
            this.Mnu_File_DefExamDetails.Click += new System.EventHandler(this.Mnu_File_DefExamDetails_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(199, 6);
            // 
            // Mnu_File_Exit
            // 
            this.Mnu_File_Exit.Image = global::Logat504.Properties.Resources.logout2;
            this.Mnu_File_Exit.Name = "Mnu_File_Exit";
            this.Mnu_File_Exit.Size = new System.Drawing.Size(202, 22);
            this.Mnu_File_Exit.Text = "خروج";
            this.Mnu_File_Exit.Click += new System.EventHandler(this.Mnu_File_Exit_Click);
            // 
            // Mnu_Exam
            // 
            this.Mnu_Exam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Exam_Ex,
            this.toolStripMenuItem4,
            this.Mnu_Exam_Savabegh});
            this.Mnu_Exam.Image = global::Logat504.Properties.Resources.knetworkconf;
            this.Mnu_Exam.Name = "Mnu_Exam";
            this.Mnu_Exam.Size = new System.Drawing.Size(127, 21);
            this.Mnu_Exam.Text = "برگزاری آزمون     |";
            // 
            // Mnu_Exam_Ex
            // 
            this.Mnu_Exam_Ex.Image = global::Logat504.Properties.Resources.replace;
            this.Mnu_Exam_Ex.Name = "Mnu_Exam_Ex";
            this.Mnu_Exam_Ex.Size = new System.Drawing.Size(149, 22);
            this.Mnu_Exam_Ex.Text = "شرکت در آزمون";
            this.Mnu_Exam_Ex.Click += new System.EventHandler(this.Mnu_Exam_Ex_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(146, 6);
            // 
            // Mnu_Exam_Savabegh
            // 
            this.Mnu_Exam_Savabegh.Image = global::Logat504.Properties.Resources.logo_Chrt;
            this.Mnu_Exam_Savabegh.Name = "Mnu_Exam_Savabegh";
            this.Mnu_Exam_Savabegh.Size = new System.Drawing.Size(149, 22);
            this.Mnu_Exam_Savabegh.Text = "مشاهده نمرات";
            this.Mnu_Exam_Savabegh.Click += new System.EventHandler(this.Mnu_Exam_Savabegh_Click);
            // 
            // Mnu_Secur
            // 
            this.Mnu_Secur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Secur_EditProfile,
            this.toolStripMenuItem3,
            this.Mnu_Secur_EditUsers});
            this.Mnu_Secur.Image = global::Logat504.Properties.Resources.Vista_Shield;
            this.Mnu_Secur.Name = "Mnu_Secur";
            this.Mnu_Secur.Size = new System.Drawing.Size(122, 21);
            this.Mnu_Secur.Text = "تنظیمات امنیتی     |";
            // 
            // Mnu_Secur_EditProfile
            // 
            this.Mnu_Secur_EditProfile.Image = global::Logat504.Properties.Resources.offline_user_icon;
            this.Mnu_Secur_EditProfile.Name = "Mnu_Secur_EditProfile";
            this.Mnu_Secur_EditProfile.Size = new System.Drawing.Size(190, 22);
            this.Mnu_Secur_EditProfile.Text = "ویرایش مشخصات کاربری";
            this.Mnu_Secur_EditProfile.Click += new System.EventHandler(this.Mnu_Secur_EditProfile_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(187, 6);
            // 
            // Mnu_Secur_EditUsers
            // 
            this.Mnu_Secur_EditUsers.Image = global::Logat504.Properties.Resources.people;
            this.Mnu_Secur_EditUsers.Name = "Mnu_Secur_EditUsers";
            this.Mnu_Secur_EditUsers.Size = new System.Drawing.Size(190, 22);
            this.Mnu_Secur_EditUsers.Text = "ویرایش کاربران";
            this.Mnu_Secur_EditUsers.Click += new System.EventHandler(this.Mnu_Secur_EditUsers_Click);
            // 
            // Mnu_Reports
            // 
            this.Mnu_Reports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Reports_Azmoonah});
            this.Mnu_Reports.Image = global::Logat504.Properties.Resources.Traveler;
            this.Mnu_Reports.Name = "Mnu_Reports";
            this.Mnu_Reports.Size = new System.Drawing.Size(76, 21);
            this.Mnu_Reports.Text = "گزارشات";
            // 
            // Mnu_Reports_Azmoonah
            // 
            this.Mnu_Reports_Azmoonah.Image = global::Logat504.Properties.Resources.user_group_icon;
            this.Mnu_Reports_Azmoonah.Name = "Mnu_Reports_Azmoonah";
            this.Mnu_Reports_Azmoonah.Size = new System.Drawing.Size(142, 22);
            this.Mnu_Reports_Azmoonah.Text = "گزارش آزمونها";
            this.Mnu_Reports_Azmoonah.Click += new System.EventHandler(this.Mnu_Reports_Azmoonah_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 508);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(892, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // frmMainMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Logat504.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 530);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMainMdi";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم اصلی برنامه آموزش 504 لغت";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainMdi_FormClosed);
            this.Load += new System.EventHandler(this.frmMainMdi_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem Mnu_File;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Exam;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Secur;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Reports;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSabtLogatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Mnu_File_DefExam;
        private System.Windows.Forms.ToolStripMenuItem Mnu_File_DefExamDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Mnu_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Exam_Ex;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Secur_EditProfile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Secur_EditUsers;
        private System.Windows.Forms.ToolStripMenuItem Mnu_File_Serach;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Reports_Azmoonah;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Exam_Savabegh;
        private System.Windows.Forms.ToolStripMenuItem Mnu_File_AzmoonType;
    }
}



