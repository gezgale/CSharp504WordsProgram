using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Logat504
{
    public partial class frmMainMdi : Form
    {
        frmSabteLoghat frm1;
        frmSearchLogat frm2;
        frmDefineAzmoon frm3;
        frmDefineAzmoonDetails frm4;
        frmActAzmoon frm5;
        frmEditProfile frm6;
        frmEditProfiles frm7;
        frmRepAzmoonHa frm8;
        frmViewMarks frm9;
        frmAzmoonLevel frm10;

        public frmMainMdi()
        {
            InitializeComponent();
        }

        private void Mnu_File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMainMdi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mnuFileSabtLogatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm1 == null || frm1.IsDisposed)
            {
                frm1 = new frmSabteLoghat();
                frm1.MdiParent = this;
                
                frm1.Show();
            }
            else
            {
                frm1.Activate();
            }
        }

        private void Mnu_File_Serach_Click(object sender, EventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new frmSearchLogat();
                frm2.MdiParent = this;
                frm2.Show();
            }
            else
            {
                frm2.Activate();
            }
        }

        private void Mnu_File_DefExam_Click(object sender, EventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new frmDefineAzmoon();
                frm3.MdiParent = this;
                frm3.Show();
            }
            else
            {
                frm3.Activate();
            }
        }

        private void Mnu_File_DefExamDetails_Click(object sender, EventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new frmDefineAzmoonDetails();
                frm4.MdiParent = this;
                frm4.Show();
            }
            else
            {
                frm4.Activate();
            }
        }

        private void Mnu_Exam_Ex_Click(object sender, EventArgs e)
        {
            if (frm5 == null || frm5.IsDisposed)
            {
                frm5 = new frmActAzmoon();
                frm5.MdiParent = this;
                frm5.Show();
            }
            else
            {
                frm5.Activate();
            }
        }

        private void Mnu_Secur_EditProfile_Click(object sender, EventArgs e)
        {
            if (frm6 == null || frm6.IsDisposed)
            {
                frm6 = new frmEditProfile();
                frm6.MdiParent = this;
                frm6.Show();
            }
            else
            {
                frm6.Activate();
            }
        }

        private void Mnu_Secur_EditUsers_Click(object sender, EventArgs e)
        {
            if (frm7 == null || frm7.IsDisposed)
            {
                frm7 = new frmEditProfiles();
                frm7.MdiParent = this;
                frm7.Show();
            }
            else
            {
                frm7.Activate();
            }
        }

        private void Mnu_Reports_Azmoonah_Click(object sender, EventArgs e)
        {
            if (frm8 == null || frm8.IsDisposed)
            {
                frm8 = new frmRepAzmoonHa();
                frm8.MdiParent = this;
                frm8.Show();
            }
            else
            {
                frm8.Activate();
            }
        }

        private void Mnu_Exam_Savabegh_Click(object sender, EventArgs e)
        {
            if (frm9 == null || frm9.IsDisposed)
            {
                frm9 = new frmViewMarks();
                frm9.MdiParent = this;
                frm9.Show();
            }
            else
            {
                frm9.Activate();
            }
        }

        private void frmMainMdi_Load(object sender, EventArgs e)
        {
            String Str_UserState = String.Empty;
            Class_Current_Day_Name CurrentDayN = new Class_Current_Day_Name(DateTime.Now);
            
            if (GlobalClass.ThisLogedUserID == 1)
                Str_UserState = "مدیر ارشد";
            else
                Str_UserState = "کاربر عادی";

            toolStripStatusLabel.Text = CurrentDayN.CRCompleteShamsiDate + " - " + "وارد شده با " + GlobalClass.ThisLogedUserName + " - نوع کاربر : " + Str_UserState;

            if (GlobalClass.ThisLogedUserID != 1)
            {
                mnuFileSabtLogatToolStripMenuItem.Visible = false;
                Mnu_File_Serach.Visible  = false;
                Mnu_File_DefExam.Visible = false;
                Mnu_File_AzmoonType.Visible = false;
                Mnu_File_DefExamDetails.Visible = false;
                Mnu_Secur_EditUsers.Visible = false;
                Mnu_Reports.Visible = false;
            }
        }

        private void Mnu_File_AzmoonType_Click(object sender, EventArgs e)
        {
            if (frm10 == null || frm10.IsDisposed)
            {
                frm10 = new frmAzmoonLevel();
                frm10.MdiParent = this;
                frm10.Show();
            }
            else
            {
                frm10.Activate();
            }
        }
    }
}
