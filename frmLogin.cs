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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            try
            {
                tblUser LogUsers = db.tblUsers.Single(n => n.UserNAme.Trim() == Txt_UserName.Text.Trim() && n.UserPWA.Trim() == Txt_Password.Text.Trim());
                if (LogUsers.UserNAme.Trim() != "")
                {
                    GlobalClass.ThisLogedUserName = Txt_UserName.Text.Trim();
                    GlobalClass.ThisLogedUserID = int.Parse(LogUsers.UserTypeID.ToString().Trim());
                    Txt_UserName.Clear();
                    Txt_Password.Clear();
                    this.Hide();
                    frmMainMdi frm = new frmMainMdi();
                    frm.ShowDialog();
                }
                else
                {
                    Txt_UserName.Clear();
                    Txt_Password.Clear();
                    MessageBox.Show("نام کاربری و یا کلمه عبور صحیح وارد نشده است");
                }
            }
            catch
            {
                Txt_UserName.Clear();
                Txt_Password.Clear();
                MessageBox.Show("نام کاربری و یا کلمه عبور صحیح وارد نشده است");
            }
            
        }
    }
}
