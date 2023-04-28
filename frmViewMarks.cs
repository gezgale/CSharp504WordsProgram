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
    public partial class frmViewMarks : Form
    {
        public frmViewMarks()
        {
            InitializeComponent();
        }

        private void frmViewMarks_Load(object sender, EventArgs e)
        {
            if (GlobalClass.ThisLogedUserID == 1)
            {
                UDF_GetUserLists();
                UDF_GetAllMarksList();
            }
            else
            {
                Cmb_Users.Enabled = false;
                Btn_ViewMarks.Enabled = false;
                UDF_GetUserMarks();
            }
        }

        private void UDF_GetUserMarks()
        {
            Class_tblAzmoonNatijeh NomrehList = new Class_tblAzmoonNatijeh();
            Grd_Marks.DataSource = NomrehList.UDF_GetTotalMarksWithUserName(GlobalClass.ThisLogedUserName.Trim()); 
        }

        private void UDF_GetUserLists()
        {
            Class_XtblUsers UsrLst = new Class_XtblUsers();
            Cmb_Users.ValueMember = "UserNAme";
            Cmb_Users.DisplayMember = "NameSname";
            Cmb_Users.DataSource = UsrLst.UDF_GetUsers();
        }

        private void UDF_GetAllMarksList()
        {
            Class_tblAzmoonNatijeh NomrehList = new Class_tblAzmoonNatijeh();
            Grd_Marks.DataSource = NomrehList.UDF_GetTotalMarks(); 
        }

        private void Btn_ViewMarks_Click(object sender, EventArgs e)
        {
            Class_tblAzmoonNatijeh NomrehList = new Class_tblAzmoonNatijeh();
            Grd_Marks.DataSource = NomrehList.UDF_GetTotalMarksWithUserName(Cmb_Users.SelectedValue.ToString()); 
        }
    }
}
