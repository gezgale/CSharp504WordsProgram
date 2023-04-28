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
    public partial class frmDefineAzmoonDetails : Form
    {
        public frmDefineAzmoonDetails()
        {
            InitializeComponent();
        }

        private void UDF_ClearTextBox()
        {
            Txt_Gozine1.Text = String.Empty;
            Txt_Gozine2.Text = String.Empty;
            Txt_Gozine3.Text = String.Empty;
            Txt_Gozine4.Text = String.Empty;
            Txt_GozineSahih.Text = String.Empty;
            Txt_SoalDesc.Text = String.Empty;
        }

        private void UDF_grdFill()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.tblAzmoonSoalats
                        orderby Row.SoalID descending
                        select new
                        {
                            Row.SoalID,
                            Row.AzmoonTitleID ,
                            Row.tblAzmoonTitle.AzmoonTitle ,
                            Row.SoAlDescription ,
                            Row.Gozineie1,
                            Row.Gozineie2,
                            Row.Gozineie3,
                            Row.Gozineie4,
                            Row.GozineieSahih
                        };
            Grd_Soal.DataSource = Query;
        }

        public void UDF_cmbFill()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.tblAzmoonTitles
                        select new
                        {
                            Row.AzmoonID ,
                            Row.AzmoonTitle 
                        };
            Cmb_TitleAzmoon.DataSource = Query;
            Cmb_TitleAzmoon.DisplayMember = "AzmoonTitle";
            Cmb_TitleAzmoon.ValueMember = "AzmoonID";
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            UDF_ClearTextBox();
            Btn_Add.SendToBack();
            Btn_Save.BringToFront();
            MessageBox.Show("لطفا موارد خواسته شده را وارد نمایید");
        }

        private void frmDefineAzmoonDetails_Load(object sender, EventArgs e)
        {
            UDF_cmbFill();
            UDF_grdFill();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Txt_SoalDesc.Text == "" || Txt_Gozine1.Text  == "" || Txt_Gozine2.Text == "" || Txt_Gozine3.Text  == "" || Txt_Gozine4.Text == "" || Txt_GozineSahih.Text == "")
            {
                MessageBox.Show("ورود موارد خواسته شده الزامی است");
                return;
            }
            Class_tblAzmoonSoalat ClsAzmntb = new Class_tblAzmoonSoalat(Decimal.Parse(Cmb_TitleAzmoon.SelectedValue.ToString()), Txt_SoalDesc.Text.Trim(), Txt_Gozine1.Text.Trim(), Txt_Gozine2.Text.Trim(), Txt_Gozine3.Text.Trim(), Txt_Gozine4.Text.Trim(), int.Parse(Txt_GozineSahih.Text.Trim()));
            if (ClsAzmntb.UDF_CheckSoalDesc() == true)
            {
                MessageBox.Show("عنوان سوال وارد شده تکراری است");
                return;
            }
            ClsAzmntb.UDF_Save();
            UDF_ClearTextBox();
            UDF_cmbFill();
            UDF_grdFill();
            Btn_Save.SendToBack();
            Btn_Add.BringToFront();
            MessageBox.Show("رکورد جدید درج شد");
        }

        private void Grd_Soal_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Int32 selectedCellCount = Grd_Soal.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (Grd_Soal.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    for (int i = 0; i < selectedCellCount; i++)
                    {

                        Txt_SoalID.Text = Grd_Soal.Rows[int.Parse(Grd_Soal.SelectedCells[i].RowIndex.ToString())].Cells[0].Value.ToString();
                        Txt_SoalDesc.Text = Grd_Soal.Rows[int.Parse(Grd_Soal.SelectedCells[i].RowIndex.ToString())].Cells[3].Value.ToString();
                        Txt_Gozine1.Text = Grd_Soal.Rows[int.Parse(Grd_Soal.SelectedCells[i].RowIndex.ToString())].Cells[4].Value.ToString();
                        Txt_Gozine2.Text = Grd_Soal.Rows[int.Parse(Grd_Soal.SelectedCells[i].RowIndex.ToString())].Cells[5].Value.ToString();
                        Txt_Gozine3.Text  = Grd_Soal.Rows[int.Parse(Grd_Soal.SelectedCells[i].RowIndex.ToString())].Cells[6].Value.ToString();
                        Txt_Gozine4.Text = Grd_Soal.Rows[int.Parse(Grd_Soal.SelectedCells[i].RowIndex.ToString())].Cells[7].Value.ToString();
                        Txt_GozineSahih.Text = Grd_Soal.Rows[int.Parse(Grd_Soal.SelectedCells[i].RowIndex.ToString())].Cells[8].Value.ToString();

                    }
                    UDF_SelectCmbValue(int.Parse(Txt_SoalID.Text.Trim()));
                }
            }

        }
        private void UDF_SelectCmbValue(int int_SoalID)
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            tblAzmoonSoalat Azmntb = db.tblAzmoonSoalats.Single(n => n.SoalID == int_SoalID);
            Cmb_TitleAzmoon.SelectedValue = Azmntb.AzmoonTitleID;
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
               if (Txt_SoalID.Text == "")
            {
                MessageBox.Show("انتخاب سوال مورد نظر برای حذف الزامی است");
                return;
            }
            DialogResult dr = MessageBox.Show("آیا نسبت به عمل حذف اطمینان دارید؟" ,"اخطاریه حذف" ,MessageBoxButtons.OKCancel ,MessageBoxIcon.Warning );
            if (dr == DialogResult.OK)
            {
                Class_tblAzmoonSoalat ClsAzmntb = new Class_tblAzmoonSoalat(int.Parse(Txt_SoalID.Text.Trim()));
                ClsAzmntb.UDF_Delete();
                UDF_ClearTextBox();
                UDF_cmbFill();
                UDF_grdFill();
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
              if (Txt_SoalID.Text  == "")
            {
                MessageBox.Show("انتخاب سوال مورد نظر برای ویرایش الزامی است");
                return;
            }
              DialogResult dr = MessageBox.Show("آیا نسبت به عمل ویرایش اطمینان دارید" ,"اخطاریه ویرایش" ,MessageBoxButtons.OKCancel , MessageBoxIcon.Warning );
              if (dr == DialogResult.OK)
              {
                  Class_tblAzmoonSoalat ClsAzmntb = new Class_tblAzmoonSoalat(int.Parse(Txt_SoalID.Text.Trim()),Decimal.Parse(Cmb_TitleAzmoon.SelectedValue.ToString()), Txt_SoalDesc.Text.Trim(), Txt_Gozine1.Text.Trim(), Txt_Gozine2.Text.Trim(), Txt_Gozine3.Text.Trim(), Txt_Gozine4.Text.Trim(), int.Parse(Txt_GozineSahih.Text.Trim()));
                  ClsAzmntb.UDF_Edit();
                  UDF_ClearTextBox();
                  UDF_cmbFill();
                  UDF_grdFill();
              }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Txt_SoalDesc.Text  == "")
            {
                MessageBox.Show("اطفا صورت سوال و یا بخشی از آن را وارد کنید");
                return;
            }
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.tblAzmoonSoalats
                        orderby Row.SoalID descending
                        where SqlMethods.Like(Row.SoAlDescription, "%" + Txt_SoalDesc.Text.Trim() + "%")
                        select new
                        {
                            Row.SoalID,
                            Row.AzmoonTitleID,
                            Row.tblAzmoonTitle.AzmoonTitle,
                            Row.SoAlDescription,
                            Row.Gozineie1,
                            Row.Gozineie2,
                            Row.Gozineie3,
                            Row.Gozineie4,
                            Row.GozineieSahih
                        };
            Grd_Soal.DataSource = Query;
            if (Query.Count() <= 0)
            {
                Txt_SoalDesc.Text = "";
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
