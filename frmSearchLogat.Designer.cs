namespace Logat504
{
    partial class frmSearchLogat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchLogat));
            this.Grd_Word = new System.Windows.Forms.DataGridView();
            this.LogatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogatEnglish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoghatFarsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoghatMotaradef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogatSaier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdderUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.Lbl_english = new System.Windows.Forms.Label();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Chb_EnglishLogat = new System.Windows.Forms.CheckBox();
            this.Rdo_Farsi = new System.Windows.Forms.RadioButton();
            this.Rdo_English = new System.Windows.Forms.RadioButton();
            this.Chb_MotaradefHa = new System.Windows.Forms.CheckBox();
            this.Chb_SaiereLogat = new System.Windows.Forms.CheckBox();
            this.GrpBox_Zaban = new System.Windows.Forms.GroupBox();
            this.GrpBox_Barasas = new System.Windows.Forms.GroupBox();
            this.Rdo_Bakhshi = new System.Windows.Forms.RadioButton();
            this.Rdo_EineEbarat = new System.Windows.Forms.RadioButton();
            this.GrpBox_OnveneFieldHa = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Word)).BeginInit();
            this.GrpBox_Zaban.SuspendLayout();
            this.GrpBox_Barasas.SuspendLayout();
            this.GrpBox_OnveneFieldHa.SuspendLayout();
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
            this.Grd_Word.Size = new System.Drawing.Size(841, 319);
            this.Grd_Word.TabIndex = 1;
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
            // Txt_Search
            // 
            this.Txt_Search.Location = new System.Drawing.Point(451, 340);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(282, 22);
            this.Txt_Search.TabIndex = 119;
            // 
            // Lbl_english
            // 
            this.Lbl_english.AutoSize = true;
            this.Lbl_english.Location = new System.Drawing.Point(739, 343);
            this.Lbl_english.Name = "Lbl_english";
            this.Lbl_english.Size = new System.Drawing.Size(85, 16);
            this.Lbl_english.TabIndex = 118;
            this.Lbl_english.Text = "فیلتر جستجو:";
            // 
            // Btn_Search
            // 
            this.Btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Search.Image")));
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Search.Location = new System.Drawing.Point(4, 382);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(90, 83);
            this.Btn_Search.TabIndex = 120;
            this.Btn_Search.Text = "جستجو کردن";
            this.Btn_Search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Chb_EnglishLogat
            // 
            this.Chb_EnglishLogat.AutoSize = true;
            this.Chb_EnglishLogat.Location = new System.Drawing.Point(514, 17);
            this.Chb_EnglishLogat.Name = "Chb_EnglishLogat";
            this.Chb_EnglishLogat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Chb_EnglishLogat.Size = new System.Drawing.Size(130, 20);
            this.Chb_EnglishLogat.TabIndex = 121;
            this.Chb_EnglishLogat.Text = "فیلد لغت انگلیسی";
            this.Chb_EnglishLogat.UseVisualStyleBackColor = true;
            // 
            // Rdo_Farsi
            // 
            this.Rdo_Farsi.AutoSize = true;
            this.Rdo_Farsi.Location = new System.Drawing.Point(7, 21);
            this.Rdo_Farsi.Name = "Rdo_Farsi";
            this.Rdo_Farsi.Size = new System.Drawing.Size(66, 20);
            this.Rdo_Farsi.TabIndex = 123;
            this.Rdo_Farsi.Text = "فارسی";
            this.Rdo_Farsi.UseVisualStyleBackColor = true;
            this.Rdo_Farsi.CheckedChanged += new System.EventHandler(this.Rdo_Farsi_CheckedChanged);
            // 
            // Rdo_English
            // 
            this.Rdo_English.AutoSize = true;
            this.Rdo_English.Checked = true;
            this.Rdo_English.Location = new System.Drawing.Point(94, 21);
            this.Rdo_English.Name = "Rdo_English";
            this.Rdo_English.Size = new System.Drawing.Size(81, 20);
            this.Rdo_English.TabIndex = 122;
            this.Rdo_English.TabStop = true;
            this.Rdo_English.Text = "انگلیسی ";
            this.Rdo_English.UseVisualStyleBackColor = true;
            this.Rdo_English.CheckedChanged += new System.EventHandler(this.Rdo_English_CheckedChanged);
            // 
            // Chb_MotaradefHa
            // 
            this.Chb_MotaradefHa.AutoSize = true;
            this.Chb_MotaradefHa.Location = new System.Drawing.Point(284, 17);
            this.Chb_MotaradefHa.Name = "Chb_MotaradefHa";
            this.Chb_MotaradefHa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Chb_MotaradefHa.Size = new System.Drawing.Size(95, 20);
            this.Chb_MotaradefHa.TabIndex = 124;
            this.Chb_MotaradefHa.Text = "فیلد مترادفها";
            this.Chb_MotaradefHa.UseVisualStyleBackColor = true;
            // 
            // Chb_SaiereLogat
            // 
            this.Chb_SaiereLogat.AutoSize = true;
            this.Chb_SaiereLogat.Location = new System.Drawing.Point(69, 17);
            this.Chb_SaiereLogat.Name = "Chb_SaiereLogat";
            this.Chb_SaiereLogat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Chb_SaiereLogat.Size = new System.Drawing.Size(108, 20);
            this.Chb_SaiereLogat.TabIndex = 125;
            this.Chb_SaiereLogat.Text = "فیلد سایر لغات";
            this.Chb_SaiereLogat.UseVisualStyleBackColor = true;
            // 
            // GrpBox_Zaban
            // 
            this.GrpBox_Zaban.Controls.Add(this.Rdo_English);
            this.GrpBox_Zaban.Controls.Add(this.Rdo_Farsi);
            this.GrpBox_Zaban.Location = new System.Drawing.Point(264, 325);
            this.GrpBox_Zaban.Name = "GrpBox_Zaban";
            this.GrpBox_Zaban.Size = new System.Drawing.Size(181, 51);
            this.GrpBox_Zaban.TabIndex = 126;
            this.GrpBox_Zaban.TabStop = false;
            this.GrpBox_Zaban.Text = "جستجوی در زبان";
            // 
            // GrpBox_Barasas
            // 
            this.GrpBox_Barasas.Controls.Add(this.Rdo_Bakhshi);
            this.GrpBox_Barasas.Controls.Add(this.Rdo_EineEbarat);
            this.GrpBox_Barasas.Location = new System.Drawing.Point(13, 325);
            this.GrpBox_Barasas.Name = "GrpBox_Barasas";
            this.GrpBox_Barasas.Size = new System.Drawing.Size(240, 51);
            this.GrpBox_Barasas.TabIndex = 127;
            this.GrpBox_Barasas.TabStop = false;
            this.GrpBox_Barasas.Text = "نوع جستجو";
            // 
            // Rdo_Bakhshi
            // 
            this.Rdo_Bakhshi.AutoSize = true;
            this.Rdo_Bakhshi.Checked = true;
            this.Rdo_Bakhshi.Location = new System.Drawing.Point(119, 21);
            this.Rdo_Bakhshi.Name = "Rdo_Bakhshi";
            this.Rdo_Bakhshi.Size = new System.Drawing.Size(115, 20);
            this.Rdo_Bakhshi.TabIndex = 122;
            this.Rdo_Bakhshi.TabStop = true;
            this.Rdo_Bakhshi.Text = "بخشی از عبارت";
            this.Rdo_Bakhshi.UseVisualStyleBackColor = true;
            // 
            // Rdo_EineEbarat
            // 
            this.Rdo_EineEbarat.AutoSize = true;
            this.Rdo_EineEbarat.Location = new System.Drawing.Point(13, 21);
            this.Rdo_EineEbarat.Name = "Rdo_EineEbarat";
            this.Rdo_EineEbarat.Size = new System.Drawing.Size(86, 20);
            this.Rdo_EineEbarat.TabIndex = 123;
            this.Rdo_EineEbarat.Text = "عین عبارت";
            this.Rdo_EineEbarat.UseVisualStyleBackColor = true;
            // 
            // GrpBox_OnveneFieldHa
            // 
            this.GrpBox_OnveneFieldHa.Controls.Add(this.Chb_MotaradefHa);
            this.GrpBox_OnveneFieldHa.Controls.Add(this.Chb_EnglishLogat);
            this.GrpBox_OnveneFieldHa.Controls.Add(this.Chb_SaiereLogat);
            this.GrpBox_OnveneFieldHa.Location = new System.Drawing.Point(100, 402);
            this.GrpBox_OnveneFieldHa.Name = "GrpBox_OnveneFieldHa";
            this.GrpBox_OnveneFieldHa.Size = new System.Drawing.Size(729, 48);
            this.GrpBox_OnveneFieldHa.TabIndex = 128;
            this.GrpBox_OnveneFieldHa.TabStop = false;
            this.GrpBox_OnveneFieldHa.Text = "عنوان فیلدها";
            // 
            // frmSearchLogat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 470);
            this.Controls.Add(this.GrpBox_OnveneFieldHa);
            this.Controls.Add(this.GrpBox_Barasas);
            this.Controls.Add(this.GrpBox_Zaban);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(this.Lbl_english);
            this.Controls.Add(this.Grd_Word);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSearchLogat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "جستجوی لغات و اصطلاحات";
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Word)).EndInit();
            this.GrpBox_Zaban.ResumeLayout(false);
            this.GrpBox_Zaban.PerformLayout();
            this.GrpBox_Barasas.ResumeLayout(false);
            this.GrpBox_Barasas.PerformLayout();
            this.GrpBox_OnveneFieldHa.ResumeLayout(false);
            this.GrpBox_OnveneFieldHa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grd_Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogatEnglish;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoghatFarsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoghatMotaradef;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogatSaier;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdderUserName;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.Label Lbl_english;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.CheckBox Chb_EnglishLogat;
        private System.Windows.Forms.RadioButton Rdo_Farsi;
        private System.Windows.Forms.RadioButton Rdo_English;
        private System.Windows.Forms.CheckBox Chb_MotaradefHa;
        private System.Windows.Forms.CheckBox Chb_SaiereLogat;
        private System.Windows.Forms.GroupBox GrpBox_Zaban;
        private System.Windows.Forms.GroupBox GrpBox_Barasas;
        private System.Windows.Forms.RadioButton Rdo_Bakhshi;
        private System.Windows.Forms.RadioButton Rdo_EineEbarat;
        private System.Windows.Forms.GroupBox GrpBox_OnveneFieldHa;
    }
}