using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.SqlClient;

namespace Logat504
{
   public class Class_Search2
    {
        private String Str_Search = String.Empty;
        private String Str_English = String.Empty;
        private String Str_Motaradef = String.Empty;
        private String Str_Saeir = String.Empty;
        private String Str_Date = String.Empty;
        private String Str_UserName = String.Empty;
        private String Str_Farsi = String.Empty;
        private Boolean Bln_EnglishLoghat = false;
        private Boolean Bln_Bakhshi = false;
        private Boolean Bln_EineEbarat = false;
        private Boolean Bln_motaradef = false;

        public Class_Search2(Boolean _EnglishLoghat, Boolean _Motaradef , Boolean _Bakhshi, Boolean _EineEbarat, String _Search)
        {
            this.Bln_EnglishLoghat = _EnglishLoghat;
            this.Bln_motaradef = _Motaradef;
            this.Bln_Bakhshi = _Bakhshi;
            this.Bln_EineEbarat = _EineEbarat;
            this.Str_Search = _Search;
        }

        public Class_Search2(String _Search)
        {
            this.Str_Search = _Search;
        }

        public Object UDF_BakhshiEnglishMotradef()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.tblLoghatHas
                        where SqlMethods.Like(Row.LogatEnglish, "%" + Str_Search.Trim() + "%") && SqlMethods.Like(Row.LoghatMotaradef, "%" + Str_Search.Trim() + "%")
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

        public Object UDF_EaineEnglishMotaradef()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.tblLoghatHas
                        where (Row.LogatEnglish.Trim() == Str_Search.Trim()) && (Row.LoghatMotaradef.Trim() == Str_Search.Trim())
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
