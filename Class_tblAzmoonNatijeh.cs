using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logat504
{
    class Class_tblAzmoonNatijeh
    {
        public Class_tblAzmoonNatijeh()
        {
        }

        public Object UDF_GetTotalMarks()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.xtblViewMarks
                        select new
                        {
                            Row.UserNAme,
                            Row.AzmoonTitle,
                            Row.AzmoonDate,
                            Row.NameOfUsr,
                            Row.SNameOfUsr,
                            Row.SoalateSahih,
                            Row.SoalateEshtebah,
                            Row.BedooneJavab,
                            Row.TotalMark
                        };
            return Query;
        }

        public Object UDF_GetTotalMarksWithUserName(String Str_UserName)
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.xtblViewMarks
                        where Row.UserNAme.Trim() == Str_UserName.Trim()
                        select new
                        {
                            Row.UserNAme,
                            Row.AzmoonTitle,
                            Row.AzmoonDate,
                            Row.NameOfUsr,
                            Row.SNameOfUsr,
                            Row.SoalateSahih,
                            Row.SoalateEshtebah,
                            Row.BedooneJavab,
                            Row.TotalMark
                        };
            return Query;
        }
    }
}
