namespace Logat504
{
    partial class frmViewMarks
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
            this.Grd_Marks = new System.Windows.Forms.DataGridView();
            this.Cmb_Users = new System.Windows.Forms.ComboBox();
            this.Lbl_Users = new System.Windows.Forms.Label();
            this.Btn_ViewMarks = new System.Windows.Forms.Button();
            this.UserNAme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AzmoonTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AzmoonDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfUsr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNameOfUsr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoalateSahih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoalateEshtebah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedooneJavab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Marks)).BeginInit();
            this.SuspendLayout();
            // 
            // Grd_Marks
            // 
            this.Grd_Marks.AllowUserToAddRows = false;
            this.Grd_Marks.AllowUserToDeleteRows = false;
            this.Grd_Marks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Marks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserNAme,
            this.AzmoonTitle,
            this.AzmoonDate,
            this.NameOfUsr,
            this.SNameOfUsr,
            this.SoalateSahih,
            this.SoalateEshtebah,
            this.BedooneJavab,
            this.TotalMark});
            this.Grd_Marks.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grd_Marks.Location = new System.Drawing.Point(0, 0);
            this.Grd_Marks.Name = "Grd_Marks";
            this.Grd_Marks.ReadOnly = true;
            this.Grd_Marks.Size = new System.Drawing.Size(838, 366);
            this.Grd_Marks.TabIndex = 0;
            // 
            // Cmb_Users
            // 
            this.Cmb_Users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Users.FormattingEnabled = true;
            this.Cmb_Users.Location = new System.Drawing.Point(37, 394);
            this.Cmb_Users.Name = "Cmb_Users";
            this.Cmb_Users.Size = new System.Drawing.Size(703, 22);
            this.Cmb_Users.TabIndex = 1;
            // 
            // Lbl_Users
            // 
            this.Lbl_Users.AutoSize = true;
            this.Lbl_Users.Location = new System.Drawing.Point(769, 397);
            this.Lbl_Users.Name = "Lbl_Users";
            this.Lbl_Users.Size = new System.Drawing.Size(57, 16);
            this.Lbl_Users.TabIndex = 2;
            this.Lbl_Users.Text = "نام کاربر:";
            // 
            // Btn_ViewMarks
            // 
            this.Btn_ViewMarks.Image = global::Logat504.Properties.Resources.View;
            this.Btn_ViewMarks.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_ViewMarks.Location = new System.Drawing.Point(372, 431);
            this.Btn_ViewMarks.Name = "Btn_ViewMarks";
            this.Btn_ViewMarks.Size = new System.Drawing.Size(106, 62);
            this.Btn_ViewMarks.TabIndex = 3;
            this.Btn_ViewMarks.Text = "مشاهده نمره";
            this.Btn_ViewMarks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ViewMarks.UseVisualStyleBackColor = true;
            this.Btn_ViewMarks.Click += new System.EventHandler(this.Btn_ViewMarks_Click);
            // 
            // UserNAme
            // 
            this.UserNAme.DataPropertyName = "UserNAme";
            this.UserNAme.HeaderText = "نام کاربری";
            this.UserNAme.Name = "UserNAme";
            this.UserNAme.Width = 150;
            // 
            // AzmoonTitle
            // 
            this.AzmoonTitle.DataPropertyName = "AzmoonTitle";
            this.AzmoonTitle.HeaderText = "عنوان آزمون";
            this.AzmoonTitle.Name = "AzmoonTitle";
            this.AzmoonTitle.Width = 250;
            // 
            // AzmoonDate
            // 
            this.AzmoonDate.DataPropertyName = "AzmoonDate";
            this.AzmoonDate.HeaderText = "تاریخ آزمون";
            this.AzmoonDate.Name = "AzmoonDate";
            this.AzmoonDate.Width = 150;
            // 
            // NameOfUsr
            // 
            this.NameOfUsr.DataPropertyName = "NameOfUsr";
            this.NameOfUsr.HeaderText = "نام";
            this.NameOfUsr.Name = "NameOfUsr";
            this.NameOfUsr.Width = 150;
            // 
            // SNameOfUsr
            // 
            this.SNameOfUsr.DataPropertyName = "SNameOfUsr";
            this.SNameOfUsr.HeaderText = "نام خانوادگی";
            this.SNameOfUsr.Name = "SNameOfUsr";
            this.SNameOfUsr.Width = 150;
            // 
            // SoalateSahih
            // 
            this.SoalateSahih.DataPropertyName = "SoalateSahih";
            this.SoalateSahih.HeaderText = "جواب صحیح";
            this.SoalateSahih.Name = "SoalateSahih";
            this.SoalateSahih.Width = 150;
            // 
            // SoalateEshtebah
            // 
            this.SoalateEshtebah.DataPropertyName = "SoalateEshtebah";
            this.SoalateEshtebah.HeaderText = "سوالات اشتباه";
            this.SoalateEshtebah.Name = "SoalateEshtebah";
            this.SoalateEshtebah.Width = 150;
            // 
            // BedooneJavab
            // 
            this.BedooneJavab.DataPropertyName = "BedooneJavab";
            this.BedooneJavab.HeaderText = "بدون جواب";
            this.BedooneJavab.Name = "BedooneJavab";
            this.BedooneJavab.Width = 150;
            // 
            // TotalMark
            // 
            this.TotalMark.DataPropertyName = "TotalMark";
            this.TotalMark.HeaderText = "نمره اخذ شده";
            this.TotalMark.Name = "TotalMark";
            this.TotalMark.Width = 150;
            // 
            // frmViewMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 505);
            this.Controls.Add(this.Btn_ViewMarks);
            this.Controls.Add(this.Lbl_Users);
            this.Controls.Add(this.Cmb_Users);
            this.Controls.Add(this.Grd_Marks);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmViewMarks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مشاهده نمرات";
            this.Load += new System.EventHandler(this.frmViewMarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Marks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grd_Marks;
        private System.Windows.Forms.ComboBox Cmb_Users;
        private System.Windows.Forms.Label Lbl_Users;
        private System.Windows.Forms.Button Btn_ViewMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNAme;
        private System.Windows.Forms.DataGridViewTextBoxColumn AzmoonTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn AzmoonDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfUsr;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNameOfUsr;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoalateSahih;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoalateEshtebah;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedooneJavab;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMark;
    }
}