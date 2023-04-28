namespace Logat504
{
    partial class frmDefineAzmoon
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
            this.AzmoonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AzmoonLevelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AzmoonLevelDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AzmoonTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AzmoonReading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Txt_AzmoonTitle = new System.Windows.Forms.TextBox();
            this.Lbl_AzmoonTitle = new System.Windows.Forms.Label();
            this.Cmb_AzmoonSath = new System.Windows.Forms.ComboBox();
            this.Lbl_AzmoonSath = new System.Windows.Forms.Label();
            this.Txt_Reading = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_AzmoonTitleID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AzmoonID,
            this.AzmoonLevelID,
            this.AzmoonLevelDescription,
            this.AzmoonTitle,
            this.AzmoonReading});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(806, 266);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AzmoonID
            // 
            this.AzmoonID.DataPropertyName = "AzmoonID";
            this.AzmoonID.HeaderText = "کد آزمون";
            this.AzmoonID.Name = "AzmoonID";
            this.AzmoonID.ReadOnly = true;
            // 
            // AzmoonLevelID
            // 
            this.AzmoonLevelID.DataPropertyName = "AzmoonLevelID";
            this.AzmoonLevelID.HeaderText = "کد سطح آزمون";
            this.AzmoonLevelID.Name = "AzmoonLevelID";
            this.AzmoonLevelID.ReadOnly = true;
            this.AzmoonLevelID.Visible = false;
            this.AzmoonLevelID.Width = 150;
            // 
            // AzmoonLevelDescription
            // 
            this.AzmoonLevelDescription.DataPropertyName = "AzmoonLevelDescription";
            this.AzmoonLevelDescription.HeaderText = "سطح آزمون";
            this.AzmoonLevelDescription.Name = "AzmoonLevelDescription";
            this.AzmoonLevelDescription.ReadOnly = true;
            this.AzmoonLevelDescription.Width = 150;
            // 
            // AzmoonTitle
            // 
            this.AzmoonTitle.DataPropertyName = "AzmoonTitle";
            this.AzmoonTitle.HeaderText = "عنوان آزمون";
            this.AzmoonTitle.Name = "AzmoonTitle";
            this.AzmoonTitle.ReadOnly = true;
            this.AzmoonTitle.Width = 200;
            // 
            // AzmoonReading
            // 
            this.AzmoonReading.DataPropertyName = "AzmoonReading";
            this.AzmoonReading.HeaderText = "متن در مورد آزمون (Reading)";
            this.AzmoonReading.Name = "AzmoonReading";
            this.AzmoonReading.ReadOnly = true;
            this.AzmoonReading.Width = 500;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Image = global::Logat504.Properties.Resources.Search_Sm;
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Search.Location = new System.Drawing.Point(6, 272);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(90, 83);
            this.Btn_Search.TabIndex = 39;
            this.Btn_Search.Text = "جستجو کردن";
            this.Btn_Search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Image = global::Logat504.Properties.Resources.Edit_Btn_Sm;
            this.Btn_Edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Edit.Location = new System.Drawing.Point(197, 271);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(90, 83);
            this.Btn_Edit.TabIndex = 38;
            this.Btn_Edit.Text = "ویرایش کردن";
            this.Btn_Edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Image = global::Logat504.Properties.Resources.Delete_Btn_Sm;
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Delete.Location = new System.Drawing.Point(101, 271);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(90, 83);
            this.Btn_Delete.TabIndex = 37;
            this.Btn_Delete.Text = "حذف کردن";
            this.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Image = global::Logat504.Properties.Resources.Add_Btn_Sm;
            this.Btn_Add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Add.Location = new System.Drawing.Point(293, 272);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(84, 83);
            this.Btn_Add.TabIndex = 36;
            this.Btn_Add.Text = "اضافه کردن";
            this.Btn_Add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Image = global::Logat504.Properties.Resources.Save_Sma;
            this.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Save.Location = new System.Drawing.Point(293, 271);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(84, 83);
            this.Btn_Save.TabIndex = 40;
            this.Btn_Save.Text = "ذخیره";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Image = global::Logat504.Properties.Resources.refresh1001_Sm;
            this.Btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Refresh.Location = new System.Drawing.Point(6, 271);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(90, 83);
            this.Btn_Refresh.TabIndex = 41;
            this.Btn_Refresh.Text = "بازنشانی";
            this.Btn_Refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Txt_AzmoonTitle
            // 
            this.Txt_AzmoonTitle.Location = new System.Drawing.Point(454, 291);
            this.Txt_AzmoonTitle.Name = "Txt_AzmoonTitle";
            this.Txt_AzmoonTitle.Size = new System.Drawing.Size(245, 22);
            this.Txt_AzmoonTitle.TabIndex = 42;
            // 
            // Lbl_AzmoonTitle
            // 
            this.Lbl_AzmoonTitle.AutoSize = true;
            this.Lbl_AzmoonTitle.Location = new System.Drawing.Point(722, 294);
            this.Lbl_AzmoonTitle.Name = "Lbl_AzmoonTitle";
            this.Lbl_AzmoonTitle.Size = new System.Drawing.Size(73, 16);
            this.Lbl_AzmoonTitle.TabIndex = 43;
            this.Lbl_AzmoonTitle.Text = "عنوان آزمون";
            // 
            // Cmb_AzmoonSath
            // 
            this.Cmb_AzmoonSath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_AzmoonSath.FormattingEnabled = true;
            this.Cmb_AzmoonSath.Location = new System.Drawing.Point(454, 323);
            this.Cmb_AzmoonSath.Name = "Cmb_AzmoonSath";
            this.Cmb_AzmoonSath.Size = new System.Drawing.Size(245, 22);
            this.Cmb_AzmoonSath.TabIndex = 44;
            // 
            // Lbl_AzmoonSath
            // 
            this.Lbl_AzmoonSath.AutoSize = true;
            this.Lbl_AzmoonSath.Location = new System.Drawing.Point(722, 326);
            this.Lbl_AzmoonSath.Name = "Lbl_AzmoonSath";
            this.Lbl_AzmoonSath.Size = new System.Drawing.Size(73, 16);
            this.Lbl_AzmoonSath.TabIndex = 45;
            this.Lbl_AzmoonSath.Text = "سطح آزمون";
            // 
            // Txt_Reading
            // 
            this.Txt_Reading.Location = new System.Drawing.Point(12, 359);
            this.Txt_Reading.Multiline = true;
            this.Txt_Reading.Name = "Txt_Reading";
            this.Txt_Reading.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Reading.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Txt_Reading.Size = new System.Drawing.Size(687, 87);
            this.Txt_Reading.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(705, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "متن (Reading)";
            // 
            // Txt_AzmoonTitleID
            // 
            this.Txt_AzmoonTitleID.Location = new System.Drawing.Point(454, 576);
            this.Txt_AzmoonTitleID.Name = "Txt_AzmoonTitleID";
            this.Txt_AzmoonTitleID.Size = new System.Drawing.Size(51, 22);
            this.Txt_AzmoonTitleID.TabIndex = 48;
            // 
            // frmDefineAzmoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 458);
            this.Controls.Add(this.Txt_AzmoonTitleID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Reading);
            this.Controls.Add(this.Lbl_AzmoonSath);
            this.Controls.Add(this.Cmb_AzmoonSath);
            this.Controls.Add(this.Lbl_AzmoonTitle);
            this.Controls.Add(this.Txt_AzmoonTitle);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDefineAzmoon";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم تعریف عنوان آزمونها";
            this.Load += new System.EventHandler(this.frmDefineAzmoon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.TextBox Txt_AzmoonTitle;
        private System.Windows.Forms.Label Lbl_AzmoonTitle;
        private System.Windows.Forms.ComboBox Cmb_AzmoonSath;
        private System.Windows.Forms.Label Lbl_AzmoonSath;
        private System.Windows.Forms.TextBox Txt_Reading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AzmoonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AzmoonLevelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AzmoonLevelDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn AzmoonTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn AzmoonReading;
        private System.Windows.Forms.TextBox Txt_AzmoonTitleID;
    }
}