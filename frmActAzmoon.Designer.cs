namespace Logat504
{
    partial class frmActAzmoon
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
            this.Drp_LevelAzmoon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpBox_SatheAzmoon = new System.Windows.Forms.GroupBox();
            this.Btn_ConfirmSelect = new System.Windows.Forms.Button();
            this.GrpBox_SelectAzmoon = new System.Windows.Forms.GroupBox();
            this.Btn_CancelSelect = new System.Windows.Forms.Button();
            this.Btn_COnfirmTitle = new System.Windows.Forms.Button();
            this.Lbl_AzmoonTitleEnt = new System.Windows.Forms.Label();
            this.Drp_AzmoonTitle = new System.Windows.Forms.ComboBox();
            this.Grd_TestAct = new System.Windows.Forms.DataGridView();
            this.SoalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pasokh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoAlDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gozineie1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gozineie2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gozineie3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gozineie4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrpBox_Natijeh = new System.Windows.Forms.GroupBox();
            this.Lbl_Nomreh = new System.Windows.Forms.Label();
            this.Lbl_Time = new System.Windows.Forms.Label();
            this.Lbl_SoalBedooneavab = new System.Windows.Forms.Label();
            this.Lbl_SoalEshtebah = new System.Windows.Forms.Label();
            this.Labl_SoalSahih = new System.Windows.Forms.Label();
            this.Btn_Natijeh = new System.Windows.Forms.Button();
            this.Time_Azmoon = new System.Windows.Forms.Timer(this.components);
            this.Btn_ShowReading = new System.Windows.Forms.Button();
            this.GrpBox_SatheAzmoon.SuspendLayout();
            this.GrpBox_SelectAzmoon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_TestAct)).BeginInit();
            this.GrpBox_Natijeh.SuspendLayout();
            this.SuspendLayout();
            // 
            // Drp_LevelAzmoon
            // 
            this.Drp_LevelAzmoon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drp_LevelAzmoon.FormattingEnabled = true;
            this.Drp_LevelAzmoon.Location = new System.Drawing.Point(573, 20);
            this.Drp_LevelAzmoon.Name = "Drp_LevelAzmoon";
            this.Drp_LevelAzmoon.Size = new System.Drawing.Size(291, 22);
            this.Drp_LevelAzmoon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(885, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "انتخاب سطح آزمون:";
            // 
            // GrpBox_SatheAzmoon
            // 
            this.GrpBox_SatheAzmoon.Controls.Add(this.Btn_ConfirmSelect);
            this.GrpBox_SatheAzmoon.Controls.Add(this.Drp_LevelAzmoon);
            this.GrpBox_SatheAzmoon.Controls.Add(this.label1);
            this.GrpBox_SatheAzmoon.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrpBox_SatheAzmoon.Location = new System.Drawing.Point(0, 0);
            this.GrpBox_SatheAzmoon.Name = "GrpBox_SatheAzmoon";
            this.GrpBox_SatheAzmoon.Size = new System.Drawing.Size(1013, 66);
            this.GrpBox_SatheAzmoon.TabIndex = 2;
            this.GrpBox_SatheAzmoon.TabStop = false;
            this.GrpBox_SatheAzmoon.Text = "سطح آزمون";
            // 
            // Btn_ConfirmSelect
            // 
            this.Btn_ConfirmSelect.Location = new System.Drawing.Point(399, 17);
            this.Btn_ConfirmSelect.Name = "Btn_ConfirmSelect";
            this.Btn_ConfirmSelect.Size = new System.Drawing.Size(105, 32);
            this.Btn_ConfirmSelect.TabIndex = 2;
            this.Btn_ConfirmSelect.Text = "تائید انتخاب";
            this.Btn_ConfirmSelect.UseVisualStyleBackColor = true;
            this.Btn_ConfirmSelect.Click += new System.EventHandler(this.Btn_ConfirmSelect_Click);
            // 
            // GrpBox_SelectAzmoon
            // 
            this.GrpBox_SelectAzmoon.Controls.Add(this.Btn_CancelSelect);
            this.GrpBox_SelectAzmoon.Controls.Add(this.Btn_COnfirmTitle);
            this.GrpBox_SelectAzmoon.Controls.Add(this.Lbl_AzmoonTitleEnt);
            this.GrpBox_SelectAzmoon.Controls.Add(this.Drp_AzmoonTitle);
            this.GrpBox_SelectAzmoon.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrpBox_SelectAzmoon.Enabled = false;
            this.GrpBox_SelectAzmoon.Location = new System.Drawing.Point(0, 66);
            this.GrpBox_SelectAzmoon.Name = "GrpBox_SelectAzmoon";
            this.GrpBox_SelectAzmoon.Size = new System.Drawing.Size(1013, 66);
            this.GrpBox_SelectAzmoon.TabIndex = 3;
            this.GrpBox_SelectAzmoon.TabStop = false;
            this.GrpBox_SelectAzmoon.Text = "عنوان آزمون";
            // 
            // Btn_CancelSelect
            // 
            this.Btn_CancelSelect.Location = new System.Drawing.Point(204, 20);
            this.Btn_CancelSelect.Name = "Btn_CancelSelect";
            this.Btn_CancelSelect.Size = new System.Drawing.Size(105, 32);
            this.Btn_CancelSelect.TabIndex = 4;
            this.Btn_CancelSelect.Text = "لغو انتخاب";
            this.Btn_CancelSelect.UseVisualStyleBackColor = true;
            this.Btn_CancelSelect.Click += new System.EventHandler(this.Btn_CancelSelect_Click);
            // 
            // Btn_COnfirmTitle
            // 
            this.Btn_COnfirmTitle.Location = new System.Drawing.Point(316, 20);
            this.Btn_COnfirmTitle.Name = "Btn_COnfirmTitle";
            this.Btn_COnfirmTitle.Size = new System.Drawing.Size(105, 32);
            this.Btn_COnfirmTitle.TabIndex = 3;
            this.Btn_COnfirmTitle.Text = "تائید انتخاب";
            this.Btn_COnfirmTitle.UseVisualStyleBackColor = true;
            this.Btn_COnfirmTitle.Click += new System.EventHandler(this.Btn_COnfirmTitle_Click);
            // 
            // Lbl_AzmoonTitleEnt
            // 
            this.Lbl_AzmoonTitleEnt.AutoSize = true;
            this.Lbl_AzmoonTitleEnt.Location = new System.Drawing.Point(887, 30);
            this.Lbl_AzmoonTitleEnt.Name = "Lbl_AzmoonTitleEnt";
            this.Lbl_AzmoonTitleEnt.Size = new System.Drawing.Size(118, 16);
            this.Lbl_AzmoonTitleEnt.TabIndex = 4;
            this.Lbl_AzmoonTitleEnt.Text = "انتخاب عنوان آزمون:";
            // 
            // Drp_AzmoonTitle
            // 
            this.Drp_AzmoonTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drp_AzmoonTitle.FormattingEnabled = true;
            this.Drp_AzmoonTitle.Location = new System.Drawing.Point(428, 27);
            this.Drp_AzmoonTitle.Name = "Drp_AzmoonTitle";
            this.Drp_AzmoonTitle.Size = new System.Drawing.Size(437, 22);
            this.Drp_AzmoonTitle.TabIndex = 3;
            // 
            // Grd_TestAct
            // 
            this.Grd_TestAct.AllowUserToAddRows = false;
            this.Grd_TestAct.AllowUserToDeleteRows = false;
            this.Grd_TestAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_TestAct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoalID,
            this.Pasokh,
            this.SoAlDescription,
            this.Gozineie1,
            this.Gozineie2,
            this.Gozineie3,
            this.Gozineie4});
            this.Grd_TestAct.Enabled = false;
            this.Grd_TestAct.Location = new System.Drawing.Point(0, 131);
            this.Grd_TestAct.Name = "Grd_TestAct";
            this.Grd_TestAct.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Grd_TestAct.Size = new System.Drawing.Size(1013, 423);
            this.Grd_TestAct.TabIndex = 4;
            // 
            // SoalID
            // 
            this.SoalID.DataPropertyName = "SoalID";
            this.SoalID.HeaderText = "کد سوال";
            this.SoalID.Name = "SoalID";
            // 
            // Pasokh
            // 
            this.Pasokh.HeaderText = "پاسخ تست";
            this.Pasokh.Name = "Pasokh";
            // 
            // SoAlDescription
            // 
            this.SoAlDescription.DataPropertyName = "SoAlDescription";
            this.SoAlDescription.HeaderText = "سوال";
            this.SoAlDescription.Name = "SoAlDescription";
            this.SoAlDescription.Width = 300;
            // 
            // Gozineie1
            // 
            this.Gozineie1.DataPropertyName = "Gozineie1";
            this.Gozineie1.HeaderText = "گزینه 1";
            this.Gozineie1.Name = "Gozineie1";
            this.Gozineie1.Width = 150;
            // 
            // Gozineie2
            // 
            this.Gozineie2.DataPropertyName = "Gozineie2";
            this.Gozineie2.HeaderText = "گزینه 2";
            this.Gozineie2.Name = "Gozineie2";
            this.Gozineie2.Width = 150;
            // 
            // Gozineie3
            // 
            this.Gozineie3.DataPropertyName = "Gozineie3";
            this.Gozineie3.HeaderText = "گزینه 3";
            this.Gozineie3.Name = "Gozineie3";
            this.Gozineie3.Width = 150;
            // 
            // Gozineie4
            // 
            this.Gozineie4.DataPropertyName = "Gozineie4";
            this.Gozineie4.HeaderText = "گزینه 4";
            this.Gozineie4.Name = "Gozineie4";
            this.Gozineie4.Width = 150;
            // 
            // GrpBox_Natijeh
            // 
            this.GrpBox_Natijeh.Controls.Add(this.Btn_ShowReading);
            this.GrpBox_Natijeh.Controls.Add(this.Lbl_Nomreh);
            this.GrpBox_Natijeh.Controls.Add(this.Lbl_Time);
            this.GrpBox_Natijeh.Controls.Add(this.Lbl_SoalBedooneavab);
            this.GrpBox_Natijeh.Controls.Add(this.Lbl_SoalEshtebah);
            this.GrpBox_Natijeh.Controls.Add(this.Labl_SoalSahih);
            this.GrpBox_Natijeh.Controls.Add(this.Btn_Natijeh);
            this.GrpBox_Natijeh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrpBox_Natijeh.Enabled = false;
            this.GrpBox_Natijeh.Location = new System.Drawing.Point(0, 560);
            this.GrpBox_Natijeh.Name = "GrpBox_Natijeh";
            this.GrpBox_Natijeh.Size = new System.Drawing.Size(1013, 79);
            this.GrpBox_Natijeh.TabIndex = 5;
            this.GrpBox_Natijeh.TabStop = false;
            this.GrpBox_Natijeh.Text = "نتیجه آزمون";
            // 
            // Lbl_Nomreh
            // 
            this.Lbl_Nomreh.AutoSize = true;
            this.Lbl_Nomreh.Location = new System.Drawing.Point(242, 37);
            this.Lbl_Nomreh.Name = "Lbl_Nomreh";
            this.Lbl_Nomreh.Size = new System.Drawing.Size(70, 16);
            this.Lbl_Nomreh.TabIndex = 7;
            this.Lbl_Nomreh.Text = "نمره آزمون:";
            // 
            // Lbl_Time
            // 
            this.Lbl_Time.AutoSize = true;
            this.Lbl_Time.Location = new System.Drawing.Point(352, 37);
            this.Lbl_Time.Name = "Lbl_Time";
            this.Lbl_Time.Size = new System.Drawing.Size(72, 16);
            this.Lbl_Time.TabIndex = 6;
            this.Lbl_Time.Text = "زمان آزمون:";
            // 
            // Lbl_SoalBedooneavab
            // 
            this.Lbl_SoalBedooneavab.AutoSize = true;
            this.Lbl_SoalBedooneavab.Location = new System.Drawing.Point(584, 38);
            this.Lbl_SoalBedooneavab.Name = "Lbl_SoalBedooneavab";
            this.Lbl_SoalBedooneavab.Size = new System.Drawing.Size(117, 16);
            this.Lbl_SoalBedooneavab.TabIndex = 6;
            this.Lbl_SoalBedooneavab.Text = "سوالات بدون پاسخ:";
            // 
            // Lbl_SoalEshtebah
            // 
            this.Lbl_SoalEshtebah.AutoSize = true;
            this.Lbl_SoalEshtebah.Location = new System.Drawing.Point(741, 38);
            this.Lbl_SoalEshtebah.Name = "Lbl_SoalEshtebah";
            this.Lbl_SoalEshtebah.Size = new System.Drawing.Size(94, 16);
            this.Lbl_SoalEshtebah.TabIndex = 4;
            this.Lbl_SoalEshtebah.Text = "سوالات اشتباه:";
            // 
            // Labl_SoalSahih
            // 
            this.Labl_SoalSahih.AutoSize = true;
            this.Labl_SoalSahih.Location = new System.Drawing.Point(906, 38);
            this.Labl_SoalSahih.Name = "Labl_SoalSahih";
            this.Labl_SoalSahih.Size = new System.Drawing.Size(95, 16);
            this.Labl_SoalSahih.TabIndex = 3;
            this.Labl_SoalSahih.Text = "سوالات صحیح: ";
            // 
            // Btn_Natijeh
            // 
            this.Btn_Natijeh.Location = new System.Drawing.Point(4, 41);
            this.Btn_Natijeh.Name = "Btn_Natijeh";
            this.Btn_Natijeh.Size = new System.Drawing.Size(166, 32);
            this.Btn_Natijeh.TabIndex = 3;
            this.Btn_Natijeh.Text = "ثبت و مشاهده نتیجه";
            this.Btn_Natijeh.UseVisualStyleBackColor = true;
            this.Btn_Natijeh.Click += new System.EventHandler(this.Btn_Natijeh_Click);
            // 
            // Time_Azmoon
            // 
            this.Time_Azmoon.Interval = 1000;
            this.Time_Azmoon.Tick += new System.EventHandler(this.Time_Azmoon_Tick);
            // 
            // Btn_ShowReading
            // 
            this.Btn_ShowReading.Location = new System.Drawing.Point(5, 8);
            this.Btn_ShowReading.Name = "Btn_ShowReading";
            this.Btn_ShowReading.Size = new System.Drawing.Size(165, 32);
            this.Btn_ShowReading.TabIndex = 5;
            this.Btn_ShowReading.Text = "Reading";
            this.Btn_ShowReading.UseVisualStyleBackColor = true;
            this.Btn_ShowReading.Click += new System.EventHandler(this.Btn_ShowReading_Click);
            // 
            // frmActAzmoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 639);
            this.Controls.Add(this.GrpBox_Natijeh);
            this.Controls.Add(this.Grd_TestAct);
            this.Controls.Add(this.GrpBox_SelectAzmoon);
            this.Controls.Add(this.GrpBox_SatheAzmoon);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmActAzmoon";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم شرکت در آزمون";
            this.Load += new System.EventHandler(this.frmActAzmoon_Load);
            this.GrpBox_SatheAzmoon.ResumeLayout(false);
            this.GrpBox_SatheAzmoon.PerformLayout();
            this.GrpBox_SelectAzmoon.ResumeLayout(false);
            this.GrpBox_SelectAzmoon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_TestAct)).EndInit();
            this.GrpBox_Natijeh.ResumeLayout(false);
            this.GrpBox_Natijeh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Drp_LevelAzmoon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrpBox_SatheAzmoon;
        private System.Windows.Forms.Button Btn_ConfirmSelect;
        private System.Windows.Forms.GroupBox GrpBox_SelectAzmoon;
        private System.Windows.Forms.Label Lbl_AzmoonTitleEnt;
        private System.Windows.Forms.ComboBox Drp_AzmoonTitle;
        private System.Windows.Forms.Button Btn_CancelSelect;
        private System.Windows.Forms.Button Btn_COnfirmTitle;
        private System.Windows.Forms.DataGridView Grd_TestAct;
        private System.Windows.Forms.GroupBox GrpBox_Natijeh;
        private System.Windows.Forms.Button Btn_Natijeh;
        private System.Windows.Forms.Label Lbl_SoalEshtebah;
        private System.Windows.Forms.Label Labl_SoalSahih;
        private System.Windows.Forms.Label Lbl_Time;
        private System.Windows.Forms.Label Lbl_SoalBedooneavab;
        private System.Windows.Forms.Label Lbl_Nomreh;
        private System.Windows.Forms.Timer Time_Azmoon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pasokh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoAlDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gozineie1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gozineie2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gozineie3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gozineie4;
        private System.Windows.Forms.Button Btn_ShowReading;
    }
}