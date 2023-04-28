namespace Logat504
{
    partial class frmEditProfiles
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cmb_UserType = new System.Windows.Forms.ComboBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Lbl_Pass = new System.Windows.Forms.Label();
            this.Txt_UserName = new System.Windows.Forms.TextBox();
            this.Lbl_UserName = new System.Windows.Forms.Label();
            this.Txt_Tell = new System.Windows.Forms.TextBox();
            this.Txt_Family = new System.Windows.Forms.TextBox();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Lbl_UserType = new System.Windows.Forms.Label();
            this.Lbl_Tell = new System.Windows.Forms.Label();
            this.Lbl_Family = new System.Windows.Forms.Label();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.Lbl_Search = new System.Windows.Forms.Label();
            this.UserNAme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPWA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfUsr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNameOfUsr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobilePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailOfUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserNAme,
            this.UserPWA,
            this.UserTypeID,
            this.NameOfUsr,
            this.SNameOfUsr,
            this.MobilePhone,
            this.EmailOfUser});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(796, 254);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Cmb_UserType
            // 
            this.Cmb_UserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_UserType.FormattingEnabled = true;
            this.Cmb_UserType.Location = new System.Drawing.Point(522, 364);
            this.Cmb_UserType.Name = "Cmb_UserType";
            this.Cmb_UserType.Size = new System.Drawing.Size(187, 21);
            this.Cmb_UserType.TabIndex = 116;
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(522, 286);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(187, 21);
            this.Txt_Password.TabIndex = 115;
            // 
            // Lbl_Pass
            // 
            this.Lbl_Pass.AutoSize = true;
            this.Lbl_Pass.Location = new System.Drawing.Point(715, 290);
            this.Lbl_Pass.Name = "Lbl_Pass";
            this.Lbl_Pass.Size = new System.Drawing.Size(56, 13);
            this.Lbl_Pass.TabIndex = 114;
            this.Lbl_Pass.Text = "کلمه عبور:";
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Location = new System.Drawing.Point(522, 260);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Size = new System.Drawing.Size(187, 21);
            this.Txt_UserName.TabIndex = 113;
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.AutoSize = true;
            this.Lbl_UserName.Location = new System.Drawing.Point(715, 263);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.Size = new System.Drawing.Size(57, 13);
            this.Lbl_UserName.TabIndex = 112;
            this.Lbl_UserName.Text = "نام کاربری:";
            // 
            // Txt_Tell
            // 
            this.Txt_Tell.Location = new System.Drawing.Point(522, 391);
            this.Txt_Tell.Name = "Txt_Tell";
            this.Txt_Tell.Size = new System.Drawing.Size(187, 21);
            this.Txt_Tell.TabIndex = 109;
            // 
            // Txt_Family
            // 
            this.Txt_Family.Location = new System.Drawing.Point(522, 337);
            this.Txt_Family.Name = "Txt_Family";
            this.Txt_Family.Size = new System.Drawing.Size(187, 21);
            this.Txt_Family.TabIndex = 108;
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(522, 311);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(187, 21);
            this.Txt_Name.TabIndex = 107;
            // 
            // Lbl_UserType
            // 
            this.Lbl_UserType.AutoSize = true;
            this.Lbl_UserType.Location = new System.Drawing.Point(718, 364);
            this.Lbl_UserType.Name = "Lbl_UserType";
            this.Lbl_UserType.Size = new System.Drawing.Size(49, 13);
            this.Lbl_UserType.TabIndex = 105;
            this.Lbl_UserType.Text = "نوع کاربر:";
            // 
            // Lbl_Tell
            // 
            this.Lbl_Tell.AutoSize = true;
            this.Lbl_Tell.Location = new System.Drawing.Point(715, 395);
            this.Lbl_Tell.Name = "Lbl_Tell";
            this.Lbl_Tell.Size = new System.Drawing.Size(61, 13);
            this.Lbl_Tell.TabIndex = 103;
            this.Lbl_Tell.Text = "تلفن تماس:";
            // 
            // Lbl_Family
            // 
            this.Lbl_Family.AutoSize = true;
            this.Lbl_Family.Location = new System.Drawing.Point(715, 339);
            this.Lbl_Family.Name = "Lbl_Family";
            this.Lbl_Family.Size = new System.Drawing.Size(69, 13);
            this.Lbl_Family.TabIndex = 102;
            this.Lbl_Family.Text = "نام خانوادگی:";
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(715, 314);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(24, 13);
            this.Lbl_Name.TabIndex = 101;
            this.Lbl_Name.Text = "نام:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(715, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 117;
            this.label1.Text = "آدرس ایمیل:";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(418, 419);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(291, 21);
            this.Txt_Email.TabIndex = 118;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Image = global::Logat504.Properties.Resources.Search_Sm;
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Search.Location = new System.Drawing.Point(12, 286);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(90, 83);
            this.Btn_Search.TabIndex = 122;
            this.Btn_Search.Text = "جستجو کردن";
            this.Btn_Search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Image = global::Logat504.Properties.Resources.Edit_Btn_Sm;
            this.Btn_Edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Edit.Location = new System.Drawing.Point(203, 285);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(90, 83);
            this.Btn_Edit.TabIndex = 121;
            this.Btn_Edit.Text = "ویرایش کردن";
            this.Btn_Edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Image = global::Logat504.Properties.Resources.Delete_Btn_Sm;
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Delete.Location = new System.Drawing.Point(107, 285);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(90, 83);
            this.Btn_Delete.TabIndex = 120;
            this.Btn_Delete.Text = "حذف کردن";
            this.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Image = global::Logat504.Properties.Resources.Add_Btn_Sm;
            this.Btn_Add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Add.Location = new System.Drawing.Point(299, 286);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(84, 83);
            this.Btn_Add.TabIndex = 119;
            this.Btn_Add.Text = "اضافه کردن";
            this.Btn_Add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Image = global::Logat504.Properties.Resources.Save_Sma;
            this.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Save.Location = new System.Drawing.Point(299, 285);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(84, 83);
            this.Btn_Save.TabIndex = 123;
            this.Btn_Save.Text = "ذخیره";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Image = global::Logat504.Properties.Resources.refresh1001_Sm;
            this.Btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Refresh.Location = new System.Drawing.Point(12, 285);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(90, 83);
            this.Btn_Refresh.TabIndex = 124;
            this.Btn_Refresh.Text = "بازنشانی";
            this.Btn_Refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Txt_Search
            // 
            this.Txt_Search.Location = new System.Drawing.Point(12, 387);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(227, 21);
            this.Txt_Search.TabIndex = 126;
            // 
            // Lbl_Search
            // 
            this.Lbl_Search.AutoSize = true;
            this.Lbl_Search.Location = new System.Drawing.Point(245, 390);
            this.Lbl_Search.Name = "Lbl_Search";
            this.Lbl_Search.Size = new System.Drawing.Size(139, 13);
            this.Lbl_Search.TabIndex = 125;
            this.Lbl_Search.Text = "جستجو بر اساس نام کاربری:";
            // 
            // UserNAme
            // 
            this.UserNAme.DataPropertyName = "UserNAme";
            this.UserNAme.HeaderText = "نام کاربری";
            this.UserNAme.Name = "UserNAme";
            this.UserNAme.ReadOnly = true;
            // 
            // UserPWA
            // 
            this.UserPWA.DataPropertyName = "UserPWA";
            this.UserPWA.HeaderText = "کلمه عبور";
            this.UserPWA.Name = "UserPWA";
            this.UserPWA.ReadOnly = true;
            // 
            // UserTypeID
            // 
            this.UserTypeID.DataPropertyName = "UserTypeID";
            this.UserTypeID.HeaderText = "نوع کاربر";
            this.UserTypeID.Name = "UserTypeID";
            this.UserTypeID.ReadOnly = true;
            // 
            // NameOfUsr
            // 
            this.NameOfUsr.DataPropertyName = "NameOfUsr";
            this.NameOfUsr.HeaderText = "نام";
            this.NameOfUsr.Name = "NameOfUsr";
            this.NameOfUsr.ReadOnly = true;
            // 
            // SNameOfUsr
            // 
            this.SNameOfUsr.DataPropertyName = "SNameOfUsr";
            this.SNameOfUsr.HeaderText = "نام خانوادگی";
            this.SNameOfUsr.Name = "SNameOfUsr";
            this.SNameOfUsr.ReadOnly = true;
            // 
            // MobilePhone
            // 
            this.MobilePhone.DataPropertyName = "MobilePhone";
            this.MobilePhone.HeaderText = "تلفن تماس";
            this.MobilePhone.Name = "MobilePhone";
            this.MobilePhone.ReadOnly = true;
            // 
            // EmailOfUser
            // 
            this.EmailOfUser.DataPropertyName = "EmailOfUser";
            this.EmailOfUser.HeaderText = "آدرس ایمیل";
            this.EmailOfUser.Name = "EmailOfUser";
            this.EmailOfUser.ReadOnly = true;
            this.EmailOfUser.Width = 150;
            // 
            // frmEditProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 453);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(this.Lbl_Search);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_UserType);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Lbl_Pass);
            this.Controls.Add(this.Txt_UserName);
            this.Controls.Add(this.Lbl_UserName);
            this.Controls.Add(this.Txt_Tell);
            this.Controls.Add(this.Txt_Family);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.Lbl_UserType);
            this.Controls.Add(this.Lbl_Tell);
            this.Controls.Add(this.Lbl_Family);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEditProfiles";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ویرایش کاربران";
            this.Load += new System.EventHandler(this.frmEditProfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Cmb_UserType;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label Lbl_Pass;
        private System.Windows.Forms.TextBox Txt_UserName;
        private System.Windows.Forms.Label Lbl_UserName;
        private System.Windows.Forms.TextBox Txt_Tell;
        private System.Windows.Forms.TextBox Txt_Family;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label Lbl_UserType;
        private System.Windows.Forms.Label Lbl_Tell;
        private System.Windows.Forms.Label Lbl_Family;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNAme;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPWA;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfUsr;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNameOfUsr;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobilePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailOfUser;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.Label Lbl_Search;
    }
}