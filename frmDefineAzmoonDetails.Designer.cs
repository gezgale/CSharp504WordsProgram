namespace Logat504
{
    partial class frmDefineAzmoonDetails
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
            this.Grd_Soal = new System.Windows.Forms.DataGridView();
            this.SoalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AzmoonTitleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AzmoonTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoAlDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gozineie1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gozineie2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gozineie3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gozineie4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GozineieSahih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_TitleAzmoon = new System.Windows.Forms.Label();
            this.Lbl_SoalDesc = new System.Windows.Forms.Label();
            this.Lbl_Gozine1 = new System.Windows.Forms.Label();
            this.Lbl_Gozine2 = new System.Windows.Forms.Label();
            this.Lbl_Gozine3 = new System.Windows.Forms.Label();
            this.Lbl_gozine4 = new System.Windows.Forms.Label();
            this.Lbl_Sahih = new System.Windows.Forms.Label();
            this.Txt_SoalDesc = new System.Windows.Forms.TextBox();
            this.Cmb_TitleAzmoon = new System.Windows.Forms.ComboBox();
            this.Txt_Gozine1 = new System.Windows.Forms.TextBox();
            this.Txt_Gozine2 = new System.Windows.Forms.TextBox();
            this.Txt_Gozine3 = new System.Windows.Forms.TextBox();
            this.Txt_Gozine4 = new System.Windows.Forms.TextBox();
            this.Txt_GozineSahih = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Txt_SoalID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Soal)).BeginInit();
            this.SuspendLayout();
            // 
            // Grd_Soal
            // 
            this.Grd_Soal.AllowUserToAddRows = false;
            this.Grd_Soal.AllowUserToDeleteRows = false;
            this.Grd_Soal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Soal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoalID,
            this.AzmoonTitleID,
            this.AzmoonTitle,
            this.SoAlDescription,
            this.Gozineie1,
            this.Gozineie2,
            this.Gozineie3,
            this.Gozineie4,
            this.GozineieSahih});
            this.Grd_Soal.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grd_Soal.Location = new System.Drawing.Point(0, 0);
            this.Grd_Soal.Name = "Grd_Soal";
            this.Grd_Soal.ReadOnly = true;
            this.Grd_Soal.Size = new System.Drawing.Size(843, 297);
            this.Grd_Soal.TabIndex = 0;
            this.Grd_Soal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_Soal_CellClick);
            // 
            // SoalID
            // 
            this.SoalID.DataPropertyName = "SoalID";
            this.SoalID.HeaderText = "کد سوال";
            this.SoalID.Name = "SoalID";
            this.SoalID.ReadOnly = true;
            this.SoalID.Width = 80;
            // 
            // AzmoonTitleID
            // 
            this.AzmoonTitleID.DataPropertyName = "AzmoonTitleID";
            this.AzmoonTitleID.HeaderText = "کد عنوان آزمون";
            this.AzmoonTitleID.Name = "AzmoonTitleID";
            this.AzmoonTitleID.ReadOnly = true;
            // 
            // AzmoonTitle
            // 
            this.AzmoonTitle.DataPropertyName = "AzmoonTitle";
            this.AzmoonTitle.HeaderText = "عنوان آزمون";
            this.AzmoonTitle.Name = "AzmoonTitle";
            this.AzmoonTitle.ReadOnly = true;
            this.AzmoonTitle.Width = 200;
            // 
            // SoAlDescription
            // 
            this.SoAlDescription.DataPropertyName = "SoAlDescription";
            this.SoAlDescription.HeaderText = "صورت سوال";
            this.SoAlDescription.Name = "SoAlDescription";
            this.SoAlDescription.ReadOnly = true;
            this.SoAlDescription.Width = 200;
            // 
            // Gozineie1
            // 
            this.Gozineie1.DataPropertyName = "Gozineie1";
            this.Gozineie1.HeaderText = "گزینه 1";
            this.Gozineie1.Name = "Gozineie1";
            this.Gozineie1.ReadOnly = true;
            this.Gozineie1.Width = 200;
            // 
            // Gozineie2
            // 
            this.Gozineie2.DataPropertyName = "Gozineie2";
            this.Gozineie2.HeaderText = "گزینه 2";
            this.Gozineie2.Name = "Gozineie2";
            this.Gozineie2.ReadOnly = true;
            this.Gozineie2.Width = 200;
            // 
            // Gozineie3
            // 
            this.Gozineie3.DataPropertyName = "Gozineie3";
            this.Gozineie3.HeaderText = "گزینه 3";
            this.Gozineie3.Name = "Gozineie3";
            this.Gozineie3.ReadOnly = true;
            this.Gozineie3.Width = 200;
            // 
            // Gozineie4
            // 
            this.Gozineie4.DataPropertyName = "Gozineie4";
            this.Gozineie4.HeaderText = "گزینه 4";
            this.Gozineie4.Name = "Gozineie4";
            this.Gozineie4.ReadOnly = true;
            this.Gozineie4.Width = 200;
            // 
            // GozineieSahih
            // 
            this.GozineieSahih.DataPropertyName = "GozineieSahih";
            this.GozineieSahih.HeaderText = "گزینه صحیح";
            this.GozineieSahih.Name = "GozineieSahih";
            this.GozineieSahih.ReadOnly = true;
            // 
            // Lbl_TitleAzmoon
            // 
            this.Lbl_TitleAzmoon.AutoSize = true;
            this.Lbl_TitleAzmoon.Location = new System.Drawing.Point(770, 373);
            this.Lbl_TitleAzmoon.Name = "Lbl_TitleAzmoon";
            this.Lbl_TitleAzmoon.Size = new System.Drawing.Size(82, 16);
            this.Lbl_TitleAzmoon.TabIndex = 1;
            this.Lbl_TitleAzmoon.Text = "عنوان آزمون :";
            // 
            // Lbl_SoalDesc
            // 
            this.Lbl_SoalDesc.AutoSize = true;
            this.Lbl_SoalDesc.Location = new System.Drawing.Point(770, 399);
            this.Lbl_SoalDesc.Name = "Lbl_SoalDesc";
            this.Lbl_SoalDesc.Size = new System.Drawing.Size(83, 16);
            this.Lbl_SoalDesc.TabIndex = 2;
            this.Lbl_SoalDesc.Text = "صورت سوال :";
            // 
            // Lbl_Gozine1
            // 
            this.Lbl_Gozine1.AutoSize = true;
            this.Lbl_Gozine1.Location = new System.Drawing.Point(770, 427);
            this.Lbl_Gozine1.Name = "Lbl_Gozine1";
            this.Lbl_Gozine1.Size = new System.Drawing.Size(51, 16);
            this.Lbl_Gozine1.TabIndex = 3;
            this.Lbl_Gozine1.Text = "گزینه ا :";
            // 
            // Lbl_Gozine2
            // 
            this.Lbl_Gozine2.AutoSize = true;
            this.Lbl_Gozine2.Location = new System.Drawing.Point(770, 457);
            this.Lbl_Gozine2.Name = "Lbl_Gozine2";
            this.Lbl_Gozine2.Size = new System.Drawing.Size(55, 16);
            this.Lbl_Gozine2.TabIndex = 4;
            this.Lbl_Gozine2.Text = "گزینه 2 :";
            // 
            // Lbl_Gozine3
            // 
            this.Lbl_Gozine3.AutoSize = true;
            this.Lbl_Gozine3.Location = new System.Drawing.Point(770, 482);
            this.Lbl_Gozine3.Name = "Lbl_Gozine3";
            this.Lbl_Gozine3.Size = new System.Drawing.Size(55, 16);
            this.Lbl_Gozine3.TabIndex = 5;
            this.Lbl_Gozine3.Text = "گزینه 3 :";
            // 
            // Lbl_gozine4
            // 
            this.Lbl_gozine4.AutoSize = true;
            this.Lbl_gozine4.Location = new System.Drawing.Point(770, 509);
            this.Lbl_gozine4.Name = "Lbl_gozine4";
            this.Lbl_gozine4.Size = new System.Drawing.Size(55, 16);
            this.Lbl_gozine4.TabIndex = 6;
            this.Lbl_gozine4.Text = "گزینه 4 :";
            // 
            // Lbl_Sahih
            // 
            this.Lbl_Sahih.AutoSize = true;
            this.Lbl_Sahih.Location = new System.Drawing.Point(770, 533);
            this.Lbl_Sahih.Name = "Lbl_Sahih";
            this.Lbl_Sahih.Size = new System.Drawing.Size(81, 16);
            this.Lbl_Sahih.TabIndex = 7;
            this.Lbl_Sahih.Text = "گزینه صحیح :";
            // 
            // Txt_SoalDesc
            // 
            this.Txt_SoalDesc.Location = new System.Drawing.Point(161, 398);
            this.Txt_SoalDesc.Name = "Txt_SoalDesc";
            this.Txt_SoalDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_SoalDesc.Size = new System.Drawing.Size(603, 22);
            this.Txt_SoalDesc.TabIndex = 8;
            // 
            // Cmb_TitleAzmoon
            // 
            this.Cmb_TitleAzmoon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_TitleAzmoon.FormattingEnabled = true;
            this.Cmb_TitleAzmoon.Location = new System.Drawing.Point(592, 369);
            this.Cmb_TitleAzmoon.Name = "Cmb_TitleAzmoon";
            this.Cmb_TitleAzmoon.Size = new System.Drawing.Size(172, 22);
            this.Cmb_TitleAzmoon.TabIndex = 9;
            // 
            // Txt_Gozine1
            // 
            this.Txt_Gozine1.Location = new System.Drawing.Point(161, 425);
            this.Txt_Gozine1.Name = "Txt_Gozine1";
            this.Txt_Gozine1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Gozine1.Size = new System.Drawing.Size(603, 22);
            this.Txt_Gozine1.TabIndex = 10;
            // 
            // Txt_Gozine2
            // 
            this.Txt_Gozine2.Location = new System.Drawing.Point(161, 453);
            this.Txt_Gozine2.Name = "Txt_Gozine2";
            this.Txt_Gozine2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Gozine2.Size = new System.Drawing.Size(603, 22);
            this.Txt_Gozine2.TabIndex = 11;
            // 
            // Txt_Gozine3
            // 
            this.Txt_Gozine3.Location = new System.Drawing.Point(161, 478);
            this.Txt_Gozine3.Name = "Txt_Gozine3";
            this.Txt_Gozine3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Gozine3.Size = new System.Drawing.Size(603, 22);
            this.Txt_Gozine3.TabIndex = 12;
            // 
            // Txt_Gozine4
            // 
            this.Txt_Gozine4.Location = new System.Drawing.Point(161, 505);
            this.Txt_Gozine4.Name = "Txt_Gozine4";
            this.Txt_Gozine4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Gozine4.Size = new System.Drawing.Size(603, 22);
            this.Txt_Gozine4.TabIndex = 13;
            // 
            // Txt_GozineSahih
            // 
            this.Txt_GozineSahih.Location = new System.Drawing.Point(711, 531);
            this.Txt_GozineSahih.Name = "Txt_GozineSahih";
            this.Txt_GozineSahih.Size = new System.Drawing.Size(53, 22);
            this.Txt_GozineSahih.TabIndex = 14;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Image = global::Logat504.Properties.Resources.Search_Sm;
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Search.Location = new System.Drawing.Point(12, 306);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(90, 83);
            this.Btn_Search.TabIndex = 45;
            this.Btn_Search.Text = "جستجو کردن";
            this.Btn_Search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Image = global::Logat504.Properties.Resources.Edit_Btn_Sm;
            this.Btn_Edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Edit.Location = new System.Drawing.Point(203, 306);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(90, 83);
            this.Btn_Edit.TabIndex = 44;
            this.Btn_Edit.Text = "ویرایش کردن";
            this.Btn_Edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Image = global::Logat504.Properties.Resources.Delete_Btn_Sm;
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Delete.Location = new System.Drawing.Point(107, 306);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(90, 83);
            this.Btn_Delete.TabIndex = 43;
            this.Btn_Delete.Text = "حذف کردن";
            this.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Image = global::Logat504.Properties.Resources.Add_Btn_Sm;
            this.Btn_Add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Add.Location = new System.Drawing.Point(299, 307);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(84, 83);
            this.Btn_Add.TabIndex = 42;
            this.Btn_Add.Text = "اضافه کردن";
            this.Btn_Add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Image = global::Logat504.Properties.Resources.Save_Sma;
            this.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Save.Location = new System.Drawing.Point(299, 306);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(84, 83);
            this.Btn_Save.TabIndex = 46;
            this.Btn_Save.Text = "ذخیره";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Image = global::Logat504.Properties.Resources.refresh1001_Sm;
            this.Btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Refresh.Location = new System.Drawing.Point(12, 306);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(90, 83);
            this.Btn_Refresh.TabIndex = 47;
            this.Btn_Refresh.Text = "بازنشانی";
            this.Btn_Refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Txt_SoalID
            // 
            this.Txt_SoalID.Location = new System.Drawing.Point(370, 573);
            this.Txt_SoalID.Name = "Txt_SoalID";
            this.Txt_SoalID.Size = new System.Drawing.Size(53, 22);
            this.Txt_SoalID.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 576);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "کد سوال:";
            // 
            // frmDefineAzmoonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_SoalID);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Txt_GozineSahih);
            this.Controls.Add(this.Txt_Gozine4);
            this.Controls.Add(this.Txt_Gozine3);
            this.Controls.Add(this.Txt_Gozine2);
            this.Controls.Add(this.Txt_Gozine1);
            this.Controls.Add(this.Cmb_TitleAzmoon);
            this.Controls.Add(this.Txt_SoalDesc);
            this.Controls.Add(this.Lbl_Sahih);
            this.Controls.Add(this.Lbl_gozine4);
            this.Controls.Add(this.Lbl_Gozine3);
            this.Controls.Add(this.Lbl_Gozine2);
            this.Controls.Add(this.Lbl_Gozine1);
            this.Controls.Add(this.Lbl_SoalDesc);
            this.Controls.Add(this.Lbl_TitleAzmoon);
            this.Controls.Add(this.Grd_Soal);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDefineAzmoonDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "تعریف جزئیات آزمونها";
            this.Load += new System.EventHandler(this.frmDefineAzmoonDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Soal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grd_Soal;
        private System.Windows.Forms.Label Lbl_TitleAzmoon;
        private System.Windows.Forms.Label Lbl_SoalDesc;
        private System.Windows.Forms.Label Lbl_Gozine1;
        private System.Windows.Forms.Label Lbl_Gozine2;
        private System.Windows.Forms.Label Lbl_Gozine3;
        private System.Windows.Forms.Label Lbl_gozine4;
        private System.Windows.Forms.Label Lbl_Sahih;
        private System.Windows.Forms.TextBox Txt_SoalDesc;
        private System.Windows.Forms.ComboBox Cmb_TitleAzmoon;
        private System.Windows.Forms.TextBox Txt_Gozine1;
        private System.Windows.Forms.TextBox Txt_Gozine2;
        private System.Windows.Forms.TextBox Txt_Gozine3;
        private System.Windows.Forms.TextBox Txt_Gozine4;
        private System.Windows.Forms.TextBox Txt_GozineSahih;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AzmoonTitleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AzmoonTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoAlDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gozineie1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gozineie2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gozineie3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gozineie4;
        private System.Windows.Forms.DataGridViewTextBoxColumn GozineieSahih;
        private System.Windows.Forms.TextBox Txt_SoalID;
        private System.Windows.Forms.Label label1;
    }
}