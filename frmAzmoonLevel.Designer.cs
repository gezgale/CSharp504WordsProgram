namespace Logat504
{
    partial class frmAzmoonLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAzmoonLevel));
            this.Grd_LevelAzmoon = new System.Windows.Forms.DataGridView();
            this.AzmoonLevelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AzmoonLevelDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_Desc = new System.Windows.Forms.Label();
            this.Txt_DescLevel = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Txt_LevelID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_LevelAzmoon)).BeginInit();
            this.SuspendLayout();
            // 
            // Grd_LevelAzmoon
            // 
            this.Grd_LevelAzmoon.AllowUserToAddRows = false;
            this.Grd_LevelAzmoon.AllowUserToDeleteRows = false;
            this.Grd_LevelAzmoon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_LevelAzmoon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AzmoonLevelID,
            this.AzmoonLevelDescription});
            this.Grd_LevelAzmoon.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grd_LevelAzmoon.Location = new System.Drawing.Point(0, 0);
            this.Grd_LevelAzmoon.Name = "Grd_LevelAzmoon";
            this.Grd_LevelAzmoon.ReadOnly = true;
            this.Grd_LevelAzmoon.Size = new System.Drawing.Size(438, 189);
            this.Grd_LevelAzmoon.TabIndex = 0;
            this.Grd_LevelAzmoon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_LevelAzmoon_CellClick);
            // 
            // AzmoonLevelID
            // 
            this.AzmoonLevelID.DataPropertyName = "AzmoonLevelID";
            this.AzmoonLevelID.HeaderText = "کد سطح آزمون";
            this.AzmoonLevelID.Name = "AzmoonLevelID";
            this.AzmoonLevelID.ReadOnly = true;
            this.AzmoonLevelID.Width = 160;
            // 
            // AzmoonLevelDescription
            // 
            this.AzmoonLevelDescription.DataPropertyName = "AzmoonLevelDescription";
            this.AzmoonLevelDescription.HeaderText = "شرح سطح آزمون";
            this.AzmoonLevelDescription.Name = "AzmoonLevelDescription";
            this.AzmoonLevelDescription.ReadOnly = true;
            this.AzmoonLevelDescription.Width = 180;
            // 
            // Lbl_Desc
            // 
            this.Lbl_Desc.AutoSize = true;
            this.Lbl_Desc.Location = new System.Drawing.Point(323, 205);
            this.Lbl_Desc.Name = "Lbl_Desc";
            this.Lbl_Desc.Size = new System.Drawing.Size(95, 13);
            this.Lbl_Desc.TabIndex = 1;
            this.Lbl_Desc.Text = "شرح سطح آزمون :";
            // 
            // Txt_DescLevel
            // 
            this.Txt_DescLevel.Location = new System.Drawing.Point(141, 202);
            this.Txt_DescLevel.Name = "Txt_DescLevel";
            this.Txt_DescLevel.Size = new System.Drawing.Size(176, 21);
            this.Txt_DescLevel.TabIndex = 2;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Search.Image")));
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Search.Location = new System.Drawing.Point(22, 236);
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
            this.Btn_Edit.Location = new System.Drawing.Point(214, 237);
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
            this.Btn_Delete.Location = new System.Drawing.Point(118, 237);
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
            this.Btn_Refresh.Location = new System.Drawing.Point(22, 237);
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
            this.btnAdd.Location = new System.Drawing.Point(310, 238);
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
            this.Btn_Save.Location = new System.Drawing.Point(310, 237);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(84, 83);
            this.Btn_Save.TabIndex = 78;
            this.Btn_Save.Text = "ذخیره";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Txt_LevelID
            // 
            this.Txt_LevelID.Location = new System.Drawing.Point(136, 338);
            this.Txt_LevelID.Name = "Txt_LevelID";
            this.Txt_LevelID.Size = new System.Drawing.Size(176, 21);
            this.Txt_LevelID.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "کد سطح:";
            // 
            // frmAzmoonLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_LevelID);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Txt_DescLevel);
            this.Controls.Add(this.Lbl_Desc);
            this.Controls.Add(this.Grd_LevelAzmoon);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAzmoonLevel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "تعریف سطح آزمون";
            this.Load += new System.EventHandler(this.frmAzmoonLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_LevelAzmoon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grd_LevelAzmoon;
        private System.Windows.Forms.DataGridViewTextBoxColumn AzmoonLevelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AzmoonLevelDescription;
        private System.Windows.Forms.Label Lbl_Desc;
        private System.Windows.Forms.TextBox Txt_DescLevel;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.TextBox Txt_LevelID;
        private System.Windows.Forms.Label label1;
    }
}