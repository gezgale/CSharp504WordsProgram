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
    public partial class frmActAzmoon : Form
    {
        int int_Timer = 0;

        public frmActAzmoon()
        {
            InitializeComponent();
        }

        private void frmActAzmoon_Load(object sender, EventArgs e)
        {
            UDF_GetAzmoonLevals();
        }

        private void Btn_ConfirmSelect_Click(object sender, EventArgs e)
        {
            UDF_GetAzmoonTitles();
            GrpBox_SatheAzmoon.Enabled = false;
            GrpBox_SelectAzmoon.Enabled = true;
        }

        private void UDF_GetAzmoonTitles()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.xtblAzmoonTitles
                        where Row.AzmoonLevelID == int.Parse(Drp_LevelAzmoon.SelectedValue.ToString().Trim())
                        select new
                        {
                            Row.AzmoonID,
                            Row.AzmoonLevelID,
                            Row.Expr1
                        };
            Drp_AzmoonTitle.ValueMember = "AzmoonID";
            Drp_AzmoonTitle.DisplayMember = "Expr1";
            Drp_AzmoonTitle.DataSource = Query;
        }

        private void UDF_GetAzmoonLevals()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.tblAzmoonLevels
                        select new
                        {
                            Row.AzmoonLevelID,
                            Row.AzmoonLevelDescription
                        };
            Drp_LevelAzmoon.ValueMember = "AzmoonLevelID";
            Drp_LevelAzmoon.DisplayMember = "AzmoonLevelDescription";
            Drp_LevelAzmoon.DataSource = Query;
        }

        private void Btn_CancelSelect_Click(object sender, EventArgs e)
        {
            GrpBox_SatheAzmoon.Enabled = true;
            GrpBox_SelectAzmoon.Enabled = false;
        }

        private void Btn_COnfirmTitle_Click(object sender, EventArgs e)
        {
            Time_Azmoon.Enabled = true;
            Time_Azmoon.Start();
            GrpBox_SelectAzmoon.Enabled = false;
            Grd_TestAct.Enabled = true;
            GrpBox_Natijeh.Enabled = true;
            UDF_GqtQuestionsList();
            frmViewReading frm = new frmViewReading();
            frm.PassData(this, int.Parse(Drp_AzmoonTitle.SelectedValue.ToString()));
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void UDF_GqtQuestionsList()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.tblAzmoonSoalats
                        where Row.AzmoonTitleID == Decimal.Parse(Drp_AzmoonTitle.SelectedValue.ToString())
                        select new
                        {
                            Row.SoalID,
                            Row.SoAlDescription,
                            Row.Gozineie1,
                            Row.Gozineie2,
                            Row.Gozineie3,
                            Row.Gozineie4
                        };
            Grd_TestAct.Enabled = true;
            Grd_TestAct.DataSource = Query;
        }

        private void Btn_Natijeh_Click(object sender, EventArgs e)
        {
            Time_Azmoon.Stop();
            Time_Azmoon.Enabled = false;
            if (int_Timer < 60)
            {
                Lbl_Time.Text = "زمان آزمون: " + int_Timer.ToString() + " ثانیه";
            }
            else
            {
                int int_Dagigeh = int_Timer / 60;
                int int_Sanieh = int_Timer % 60;
                Lbl_Time.Text = "زمان آزمون: " + int_Dagigeh.ToString() + " دقیقه و " + int_Sanieh.ToString() + " ثانیه";
            }
            UDF_CalcMarks();
            Grd_TestAct.Enabled = false;
            Btn_Natijeh.Enabled = false;
        }

        private void UDF_SaveMarke(int int_Sahih , int int_Gahat , int int_BiPasokh , float flt_TotalMark)
        {
            Class_ShamsiDate ShDate = new Class_ShamsiDate(DateTime.Now);
            try
            {
                LSC_504LogatDataContext db = new LSC_504LogatDataContext();
                tblAzmoonNatijeh SaveAzmoonDb = new tblAzmoonNatijeh();
                SaveAzmoonDb.AzmoonTitleID = Decimal.Parse(Drp_AzmoonTitle.SelectedValue.ToString());
                SaveAzmoonDb.UserNAme = GlobalClass.ThisLogedUserName;
                SaveAzmoonDb.AzmoonDate = ShDate.ShamsiDate.Trim();
                SaveAzmoonDb.SoalateSahih = int_Sahih;
                SaveAzmoonDb.SoalateEshtebah = int_Gahat;
                SaveAzmoonDb.BedooneJavab = int_BiPasokh;
                SaveAzmoonDb.TotalMark = flt_TotalMark;
                db.tblAzmoonNatijehs.InsertOnSubmit(SaveAzmoonDb);
                db.SubmitChanges();
                MessageBox.Show("نمره آزمون ثبت گردید");
            }
            catch
            {
                LSC_504LogatDataContext db1 = new LSC_504LogatDataContext();
                tblAzmoonNatijeh SaveAzmoonDb1 = db1.tblAzmoonNatijehs.Single(n => n.UserNAme.Trim() == GlobalClass.ThisLogedUserName.Trim() && n.AzmoonTitleID == Decimal.Parse(Drp_AzmoonTitle.SelectedValue.ToString()));
                SaveAzmoonDb1.AzmoonDate = ShDate.ShamsiDate.Trim();
                SaveAzmoonDb1.SoalateSahih = int_Sahih;
                SaveAzmoonDb1.SoalateEshtebah = int_Gahat;
                SaveAzmoonDb1.BedooneJavab = int_BiPasokh;
                SaveAzmoonDb1.TotalMark = flt_TotalMark;
                db1.SubmitChanges();
                MessageBox.Show("شما قبلا در این آزمون شرکت نموده اید. نمره جدید ثبت گردید");
            }

        }

        private void UDF_CalcMarks()
        {
            int int_SoaleSahih = 0;
            int int_SoaleGhalat = 0;
            int int_SoaleBiPasokh = 0;

            for (int i = 0; i < Grd_TestAct.Rows.Count; i++)
            {
                String Str_Gozineh = String.Empty;
                try
                {
                    Str_Gozineh = Grd_TestAct.Rows[i].Cells[0].Value.ToString();
                    if (Str_Gozineh.Trim() == "")
                    {
                        int_SoaleBiPasokh++;
                    }
                    else
                    {
                        try
                        {
                            if (Decimal.Parse(Grd_TestAct.Rows[i].Cells[0].Value.ToString()) == UDF_GetMark(Decimal.Parse(Grd_TestAct.Rows[i].Cells[1].Value.ToString())))
                            {
                                int_SoaleSahih++;
                            }
                            else
                            {
                                int_SoaleGhalat++;
                            }
                        }
                        catch
                        {
                            int_SoaleGhalat++;
                        }
                    }
                }
                catch
                {
                    int_SoaleBiPasokh++;
                }
            }

            Labl_SoalSahih.Text = "صحیح" + int_SoaleSahih.ToString();
            Lbl_SoalEshtebah.Text = "اشتباه: " + int_SoaleGhalat.ToString();
            Lbl_SoalBedooneavab.Text = "بدون پاسخ: " + int_SoaleBiPasokh.ToString();

            Decimal Dec_Mark = 0;
            Dec_Mark = (((int_SoaleSahih) * 20) / (int_SoaleBiPasokh + int_SoaleGhalat + int_SoaleSahih));
            Lbl_Nomreh.Text = "نمره آزمون: " + Dec_Mark.ToString();
            UDF_SaveMarke(int_SoaleSahih, int_SoaleGhalat, int_SoaleBiPasokh , float.Parse(Dec_Mark.ToString()));
        }

        private int UDF_GetMark(Decimal Dec_SoalCode)
        {
            int int_Mark = 0;
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            tblAzmoonSoalat SoalMark = db.tblAzmoonSoalats.Single(n => n.SoalID == Dec_SoalCode);
            int_Mark = SoalMark.GozineieSahih;
            return int_Mark;
        }

        private void Time_Azmoon_Tick(object sender, EventArgs e)
        {
            int_Timer++;
            if (int_Timer < 60)
            {
                Lbl_Time.Text = "زمان آزمون: " + int_Timer.ToString() + " ثانیه";
            }
            else
            {
                int int_Dagigeh = int_Timer / 60;
                int int_Sanieh = int_Timer % 60;
                Lbl_Time.Text = "زمان آزمون: " + int_Dagigeh.ToString() + " دقیقه و " + int_Sanieh.ToString() + " ثانیه";
            }
        }

        private void Btn_ShowReading_Click(object sender, EventArgs e)
        {
            frmViewReading frm = new frmViewReading();
            frm.PassData(this, int.Parse(Drp_AzmoonTitle.SelectedValue.ToString()));
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
