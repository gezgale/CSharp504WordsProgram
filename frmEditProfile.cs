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
    public partial class frmEditProfile : Form
    {
        public frmEditProfile()
        {
            InitializeComponent();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
              DialogResult dr = MessageBox.Show("آیا نسبت به ویرایش مشخصات کاربری خود اطمینان دارید؟" , "اخطار ویرایش مشخصات کاربری" , MessageBoxButtons.OKCancel ,MessageBoxIcon.Warning);
              if (dr == DialogResult.OK)
              {
                  Class_tblUsers clsUsertb = new Class_tblUsers(Txt_UserName.Text.Trim(), Txt_Pass.Text.Trim(), Txt_Name.Text.Trim(), Txt_Family.Text.Trim(), Txt_Tell.Text.Trim(), Txt_Email.Text.Trim());
                  clsUsertb.UDF_EditProfile();
              }
        }

        private void frmEditProfile_Load(object sender, EventArgs e)
        {
            Class_tblUsers clsUserTb = new Class_tblUsers(GlobalClass.ThisLogedUserName);
            clsUserTb.UDF_ReternInfo();
            Txt_UserName.Text = clsUserTb.Str_UserName2;
            Txt_Pass.Text = clsUserTb.Str_Password2;
            Txt_Name.Text = clsUserTb.Str_Name2;
            Txt_Family.Text = clsUserTb.Str_Family2;
            Txt_Email.Text = clsUserTb.Str_Email2;
            Txt_Tell.Text = clsUserTb.Str_Tell2;
        }
    }
}
