using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.SqlClient;

namespace Logat504
{
   public class Class_Search1
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
      // private Decimal Dec_LoghatID = 0;
      

     public Class_Search1(Boolean _EnglishLoghat, Boolean _Bakhshi, Boolean _EineEbarat, String _English)
       {
           this.Bln_EnglishLoghat = _EnglishLoghat;
           this.Bln_Bakhshi = _Bakhshi;
           this.Bln_EineEbarat = _EineEbarat;
           this.Str_English = _English;
       }


       public Object UDF_SearchBakhsiEnglish()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           var Query = from Row in db.tblLoghatHas
                       where SqlMethods.Like(Row.LogatEnglish, "%" + Str_English.Trim() + "%")
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

       public Object UDF_SearchEeineEnglish()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           var Query = from Row in db.tblLoghatHas
                       where Row.LogatEnglish == Str_English
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

       public Object UDF_SearchBakhshiMotaradef()
       {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           var Query = from Row in db.tblLoghatHas
                       where SqlMethods.Like(Row.LoghatMotaradef , "%" + Str_English.Trim() + "%")
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

       public Object UDF_SearchEeineMotaradef()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           var Query = from Row in db.tblLoghatHas
                       where Row.LoghatMotaradef  == Str_English
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

       public Object UDF_SearchBakhshiSaeir()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           var Query = from Row in db.tblLoghatHas
                       where SqlMethods.Like(Row.LogatSaier , "%" + Str_English.Trim() + "%")
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

       public Object UDF_SearchEeineSaeir()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           var Query = from Row in db.tblLoghatHas
                       where Row.LogatSaier == Str_English 
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
