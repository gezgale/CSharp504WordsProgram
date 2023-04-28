using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.SqlClient;

namespace Logat504
{
    class Class_Search4
    {
         private String Str_Search = String.Empty;
        private String Str_English = String.Empty;
        private String Str_Motaradef = String.Empty;
        private String Str_Saeir = String.Empty;
        private String Str_Date = String.Empty;
        private String Str_UserName = String.Empty;
        private String Str_Farsi = String.Empty;
      

        public Class_Search4(String _Search)
        {
            this.Str_Search = _Search;
        }

        public Object UDF_BakhshiMotradefSaeir()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.tblLoghatHas
                        where SqlMethods.Like(Row.LoghatMotaradef , "%" + Str_Search.Trim() + "%") && SqlMethods.Like(Row.LogatSaier , "%" + Str_Search.Trim() + "%")
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
            return Query;
        }

        public Object UDF_EaineMotaradefSaeir()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.tblLoghatHas
                        where (Row.LoghatMotaradef.Trim() == Str_Search.Trim()) && (Row.LogatSaier.Trim() == Str_Search.Trim())
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
            return Query;
        }

        
    }
    
}
