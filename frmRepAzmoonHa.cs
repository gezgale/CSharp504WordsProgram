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
    public partial class frmRepAzmoonHa : Form
    {
        public frmRepAzmoonHa()
        {
            InitializeComponent();
        }
        private void UDF_cmbFill()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.xtblDropUsers
                        select new
                        {
                            Row.UserNAme,
                            Row.NameSname 
                        };
            Cmb_UserInfo.DataSource = Query;
            Cmb_UserInfo.DisplayMember = "NameSname";
            Cmb_UserInfo.ValueMember = "UserNAme";
        }

        private void frmRepAzmoonHa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Logat504DataSet.xtblKarname' table. You can move, or remove it, as needed.
            UDF_cmbFill();
            this.reportViewer1.RefreshReport();
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.xtblKarnames
                        where Row.UserNAme == Cmb_UserInfo.SelectedValue.ToString()
                        select new
                        {
                            Row.Expr1,
                            Row.AzmoonTitle ,
                            Row.AzmoonDate,
                            Row.TotalMark
                        };

            xtblKarnameBindingSource.DataSource = Query;
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.ZoomPercent = 25;
        }

        private void Btn_ShowReport_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.xtblKarnames
                        where Row.UserNAme == Cmb_UserInfo.SelectedValue.ToString()
                        select new
                        {
                            Row.Expr1,
                            Row.AzmoonTitle,
                            Row.AzmoonDate,
                            Row.TotalMark
                        };

            xtblKarnameBindingSource.DataSource = Query;
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.ZoomPercent = 25;
        }
    }
}
