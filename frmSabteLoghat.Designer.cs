namespace Logat504
{
    partial class frmSabteLoghat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSabteLoghat));
            this.Grd_Word = new System.Windows.Forms.DataGridView();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Txt_WordFarsi = new System.Windows.Forms.TextBox();
            this.Lbl_Farsi = new System.Windows.Forms.Label();
            this.Txt_WordEnglish = new System.Windows.Forms.TextBox();
            this.Lbl_english = new System.Windows.Forms.Label();
            this.Txt_Saier = new System.Windows.Forms.TextBox();
            this.Txt_Motaradef = new System.Windows.Forms.TextBox();
            this.Lbl_Saier = new System.Windows.Forms.Label();
            this.Lbl_Motaradef = new System.Windows.Forms.Label();
            this.Txt_LoghatId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Search = new System.Windows.Forms.Label();
            this.Rdo_English = new System.Windows.Forms.RadioButton();
            this.Rdo_Farsi = new System.Windows.Forms.RadioButton();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.LogatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogatEnglish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoghatFarsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoghatMotaradef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogatSaier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdderUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Word)).BeginInit();
            this.SuspendLayout();
            // 
            // Grd_Word
            // 
            this.Grd_Word.AllowUserToAddRows = false;
            this.Grd_Word.AllowUserToDeleteRows = false;
            this.Grd_Word.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Word.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogatID,
            this.LogatEnglish,
            this.LoghatFarsi,
            this.LoghatMotaradef,
            this.LogatSaier,
            this.DateOfAdd,
            this.AdderUserName});
            this.Grd_Word.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grd_Word.Location = new System.Drawing.Point(0, 0);
            this.Grd_Word.Name = "Grd_Word";
            this.Grd_Word.ReadOnly = true;
            this.Grd_Word.Size = new System.Drawing.Size(855, 248);
            this.Grd_Word.TabIndex = 0;
            this.Grd_Word.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_Word_CellClick);
            // 
            // Btn_Search
            // 
            this.Btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Search.Image")));
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Search.Location = new System.Drawing.Point(12, 364);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(90, 83);
            this.Btn_Search.TabIndex = 82;
            this.Btn_Search.Text = "جستجو کردن";
            this.Btn_Search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Edit.Image")));
            this.Btn_Edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Edit.Location = new System.Drawing.Point(204, 363);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(90, 83);
            this.Btn_Edit.TabIndex = 81;
            this.Btn_Edit.Text = "ویرایش کردن";
            this.Btn_Edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Delete.Image")));
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Delete.Location = new System.Drawing.Point(108, 363);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(90, 83);
            this.Btn_Delete.TabIndex = 80;
            this.Btn_Delete.Text = "حذف کردن";
            this.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Refresh.Image")));
            this.Btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Refresh.Location = new System.Drawing.Point(12, 363);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(90, 83);
            this.Btn_Refresh.TabIndex = 83;
            this.Btn_Refresh.Text = "بازنشانی";
            this.Btn_Refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(300, 363);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 83);
            this.btnAdd.TabIndex = 79;
            this.btnAdd.Text = "اضافه کردن";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Save.Image")));
            this.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Save.Location = new System.Drawing.Point(300, 363);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(84, 83);
            this.Btn_Save.TabIndex = 78;
            this.Btn_Save.Text = "ذخیره";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Txt_WordFarsi
            // 
            this.Txt_WordFarsi.Location = new System.Drawing.Point(390, 280);
            this.Txt_WordFarsi.Name = "Txt_WordFarsi";
            this.Txt_WordFarsi.Size = new System.Drawing.Size(363, 22);
            this.Txt_WordFarsi.TabIndex = 113;
            // 
            // Lbl_Farsi
            // 
            this.Lbl_Farsi.AutoSize = true;
            this.Lbl_Farsi.Location = new System.Drawing.Point(759, 284);
            this.Lbl_Farsi.Name = "Lbl_Farsi";
            this.Lbl_Farsi.Size = new System.Drawing.Size(92, 16);
            this.Lbl_Farsi.TabIndex = 112;
            this.Lbl_Farsi.Text = "معادل فارسی :";
            // 
            // Txt_WordEnglish
            // 
            this.Txt_WordEnglish.Location = new System.Drawing.Point(390, 254);
            this.Txt_WordEnglish.Name = "Txt_WordEnglish";
            this.Txt_WordEnglish.Size = new System.Drawing.Size(363, 22);
            this.Txt_WordEnglish.TabIndex = 111;
            // 
            // Lbl_english
            // 
            this.Lbl_english.AutoSize = true;
            this.Lbl_english.Location = new System.Drawing.Point(759, 257);
            this.Lbl_english.Name = "Lbl_english";
            this.Lbl_english.Size = new System.Drawing.Size(94, 16);
            this.Lbl_english.TabIndex = 110;
            this.Lbl_english.Text = "لغت انگلیسی :";
            // 
            // Txt_Saier
            // 
            this.Txt_Saier.Location = new System.Drawing.Point(139, 331);
            this.Txt_Saier.Name = "Txt_Saier";
            this.Txt_Saier.Size = new System.Drawing.Size(614, 22);
            this.Txt_Saier.TabIndex = 107;
            // 
            // Txt_Motaradef
            // 
            this.Txt_Motaradef.Location = new System.Drawing.Point(139, 305);
            this.Txt_Motaradef.Name = "Txt_Motaradef";
            this.Txt_Motaradef.Size = new System.Drawing.Size(614, 22);
            this.Txt_Motaradef.TabIndex = 106;
            // 
            // Lbl_Saier
            // 
            this.Lbl_Saier.AutoSize = true;
            this.Lbl_Saier.Location = new System.Drawing.Point(759, 333);
            this.Lbl_Saier.Name = "Lbl_Saier";
            this.Lbl_Saier.Size = new System.Drawing.Size(43, 16);
            this.Lbl_Saier.TabIndex = 102;
            this.Lbl_Saier.Text = "سایر :";
            // 
            // Lbl_Motaradef
            // 
            this.Lbl_Motaradef.AutoSize = true;
            this.Lbl_Motaradef.Location = new System.Drawing.Point(759, 308);
            this.Lbl_Motaradef.Name = "Lbl_Motaradef";
            this.Lbl_Motaradef.Size = new System.Drawing.Size(71, 16);
            this.Lbl_Motaradef.TabIndex = 101;
            this.Lbl_Motaradef.Text = "مترادف ها :";
            // 
            // Txt_LoghatId
            // 
            this.Txt_LoghatId.Location = new System.Drawing.Point(328, 475);
            this.Txt_LoghatId.Name = "Txt_LoghatId";
            this.Txt_LoghatId.Size = new System.Drawing.Size(93, 22);
            this.Txt_LoghatId.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 115;
            this.label1.Text = "کد لغت :";
            // 
            // Lbl_Search
            // 
            this.Lbl_Search.AutoSize = true;
            this.Lbl_Search.Location = new System.Drawing.Point(783, 389);
            this.Lbl_Search.Name = "Lbl_Search";
            this.Lbl_Search.Size = new System.Drawing.Size(60, 16);
            this.Lbl_Search.TabIndex = 116;
            this.Lbl_Search.Text = "جستجو :";
            // 
            // Rdo_English
            // 
            this.Rdo_English.AutoSize = true;
            this.Rdo_English.Checked = true;
            this.Rdo_English.Location = new System.Drawing.Point(706, 389);
            this.Rdo_English.Name = "Rdo_English";
            this.Rdo_English.Size = new System.Drawing.Size(81, 20);
            this.Rdo_English.TabIndex = 117;
            this.Rdo_English.TabStop = true;
            this.Rdo_English.Text = "انگلیسی ";
            this.Rdo_English.UseVisualStyleBackColor = true;
            // 
            // Rdo_Farsi
            // 
            this.Rdo_Farsi.AutoSize = true;
            this.Rdo_Farsi.Location = new System.Drawing.Point(639, 389);
            this.Rdo_Farsi.Name = "Rdo_Farsi";
            this.Rdo_Farsi.Size = new System.Drawing.Size(66, 20);
            this.Rdo_Farsi.TabIndex = 118;
            this.Rdo_Farsi.TabStop = true;
            this.Rdo_Farsi.Text = "فارسی";
            this.Rdo_Farsi.UseVisualStyleBackColor = true;
            // 
            // Txt_Search
            // 
            this.Txt_Search.Location = new System.Drawing.Point(406, 389);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(227, 22);
            this.Txt_Search.TabIndex = 119;
            // 
            // LogatID
            // 
            this.LogatID.DataPropertyName = "LogatID";
            this.LogatID.HeaderText = "کد لغت";
            this.LogatID.Name = "LogatID";
            this.LogatID.ReadOnly = true;
            // 
            // LogatEnglish
            // 
            this.LogatEnglish.DataPropertyName = "LogatEnglish";
            this.LogatEnglish.HeaderText = "لغت انگلیسی";
            this.LogatEnglish.Name = "LogatEnglish";
            this.LogatEnglish.ReadOnly = true;
            this.LogatEnglish.Width = 150;
            // 
            // LoghatFarsi
            // 
            this.LoghatFarsi.DataPropertyName = "LoghatFarsi";
            this.LoghatFarsi.HeaderText = "معادل فارسی";
            this.LoghatFarsi.Name = "LoghatFarsi";
            this.LoghatFarsi.ReadOnly = true;
            this.LoghatFarsi.Width = 150;
            // 
            // LoghatMotaradef
            // 
            this.LoghatMotaradef.DataPropertyName = "LoghatMotaradef";
            this.LoghatMotaradef.HeaderText = "دیگر مترادف ها";
            this.LoghatMotaradef.Name = "LoghatMotaradef";
            this.LoghatMotaradef.ReadOnly = true;
            this.LoghatMotaradef.Width = 150;
            // 
            // LogatSaier
            // 
            this.LogatSaier.DataPropertyName = "LogatSaier";
            this.LogatSaier.HeaderText = "سایر لغات هم معنی";
            this.LogatSaier.Name = "LogatSaier";
            this.LogatSaier.ReadOnly = true;
            this.LogatSaier.Width = 150;
            // 
            // DateOfAdd
            // 
            this.DateOfAdd.DataPropertyName = "DateOfAdd";
            this.DateOfAdd.HeaderText = "تاریخ درج";
            this.DateOfAdd.Name = "DateOfAdd";
            this.DateOfAdd.ReadOnly = true;
            // 
            // AdderUserName
            // 
            this.AdderUserName.DataPropertyName = "AdderUserName";
            this.AdderUserName.HeaderText = "کاربر درج کننده";
            this.AdderUserName.Name = "AdderUserName";
            this.AdderUserName.ReadOnly = true;
            this.AdderUserName.Width = 150;
            // 
            // frmSabteLoghat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 454);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(this.Rdo_Farsi);
            this.Controls.Add(this.Rdo_English);
            this.Controls.Add(this.Lbl_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_LoghatId);
            this.Controls.Add(this.Txt_WordFarsi);
            this.Controls.Add(this.Lbl_Farsi);
            this.Controls.Add(this.Txt_WordEnglish);
            this.Controls.Add(this.Lbl_english);
            this.Controls.Add(this.Txt_Saier);
            this.Controls.Add(this.Txt_Motaradef);
            this.Controls.Add(this.Lbl_Saier);
            this.Controls.Add(this.Lbl_Motaradef);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Grd_Word);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSabteLoghat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم ثبت لغتها و اصطلاحات";
            this.Load += new System.EventHandler(this.frmSabteLoghat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Word)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grd_Word;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.TextBox Txt_WordFarsi;
        private System.Windows.Forms.Label Lbl_Farsi;
        private System.Windows.Forms.TextBox Txt_WordEnglish;
        private System.Windows.Forms.Label Lbl_english;
        private System.Windows.Forms.TextBox Txt_Saier;
        private System.Windows.Forms.TextBox Txt_Motaradef;
        private System.Windows.Forms.Label Lbl_Saier;
        private System.Windows.Forms.Label Lbl_Motaradef;
        private System.Windows.Forms.TextBox Txt_LoghatId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Search;
        private System.Windows.Forms.RadioButton Rdo_English;
        private System.Windows.Forms.RadioButton Rdo_Farsi;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogatEnglish;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoghatFarsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoghatMotaradef;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogatSaier;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdderUserName;
    }
}