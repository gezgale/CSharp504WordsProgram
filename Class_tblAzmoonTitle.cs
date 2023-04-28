using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logat504
{
    /// <summary>
    /// از این کلاس برای انجام عملیات بر روی جدول عنوان آزمونها استفاده می شود
    /// </summary>
    class Class_tblAzmoonTitle
    {
        private int int_AzmoonLevelID = 0;
        private int int_AzmoonTitlelID = 0;
        private String Str_AzmoonTitle = String.Empty;
        private String Str_ReadingTxt = String.Empty;

        /// <summary>
        /// از این متد برای دریافت پارامترهای مربوط به جدول عنوان آزمون استفاده می شود
        /// </summary>
        /// <param name="_AzmoonLevelID"></param>
        /// <param name="_AzmoonTitle"></param>
        /// <param name="_ReadinTxt"></param>
        public Class_tblAzmoonTitle(int _AzmoonLevelID , String _AzmoonTitle , String _ReadinTxt)
        {
            int_AzmoonLevelID = _AzmoonLevelID;
            Str_AzmoonTitle = _AzmoonTitle;
            Str_ReadingTxt = _ReadinTxt;
        }

        public Class_tblAzmoonTitle(int _AzmoonLevelID,int _AzmoonTitlelID, String _AzmoonTitle, String _ReadinTxt)
        {
            int_AzmoonLevelID = _AzmoonLevelID;
            int_AzmoonTitlelID = _AzmoonTitlelID;
            Str_AzmoonTitle = _AzmoonTitle;
            Str_ReadingTxt = _ReadinTxt;
        }

        public Class_tblAzmoonTitle(int _AzmoonTitlelID)
        {
            int_AzmoonTitlelID = _AzmoonTitlelID;
        }

        /// <summary>
        /// از این متد برای ایجاد آزمون استفاده می شود
        /// </summary>
        public void UDF_SaveAzmoonTitle()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            tblAzmoonTitle AzTitle = new tblAzmoonTitle();
            AzTitle.AzmoonLevelID = int_AzmoonLevelID;
            AzTitle.AzmoonTitle = Str_AzmoonTitle;
            AzTitle.AzmoonReading = Str_ReadingTxt;

            db.tblAzmoonTitles.InsertOnSubmit(AzTitle);
            db.SubmitChanges();
       }

        public void UDF_EditAzmooonTitle()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            tblAzmoonTitle AzTitleEdt = db.tblAzmoonTitles.Single(n => n.AzmoonID == int_AzmoonTitlelID);
            AzTitleEdt.AzmoonLevelID = int_AzmoonLevelID;
            AzTitleEdt.AzmoonTitle = Str_AzmoonTitle;
            AzTitleEdt.AzmoonReading = Str_ReadingTxt;
            db.SubmitChanges();
        }

        public void UDF_DeleteTitle()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            tblAzmoonTitle AzTitleDlt = db.tblAzmoonTitles.Single(n => n.AzmoonID == int_AzmoonTitlelID);
            db.tblAzmoonTitles.DeleteOnSubmit(AzTitleDlt);
            db.SubmitChanges();
        }
    }
}
