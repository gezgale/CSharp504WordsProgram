namespace Logat504
{
    partial class frmRepAzmoonHa
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtblKarnameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Lbl_UserName = new System.Windows.Forms.Label();
            this.Cmb_UserInfo = new System.Windows.Forms.ComboBox();
            this.Btn_ShowReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xtblKarnameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.xtblKarnameBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Logat504.Report_Azmoon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 66);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(998, 577);
            this.reportViewer1.TabIndex = 0;
            // 
            // xtblKarnameBindingSource
            // 
            this.xtblKarnameBindingSource.DataSource = typeof(Logat504.xtblKarname);
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.AutoSize = true;
            this.Lbl_UserName.Location = new System.Drawing.Point(869, 22);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.Size = new System.Drawing.Size(101, 13);
            this.Lbl_UserName.TabIndex = 1;
            this.Lbl_UserName.Text = "مشخصات زبان آموز :";
            // 
            // Cmb_UserInfo
            // 
            this.Cmb_UserInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_UserInfo.FormattingEnabled = true;
            this.Cmb_UserInfo.Location = new System.Drawing.Point(390, 19);
            this.Cmb_UserInfo.Name = "Cmb_UserInfo";
            this.Cmb_UserInfo.Size = new System.Drawing.Size(473, 21);
            this.Cmb_UserInfo.TabIndex = 2;
            // 
            // Btn_ShowReport
            // 
            this.Btn_ShowReport.Location = new System.Drawing.Point(295, 18);
            this.Btn_ShowReport.Name = "Btn_ShowReport";
            this.Btn_ShowReport.Size = new System.Drawing.Size(75, 23);
            this.Btn_ShowReport.TabIndex = 3;
            this.Btn_ShowReport.Text = "مشاهده";
            this.Btn_ShowReport.UseVisualStyleBackColor = true;
            this.Btn_ShowReport.Click += new System.EventHandler(this.Btn_ShowReport_Click);
            // 
            // frmRepAzmoonHa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 643);
            this.Controls.Add(this.Btn_ShowReport);
            this.Controls.Add(this.Cmb_UserInfo);
            this.Controls.Add(this.Lbl_UserName);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRepAzmoonHa";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "گزارش آزمونها به تفکیک نام آزمون دهنده";
            this.Load += new System.EventHandler(this.frmRepAzmoonHa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtblKarnameBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource xtblKarnameBindingSource;
        private System.Windows.Forms.Label Lbl_UserName;
        private System.Windows.Forms.ComboBox Cmb_UserInfo;
        private System.Windows.Forms.Button Btn_ShowReport;
    }
}