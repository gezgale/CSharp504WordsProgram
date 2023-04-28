using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Logat504
{
    public partial class frmDefineAzmoon : Form
    {
        public frmDefineAzmoon()
        {
            InitializeComponent();
        }

        private void frmDefineAzmoon_Load(object sender, EventArgs e)
        {
            UDF_GetAzmoonInfo();
            UDF_GetAzmoonLevels();
        }

        private void UDF_GetAzmoonInfo()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.tblAzmoonTitles
                        select new
                        {
                            Row.AzmoonID,
                            Row.AzmoonLevelID,
                            Row.AzmoonTitle,
                            Row.tblAzmoonLevel.AzmoonLevelDescription,
                            Row.AzmoonReading
                        };
            dataGridView1.DataSource = Query;
        }

        private void UDF_GetAzmoonLevels()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.tblAzmoonLevels
                        select new
                        {
                            Row.AzmoonLevelID,
                            Row.AzmoonLevelDescription
                        };
            Cmb_AzmoonSath.DataSource = Query;
            Cmb_AzmoonSath.DisplayMember = "AzmoonLevelDescription";
            Cmb_AzmoonSath.ValueMember = "AzmoonLevelID";
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
                        Txt_AzmoonTitle.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[2].Value.ToString();
                        Txt_Reading.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[4].Value.ToString();
                        UDF_SelectCmbValue(int.Parse(dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[0].Value.ToString()));
                        Txt_AzmoonTitleID.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[0].Value.ToString();
                    }
                    
                }
            }
        }

        private void UDF_SelectCmbValue(int int_AzmoonID)
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            tblAzmoonTitle AzTile = db.tblAzmoonTitles.Single(n => n.AzmoonID == int_AzmoonID);
            Cmb_AzmoonSath.SelectedValue = AzTile.AzmoonLevelID;
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            String Str_SearchText = String.Empty;
            Str_SearchText = Interaction.InputBox("لطفا عنوان یا بخشی از عنوان را وارد فرمائید", "جستجو");
            if (Str_SearchText.Trim() == "")
            {
                MessageBox.Show("لطفا مقدار عبارت جستجو را وارد فرمائید");
                return;
            }
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.tblAzmoonTitles
                        where SqlMethods.Like(Row.AzmoonTitle , "%" + Str_SearchText.Trim() + "%")
                        select new
                        {
                            Row.AzmoonID,
                            Row.AzmoonLevelID,
                            Row.AzmoonTitle,
                            Row.tblAzmoonLevel.AzmoonLevelDescription,
                            Row.AzmoonReading
                        };
            dataGridView1.DataSource = Query;
            if (Query.Count() <= 0)
            {
                Txt_AzmoonTitle.Text = "";
                Txt_Reading.Text = "";
                Txt_AzmoonTitleID.Text = "";

                Btn_Refresh.BringToFront();
                Btn_Search.SendToBack();
                MessageBox.Show("رکوردی یافته نشد");
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Txt_AzmoonTitle.Text = "";
            Txt_Reading.Text = "";

            Btn_Add.SendToBack();
            Btn_Save.BringToFront();
            MessageBox.Show("لطفا اطلاعات را وارد نمایید");
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Txt_AzmoonTitle.Text.Trim() == "" || Txt_Reading.Text.Trim() == "" || Cmb_AzmoonSath.Text.Trim() == "")
            {
                MessageBox.Show("ورود تمامی مقادیر الزامی می باشد");
                return;
            }
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            try
            {
                tblAzmoonTitle AzTitle = db.tblAzmoonTitles.Single(n => n.AzmoonTitle.Trim() == Txt_AzmoonTitle.Text.Trim());
                MessageBox.Show("عنوان وارد شده تکراری می باشد");
            }
            catch
            {
                Class_tblAzmoonTitle SaveTitle = new Class_tblAzmoonTitle(int.Parse(Cmb_AzmoonSath.SelectedValue.ToString()), Txt_AzmoonTitle.Text.Trim(), Txt_Reading.Text.Trim());
                SaveTitle.UDF_SaveAzmoonTitle();
                Txt_AzmoonTitle.Text = "";
                Txt_Reading.Text = "";
                Txt_AzmoonTitleID.Text = "";
                
                UDF_GetAzmoonInfo();
                UDF_GetAzmoonLevels();
                Btn_Add.BringToFront();
                Btn_Save.SendToBack();

                MessageBox.Show("رکورد جدید درج گردید.");
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Txt_AzmoonTitle.Text.Trim() == "" || Txt_Reading.Text.Trim() == "")
            {
                MessageBox.Show("ورود مقادیر تمامی فیلدها الزامی می باشد");
                return;
            }
            DialogResult dr = MessageBox.Show("آیا نسبت به عمل ویرایش رکورد اطمینان دارید", "اخطار ویرایش", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                Class_tblAzmoonTitle AzEdit = new Class_tblAzmoonTitle(int.Parse(Cmb_AzmoonSath.SelectedValue.ToString()), int.Parse(Txt_AzmoonTitleID.Text.Trim()), Txt_AzmoonTitle.Text.Trim(), Txt_Reading.Text.Trim());
                AzEdit.UDF_EditAzmooonTitle();
                UDF_GetAzmoonInfo();
                UDF_GetAzmoonLevels();
                
                Txt_AzmoonTitle.Text = "";
                Txt_AzmoonTitleID.Text = "";
                Txt_Reading.Text = "";

                MessageBox.Show("رکورد مورد نظر بروز رسانی گردید");
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Txt_AzmoonTitle.Text.Trim() == "" || Txt_Reading.Text.Trim() == "" || Txt_AzmoonTitleID.Text.Trim() =="")
            {
                MessageBox.Show("انتخاب رکورد برای حذف الزامی می باشد");
                return;
            }
            DialogResult dr = MessageBox.Show("آیا نسبت به عمل حذف رکورد اطمینان دارید", "اخطار حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                Class_tblAzmoonTitle DelTitle = new Class_tblAzmoonTitle(int.Parse(Txt_AzmoonTitleID.Text.Trim()));
                DelTitle.UDF_DeleteTitle();
                UDF_GetAzmoonInfo();
                UDF_GetAzmoonLevels();

                Txt_AzmoonTitle.Text = "";
                Txt_AzmoonTitleID.Text = "";
                Txt_Reading.Text = "";

                MessageBox.Show("رکورد مورد نظر حذف گردید");
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            UDF_GetAzmoonInfo();
            UDF_GetAzmoonLevels();

            Txt_AzmoonTitle.Text = "";
            Txt_AzmoonTitleID.Text = "";
            Txt_Reading.Text = "";
        }
    }
}
