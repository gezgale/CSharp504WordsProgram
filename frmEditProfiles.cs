using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq.SqlClient;


namespace Logat504
{
    public partial class frmEditProfiles : Form
    {
        public frmEditProfiles()
        {
            InitializeComponent();
        }

        private void UDF_cmbFill()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.tblUserTypes
                        select new
                        {
                            Row.UserTypeID ,
                            Row.UserTypeDescription 
                        };
            Cmb_UserType.DataSource = Query;
            Cmb_UserType.DisplayMember = "UserTypeDescription";
            Cmb_UserType.ValueMember = "UserTypeID";
        }

        private void UDF_grdFill()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.tblUsers
                        where Row.UserTypeID != 1
                        select new
                        {
                            Row.UserNAme ,
                            Row.UserPWA ,
                            Row.UserTypeID ,
                            Row.tblUserType.UserTypeDescription ,
                            Row.NameOfUsr ,
                            Row.SNameOfUsr ,
                            Row.MobilePhone ,
                            Row.EmailOfUser 
                            
                        };
            dataGridView1.DataSource = Query;
        }

        private void UDF_ClearTextBox()
        {
            Txt_Email.Text = String.Empty;
            Txt_Family.Text = String.Empty;
            Txt_Name.Text = String.Empty;
            Txt_Password.Text = String.Empty;
            Txt_Tell.Text = String.Empty;
            Txt_UserName.Text = String.Empty;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Txt_Family.Text = String.Empty;
            Txt_Name.Text = String.Empty;
            Txt_Password.Text = String.Empty;
            Txt_Tell.Text = String.Empty;
            Txt_UserName.Text = String.Empty;
            Btn_Add.SendToBack();
            Btn_Save.BringToFront();
            MessageBox.Show("لطفا موارد را وارد کنید");
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Txt_Family.Text == "" ||Txt_Email.Text == "" || Txt_Name.Text == "" || Txt_Password.Text == "" || Txt_Tell.Text == "" || Txt_UserName.Text == "")
            {
                MessageBox.Show("ورود موارد خواسته شده الزامی است");
                return;
            }
            Class_tblUsers clsusertbl = new Class_tblUsers(Txt_UserName.Text.Trim(), Txt_Password.Text.Trim() , Txt_Name.Text.Trim(), Txt_Family.Text.Trim(), Txt_Tell.Text.Trim(), Txt_Email.Text.Trim(), int.Parse(Cmb_UserType.SelectedValue.ToString()));
            if (clsusertbl.UDF_CheckUserName() == true)
            {
                MessageBox.Show("نام کاربری وارد شده تکراری می باشد");
                return;
            }
            clsusertbl.UDF_Save();
            Btn_Add.BringToFront();
            Btn_Save.SendToBack();
            UDF_grdFill();
            UDF_ClearTextBox();
            MessageBox.Show("رکورد جدید درج شد");
        }

        private void frmEditProfiles_Load(object sender, EventArgs e)
        {
            UDF_cmbFill();
            UDF_grdFill();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
             if (Txt_UserName.Text == "")
            {
                MessageBox.Show("انتخاب کاربر مورد نظر برای حذف الزامی است");
                return;
            }
            DialogResult dr = MessageBox.Show("آیا نسبت به عمل حذف اطمینان دارید؟" ,"اخطاریه حذف" ,MessageBoxButtons.OKCancel ,MessageBoxIcon.Warning );
            if (dr == DialogResult.OK)
            {
                Class_tblUsers ClsUsertb = new Class_tblUsers(Txt_UserName.Text.Trim());
                ClsUsertb.UDF_Delete();
                UDF_ClearTextBox();
                UDF_cmbFill();
                UDF_grdFill();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (dataGridView1.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    for (int i = 0; i < selectedCellCount; i++)
                    {
                      
                       // Txt_UserID.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[0].Value.ToString();
                        Txt_UserName.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[0].Value.ToString();
                        Txt_Password.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[1].Value.ToString();
                        //
                        Txt_Name.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[4].Value.ToString();
                        Txt_Family.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[5].Value.ToString();
                        Txt_Tell.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[6].Value.ToString();
                        Txt_Email.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[7].Value.ToString();
                       
                    }
                    UDF_SelectCmbValue(Txt_UserName.Text.Trim());
                }
            }
        
        }
        private void UDF_SelectCmbValue(String Str_UserName)
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            tblUser Users = db.tblUsers.Single(n => n.UserNAme.Trim() == Str_UserName.Trim());
            Cmb_UserType.SelectedValue = Users.UserTypeID;
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Txt_UserName.Text  == "")
            {
                MessageBox.Show("انتخاب کاربر مورد نظر بای ویرایش الزامی است");
                return;
            }
              DialogResult dr = MessageBox.Show("آیا نسبت به عمل ویرایش اطمینان دارید" ,"اخطاریه ویرایش" ,MessageBoxButtons.OKCancel , MessageBoxIcon.Warning );
              if (dr == DialogResult.OK)
              {
                  Class_tblUsers clsUsertb = new Class_tblUsers(Txt_UserName.Text.Trim(), Txt_Password.Text.Trim(), Txt_Name.Text.Trim(), Txt_Family.Text.Trim(), Txt_Tell.Text.Trim(), Txt_Email.Text.Trim(), int.Parse(Cmb_UserType.SelectedValue.ToString()));
                  clsUsertb.UDF_UpDateUser();
                  UDF_ClearTextBox();
                  UDF_cmbFill();
                  UDF_grdFill();
              }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Txt_Search.Text == "")
            {
                MessageBox.Show("اطفا نام کاربری و یا بخشی از آن را وارد کنید");
                return;
            }
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.tblUsers
                        where SqlMethods.Like(Row.UserNAme, "%" + Txt_Search.Text.Trim() + "%")
                        select new
                        {
                            Row.UserNAme,
                            Row.UserPWA,
                            Row.UserTypeID,
                            Row.NameOfUsr ,
                            Row.SNameOfUsr,
                            Row.MobilePhone ,
                            Row.EmailOfUser 
                        };
            dataGridView1.DataSource = Query;
            if (Query.Count() <= 0)
            {
                Txt_Search.Text = "";
                Btn_Refresh.BringToFront();
                Btn_Search.SendToBack();
                MessageBox.Show("رکوردی یافته نشد");
            }


        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            UDF_cmbFill();
            UDF_grdFill();
            Btn_Refresh.SendToBack();
            Btn_Search.BringToFront();
        }
    }
}
