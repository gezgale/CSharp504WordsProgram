using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Logat504
{
    class Class_Current_Day_Name
    {
        private String DayName;
        private String MonthName;
        private String CompleteShamsiDate;

        public Class_Current_Day_Name(DateTime _Date_Time)
        {
            DateTime dt = _Date_Time;
            if (dt.DayOfWeek == DayOfWeek.Friday)
                DayName = "جمعه";
            if (dt.DayOfWeek == DayOfWeek.Saturday)
                DayName = "شنبه";
            if (dt.DayOfWeek == DayOfWeek.Sunday)
                DayName = "یکشنبه";
            if (dt.DayOfWeek == DayOfWeek.Monday)
                DayName = "دوشنبه";
            if (dt.DayOfWeek == DayOfWeek.Tuesday)
                DayName = "سه شنبه";
            if (dt.DayOfWeek == DayOfWeek.Wednesday)
                DayName = "چهار شنبه";
            if (dt.DayOfWeek == DayOfWeek.Thursday)
                DayName = "پنج شنبه";
            PersianCalendar pt = new PersianCalendar();
            int MoName = pt.GetMonth(dt);

            switch (MoName)
            {
                case 1:
                    MonthName = "فروردین";
                    break;
                case 2:
                    MonthName = "اردیبهشت";
                    break;
                case 3:
                    MonthName = "خرداد";
                    break;
                case 4:
                    MonthName = "تیر";
                    break;
                case 5:
                    MonthName = "مرداد";
                    break;
                case 6:
                    MonthName = "شهریور";
                    break;
                case 7:
                    MonthName = "مهر";
                    break;
                case 8:
                    MonthName = "آبان";
                    break;
                case 9:
                    MonthName = "آذر";
                    break;
                case 10:
                    MonthName = "دی";
                    break;
                case 11:
                    MonthName = "بهمن";
                    break;
                case 12:
                    MonthName = "اسفند";
                    break;
            }
            CompleteShamsiDate = DayName + " " + pt.GetDayOfMonth(dt) + " " + MonthName + " ماه  - سال" + pt.GetYear(dt);
        }

        public String CRDaysName
        {
            set
            {
                DayName = value;
            }
            get
            {
                return DayName;
            }
        }

        public String CRMotheName
        {
            set
            {
                MonthName = value;
            }
            get
            {
                return MonthName;
            }
        }

        public String CRCompleteShamsiDate
        {
            set
            {
                CompleteShamsiDate = value;
            }
            get
            {
                return CompleteShamsiDate;
            }
        }
    }
}
