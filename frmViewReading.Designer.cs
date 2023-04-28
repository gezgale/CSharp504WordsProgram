namespace Logat504
{
    partial class frmViewReading
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
            this.Txt_Reading = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt_Reading
            // 
            this.Txt_Reading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Txt_Reading.Location = new System.Drawing.Point(0, 67);
            this.Txt_Reading.Multiline = true;
            this.Txt_Reading.Name = "Txt_Reading";
            this.Txt_Reading.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Reading.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Txt_Reading.Size = new System.Drawing.Size(704, 346);
            this.Txt_Reading.TabIndex = 0;
            // 
            // frmViewReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 413);
            this.Controls.Add(this.Txt_Reading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmViewReading";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مشاهده Reading";
            this.Load += new System.EventHandler(this.frmViewReading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Reading;
    }
}