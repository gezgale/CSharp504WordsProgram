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
    public partial class frmViewReading : Form
    {
        public frmViewReading()
        {
            InitializeComponent();
        }

        public void PassData(object sender, int number)
        {
            //Sms_Menu.Enabled = (Boolean)sender;
            //MessageBox.Show(number.ToString());
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            tblAzmoonTitle AzTitle = db.tblAzmoonTitles.Single(n => n.AzmoonID == Decimal.Parse(number.ToString()));
            Txt_Reading.Text = AzTitle.AzmoonReading;
        }

        private void frmViewReading_Load(object sender, EventArgs e)
        {

        }
    }
}
