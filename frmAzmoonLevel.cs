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
    public partial class frmAzmoonLevel : Form
    {
        public frmAzmoonLevel()
        {
            InitializeComponent();
        }

        private void UDF_grdFill()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.tblAzmoonLevels
                        select new
                        {
                            Row.AzmoonLevelID ,
                            Row.AzmoonLevelDescription 
                        };
            Grd_LevelAzmoon.DataSource = Query;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Txt_DescLevel.Text = String.Empty;
            btnAdd.SendToBack();
            Btn_Save.BringToFront();
            MessageBox.Show("لطفا موارد را وارد کنید");
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Txt_DescLevel.Text == "")
            {
                MessageBox.Show("ورود موارد خواسته شده الزامی است");
                return;
            }
            Class_tblAzmoonLevels clsAzmntb = new Class_tblAzmoonLevels(Txt_DescLevel.Text.Trim());
            if (clsAzmntb.UDF_ReternDescAzmoon() == true)
            {
                MessageBox.Show("عنوان سطح آزمون تکراری است");
                return;
            }
            else
            {
                clsAzmntb.UDF_Save();
                btnAdd.BringToFront();
                Btn_Save.SendToBack();
                Txt_DescLevel.Text = String.Empty;
                UDF_grdFill();
                MessageBox.Show("رکورد جدید درج شد");
            }
        }

        private void frmAzmoonLevel_Load(object sender, EventArgs e)
        {
            UDF_grdFill();
        }

        private void Grd_LevelAzmoon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedCellCount = Grd_LevelAzmoon.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (Grd_LevelAzmoon.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    for (int i = 0; i < selectedCellCount; i++)
                    {
                        Txt_LevelID.Text = Grd_LevelAzmoon.Rows[int.Parse(Grd_LevelAzmoon.SelectedCells[i].RowIndex.ToString())].Cells[0].Value.ToString();
                        Txt_DescLevel.Text = Grd_LevelAzmoon.Rows[int.Parse(Grd_LevelAzmoon.SelectedCells[i].RowIndex.ToString())].Cells[1].Value.ToString();
                      
                    }
                }
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {

            if (Txt_LevelID.Text == "")
            {
                MessageBox.Show("انتخاب سطح آزمون برای حذف الزامی است");
                return;
            }
            DialogResult dr = MessageBox.Show("آیا نسبت به عمل حذف اطمینان دارید؟", "اخطاریه حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                Class_tblAzmoonLevels clsAzmntb = new Class_tblAzmoonLevels(Txt_DescLevel.Text.Trim());
                clsAzmntb.UDF_Delete();
                Txt_DescLevel.Text = String.Empty;
                Txt_LevelID.Text = String.Empty;
                UDF_grdFill();

            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
              if (Txt_LevelID.Text == "")
            {
                MessageBox.Show("انتخاب سطح آزمون مورد نظر برای ویرایش الزامی است");
                return;
            }
            DialogResult dr = MessageBox.Show("آیا نسبت به عمل ویرایش اطمینان دارید" ,"اخطاریه ویرایش" ,MessageBoxButtons.OKCancel , MessageBoxIcon.Warning );
            if (dr == DialogResult.OK)
            {
                Class_tblAzmoonLevels clsAzmntbl = new Class_tblAzmoonLevels(int.Parse(Txt_LevelID.Text.Trim()), Txt_DescLevel.Text.Trim());
                clsAzmntbl.UDF_Edit();
                UDF_grdFill();
                Txt_DescLevel.Text = String.Empty;
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Txt_DescLevel.Text == "")
            {
                MessageBox.Show("عنوان سطح آزمون یا بخشی از عنوان را وارد نمایید");
                return;
            }
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.tblAzmoonLevels 
                        where SqlMethods.Like(Row.AzmoonLevelDescription , "%" + Txt_DescLevel.Text.Trim() + "%")
                        select new
                        {
                            Row.AzmoonLevelID ,
                            Row.AzmoonLevelDescription 

                        };
            Grd_LevelAzmoon.DataSource = Query;

            if (Query.Count() <= 0)
            {
                Txt_DescLevel.Text = "";
                Btn_Refresh.BringToFront();
                Btn_Search.SendToBack();
                MessageBox.Show("رکوردی یافته نشد");
            }

        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            UDF_grdFill();
            Btn_Refresh.SendToBack();
            Btn_Search.BringToFront();
        }
    }
}
