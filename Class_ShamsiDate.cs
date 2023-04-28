using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logat504
{
    class Class_ShamsiDate
    {
        private String dtShamsi;
        public Class_ShamsiDate(DateTime MiladiDate)
        {
            PersianCalendar calFar1 = new PersianCalendar();
            dtShamsi = calFar1.GetYear(MiladiDate).ToString() + "/" + calFar1.GetMonth(MiladiDate).ToString("00") + "/" + calFar1.GetDayOfMonth(MiladiDate).ToString("00");
        }

        public String ShamsiDate
        {
            get
            {
                return dtShamsi;
            }
        }
    }
}
