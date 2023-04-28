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
    public partial class frmSearchLogat : Form
    {
        public frmSearchLogat()
        {
            InitializeComponent();
        }

        private void Rdo_Farsi_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdo_Farsi.Checked == true)
            {
                GrpBox_OnveneFieldHa.Enabled = false;
            }
            else if (Rdo_English.Checked == true)
            {
                GrpBox_OnveneFieldHa.Enabled = true;
            }
        }

        private void Rdo_English_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdo_Farsi.Checked == true)
            {
                GrpBox_OnveneFieldHa.Enabled = false;
            }
            else if (Rdo_English.Checked == true)
            {
                GrpBox_OnveneFieldHa.Enabled = true;
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Txt_Search.Text.Trim() == "")
            {
                MessageBox.Show("ورود رشته جستجو الزامی می باشد");
                return;
            }
            if (Rdo_English.Checked == true)
            {
                if (Chb_EnglishLogat.Checked != true && Chb_MotaradefHa.Checked != true && Chb_SaiereLogat.Checked != true)
                {
                    MessageBox.Show("انتخاب حداقل یک فیلد برای جستجو الزامی می باشد");
                    return;
                }

                /////////////////////////////////////////////////////////
                // جستجوی انگلیسی - هر سه فیلد
                /////////////////////////////////////////////////////////
                if (Chb_EnglishLogat.Checked == true && Chb_MotaradefHa.Checked == true && Chb_SaiereLogat.Checked == true)
                {
                    if (Rdo_Bakhshi.Checked == true) 
                    {
                        LSC_504LogatDataContext db = new LSC_504LogatDataContext();
                        var Query = from Row in db.tblLoghatHas
                                    where SqlMethods.Like(Row.LogatEnglish, "%" + Txt_Search.Text.Trim() + "%") && SqlMethods.Like(Row.LoghatMotaradef, "%" + Txt_Search.Text.Trim() + "%") && SqlMethods.Like(Row.LogatSaier, "%" + Txt_Search.Text.Trim() + "%")
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
                            Btn_Search.SendToBack();
                            MessageBox.Show("رکوردی یافته نشد");
                        }
                    }
                    else if (Rdo_EineEbarat.Checked == true) 
                    {
                        LSC_504LogatDataContext db = new LSC_504LogatDataContext();
                        var Query = from Row in db.tblLoghatHas
                                    where (Row.LogatEnglish.Trim() ==  Txt_Search.Text.Trim()) && (Row.LoghatMotaradef.Trim() ==  Txt_Search.Text.Trim()) && (Row.LogatSaier.Trim() == Txt_Search.Text.Trim())
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
                            Btn_Search.SendToBack();
                            MessageBox.Show("رکوردی یافته نشد");
                        }
                    }
                }
                /////////////////////////////////////////////////////////
                // پایان جستجوی انگلیسی - هر سه فیلد
                /////////////////////////////////////////////////////////

            }
            else if (Rdo_Farsi.Checked == true)
            {
                /////////////////////////////////////////////////////////
                // جستجوی فارسی - بخشی از عبارت
                /////////////////////////////////////////////////////////
                if (Rdo_Bakhshi.Checked == true)
                {
                    LSC_504LogatDataContext db = new LSC_504LogatDataContext();
                    var Query = from Row in db.tblLoghatHas
                                where SqlMethods.Like(Row.LoghatFarsi, "%" + Txt_Search.Text.Trim() + "%") 
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
                        Btn_Search.SendToBack();
                        MessageBox.Show("رکوردی یافته نشد");
                    }
                }
                /////////////////////////////////////////////////////////
                // جستجوی فارسی - عین عبارت
                /////////////////////////////////////////////////////////
                else if(Rdo_EineEbarat.Checked == true)
                {
                    LSC_504LogatDataContext db = new LSC_504LogatDataContext();
                    var Query = from Row in db.tblLoghatHas
                                where Row.LoghatFarsi.Trim() == Txt_Search.Text.Trim()
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
                        Btn_Search.SendToBack();
                        MessageBox.Show("رکوردی یافته نشد");
                    }
                }

            }

            /////جستجوی فیلد لغت انگلیسی 
            //عین عبارت / بخشی از عبارت
            if (Chb_EnglishLogat.Checked == true)
            {
                if (Rdo_Bakhshi.Checked == true)
                {
                    Class_Search1 SHR1 = new Class_Search1(true, true, false, Txt_Search.Text.Trim());
                    Grd_Word.DataSource = SHR1.UDF_SearchBakhsiEnglish();
                }
                else if(Rdo_EineEbarat.Checked == true)
                {
                    Class_Search1 SHRcls = new Class_Search1(true, false, true, Txt_Search.Text.Trim());
                    Grd_Word.DataSource = SHRcls.UDF_SearchEeineEnglish();
                }
            }
                ///// جستجوی فیلد لغت مترادف
                // عین عبارت / بخشی از عبارت
            else if (Chb_MotaradefHa.Checked == true)
            {
                if (Rdo_Bakhshi.Checked == true)
                {
                    Class_Search1 clsSearch = new Class_Search1(true, true, false, Txt_Search.Text.Trim());
                    Grd_Word.DataSource = clsSearch.UDF_SearchBakhshiMotaradef();
                }
                else if (Rdo_EineEbarat.Checked == true)
                {
                    Class_Search1 SeaHRcls = new Class_Search1(true, false, true, Txt_Search.Text.Trim());
                    Grd_Word.DataSource = SeaHRcls.UDF_SearchEeineMotaradef();
                }
            }
                ///// جستجوی فیلد لغت سایر
                // عین عبارت / بخشی از عبارت
            else if (Chb_SaiereLogat.Checked == true)
            {
                if (Rdo_Bakhshi.Checked == true)
                {
                    Class_Search1 ClsShr = new Class_Search1(true, true, false, Txt_Search.Text.Trim());
                    Grd_Word.DataSource = ClsShr.UDF_SearchBakhshiSaeir();
                }
                else if (Rdo_EineEbarat.Checked == true)
                {
                    Class_Search1 shrClssh = new Class_Search1(true, false, true, Txt_Search.Text.Trim());
                   Grd_Word.DataSource = shrClssh.UDF_SearchEeineSaeir();
                }
            }



            /////////////////////////جستجوی ترکیبی فیلد لغت انگلیسی و مترادف
            ///////////////////////////////////////////////////////////////////////////
            if (Chb_EnglishLogat.Checked == true && Chb_MotaradefHa.Checked == true)
            {
                Class_Search2 clsSearch = new Class_Search2(Txt_Search.Text.Trim());

                if (Rdo_Bakhshi.Checked == true)
                {
                    Grd_Word.DataSource = clsSearch.UDF_BakhshiEnglishMotradef();
                }
                else if (Rdo_EineEbarat.Checked == true)
                {
                    Grd_Word.DataSource = clsSearch.UDF_EaineEnglishMotaradef();
                }
            }


            //////////////جستجوی ترکیبی فیلد لغت انگلیسی و فیلد سایر
            if (Chb_EnglishLogat.Checked == true && Chb_SaiereLogat.Checked == true)
            {
                Class_Search3 ClsSearch3 = new Class_Search3(Txt_Search.Text.Trim());

                if (Rdo_Bakhshi.Checked == true)
                {
                    Grd_Word.DataSource = ClsSearch3.UDF_BakhshiEnglishSaeir();
                }
                else if (Rdo_EineEbarat.Checked == true)
                {
                    Grd_Word.DataSource = ClsSearch3.UDF_EaineEnglishSaeir(); 
                }
            }

            ////////////////////جستجوی ترکیبی فیلد مترادف و سایر
            if (Chb_MotaradefHa.Checked == true && Chb_SaiereLogat.Checked == true)
            {
                Class_Search4 ClsSearch44 = new Class_Search4(Txt_Search.Text.Trim());
                if (Rdo_Bakhshi.Checked == true)
                {
                    Grd_Word.DataSource = ClsSearch44.UDF_BakhshiMotradefSaeir();
                }
                else if (Rdo_EineEbarat.Checked == true)
                {
                    Grd_Word.DataSource = ClsSearch44.UDF_EaineMotaradefSaeir(); 
                }
            }

        }
    }
}
