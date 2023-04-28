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
    public partial class frmSabteLoghat : Form
    {
        public frmSabteLoghat()
        {
            InitializeComponent();
        }

        private void UDF_ClearTextBox()
        {
            Txt_Motaradef.Text = String.Empty;
            Txt_Saier.Text = String.Empty;
            Txt_WordEnglish.Text = String.Empty;
            Txt_WordFarsi.Text = String.Empty;
        }

        private void UDF_grdFill()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.tblLoghatHas
                        orderby Row.LogatID descending
                        select new
                        {
                            Row.LogatID,
                            Row.LogatEnglish,
                            Row.LoghatFarsi ,
                            Row.LoghatMotaradef ,
                            Row.LogatSaier ,
                            Row.DateOfAdd ,
                            Row.AdderUserName 
                        };
            Grd_Word.DataSource = Query;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Txt_Saier.Text = String.Empty;
            Txt_Motaradef.Text = String.Empty;
            Txt_WordFarsi.Text = String.Empty;
            Txt_WordEnglish.Text = String.Empty;
            btnAdd.SendToBack();
            Btn_Save.BringToFront();
            MessageBox.Show("لطفا موارد را وارد کنید");
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Txt_WordEnglish.Text == "" || Txt_WordFarsi.Text == "" || Txt_Motaradef.Text == "" || Txt_Saier.Text == "")
            {
                MessageBox.Show("ورود موارد خواسته شده الزامی است");
                return;
            }
            Class_tblLoghatHa clsWord = new Class_tblLoghatHa(Txt_WordEnglish.Text.Trim(), Txt_WordFarsi.Text.Trim(), Txt_Motaradef.Text.Trim(), Txt_Saier.Text.Trim(), GlobalClass.ThisLogedUserName);
            if (clsWord.UDF_CheckWord() == true)
            {
                MessageBox.Show("لغت انگلیسی وارد شده تکراری است ");
                return;
            }
            clsWord.UDF_Save();
            UDF_grdFill();
            UDF_ClearTextBox();
            btnAdd.BringToFront();
            Btn_Save.SendToBack();
            MessageBox.Show("رکورد جدید درج شد");

        }

        private void frmSabteLoghat_Load(object sender, EventArgs e)
        {
            UDF_grdFill();
        }

        private void Grd_Word_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedCellCount = Grd_Word.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (Grd_Word.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    for (int i = 0; i < selectedCellCount; i++)
                    {
                       Txt_LoghatId.Text = Grd_Word.Rows[int.Parse(Grd_Word.SelectedCells[i].RowIndex.ToString())].Cells[0].Value.ToString();
                       Txt_WordEnglish.Text = Grd_Word.Rows[int.Parse(Grd_Word.SelectedCells[i].RowIndex.ToString())].Cells[1].Value.ToString();
                       Txt_WordFarsi.Text = Grd_Word.Rows[int.Parse(Grd_Word.SelectedCells[i].RowIndex.ToString())].Cells[2].Value.ToString();
                      Txt_Motaradef.Text = Grd_Word.Rows[int.Parse(Grd_Word.SelectedCells[i].RowIndex.ToString())].Cells[3].Value.ToString();
                      Txt_Saier.Text = Grd_Word.Rows[int.Parse(Grd_Word.SelectedCells[i].RowIndex.ToString())].Cells[4].Value.ToString();

                    }
                }
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
             if(Txt_WordEnglish.Text == "")
            {
                MessageBox.Show("انتخاب لغت انگلیسی مورد نظر برای حذف الزامی است");
                return;
            }
            DialogResult dr = MessageBox.Show("آیا نسبت به عمل حذف اطمینان دارید؟" ,"اخطاریه حذف" ,MessageBoxButtons.OKCancel ,MessageBoxIcon.Warning );
            if (dr == DialogResult.OK)
            {
                Class_tblLoghatHa clsLoghat = new Class_tblLoghatHa(Txt_WordEnglish.Text.Trim());
                clsLoghat.UDF_Delete();
                UDF_grdFill();
                UDF_ClearTextBox();
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Txt_WordEnglish.Text == "")
            {
                MessageBox.Show("انتخاب  لغت انگلیسی مورد نظر بای ویرایش الزامی است");
                return;
            }
            DialogResult dr = MessageBox.Show("آیا نسبت به عمل ویرایش اطمینان دارید" ,"اخطاریه ویرایش" ,MessageBoxButtons.OKCancel , MessageBoxIcon.Warning );
            if (dr == DialogResult.OK)
            {
                Class_tblLoghatHa claLoghat = new Class_tblLoghatHa(Txt_WordEnglish.Text.Trim(), Txt_WordFarsi.Text.Trim(), Txt_Motaradef.Text.Trim(), Txt_Saier.Text.Trim());
                claLoghat.UDF_Edit();
                UDF_ClearTextBox();
                UDF_grdFill();
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Txt_Search.Text == "")
            {
                MessageBox.Show("فیلد جستجو یا بخشی از آن را وارد نمایید");
                return;
            }
            if (Rdo_English.Checked == true)
            {
                LSC_504LogatDataContext db = new LSC_504LogatDataContext();
                var Query = from Row in db.tblLoghatHas
                            where SqlMethods.Like(Row.LogatEnglish, "%" + Txt_Search.Text.Trim() + "%")
                            select new
                            {
                                Row.LogatID,
                                Row.LogatEnglish,
                                Row.LoghatFarsi ,
                                Row.LoghatMotaradef ,
                                Row.LogatSaier ,
                                Row.DateOfAdd ,
                                Row.AdderUserName 
                               
                            };
                Grd_Word.DataSource = Query;
                if (Query.Count() <= 0)
                {
                    Txt_Search.Text = "";
                    Btn_Refresh.BringToFront();
                    Btn_Search.SendToBack();
                    MessageBox.Show("رکوردی یافته نشد");
                }
            }
            else if (Rdo_Farsi.Checked == true)
            {
                LSC_504LogatDataContext db = new LSC_504LogatDataContext();
                var Query = from Row in db.tblLoghatHas
                            where SqlMethods.Like(Row.LoghatFarsi , "%" + Txt_Search.Text.Trim() + "%")
                            select new
                            {
                                Row.LogatID,
                                Row.LogatEnglish,
                                Row.LoghatFarsi,
                                Row.LoghatMotaradef,
                                Row.LogatSaier,
                                Row.DateOfAdd,
                                Row.AdderUserName

                            };
                Grd_Word.DataSource = Query;
                if (Query.Count() <= 0)
                {
                    Txt_Search.Text = "";
                    Btn_Refresh.BringToFront();
                    Btn_Search.SendToBack();
                    MessageBox.Show("رکوردی یافته نشد");
                }
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            UDF_grdFill();
            Btn_Search.BringToFront();
            Btn_Refresh.SendToBack();
        }
    }
}
