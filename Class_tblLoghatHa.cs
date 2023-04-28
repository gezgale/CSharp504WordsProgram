using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logat504
{
   public  class Class_tblLoghatHa
    {
       private String Str_WordEnglish = String.Empty;
       private String Str_WordFarsi = String.Empty;
       private String Str_Motaradef = String.Empty;
       private String Str_Saier = String.Empty;
       private String Str_UserName = String.Empty;

       public Class_tblLoghatHa(String _WordEnglish, String _WordFarsi, String _Motaradef, String _Saier, String _UserName)
       {
           this.Str_WordEnglish = _WordEnglish;
           this.Str_WordFarsi = _WordFarsi;
           this.Str_Motaradef = _Motaradef;
           this.Str_Saier = _Saier;
           this.Str_UserName = _UserName;
       }

       public Class_tblLoghatHa(String _WordEnglish, String _WordFarsi, String _Motaradef, String _Saier)
       {
           this.Str_WordEnglish = _WordEnglish;
           this.Str_WordFarsi = _WordFarsi;
           this.Str_Motaradef = _Motaradef;
           this.Str_Saier = _Saier;
       }

       public Class_tblLoghatHa(String _WordEnglish)
       {
           this.Str_WordEnglish = _WordEnglish;
       }

       public Boolean UDF_CheckWord()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           try
           {
               tblLoghatHa loghat = db.tblLoghatHas.Single(n => n.LogatEnglish.Trim() == Str_WordEnglish.Trim());
               return true;
           }
           catch
           {
               return false;
           }
       }

       public void UDF_Save()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           tblLoghatHa tbloghat = new tblLoghatHa();
           Class_ShamsiDate shamsi = new Class_ShamsiDate(DateTime.Now);
           
           tbloghat.LogatEnglish = Str_WordEnglish;
           tbloghat.LoghatFarsi = Str_WordFarsi;
           tbloghat.LoghatMotaradef = Str_Motaradef;
           tbloghat.LogatSaier = Str_Saier;
           tbloghat.AdderUserName = Str_UserName;
           tbloghat.DateOfAdd = shamsi.ShamsiDate;

           db.tblLoghatHas.InsertOnSubmit(tbloghat);
           db.SubmitChanges();
       }

       public void UDF_Delete()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           tblLoghatHa loghat = db.tblLoghatHas.Single(n => n.LogatEnglish.Trim() == Str_WordEnglish.Trim());
           db.tblLoghatHas.DeleteOnSubmit(loghat);
           db.SubmitChanges();
       }

       public void UDF_Edit()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           tblLoghatHa loghat = db.tblLoghatHas.Single(n => n.LogatEnglish.Trim() == Str_WordEnglish.Trim());
           loghat.LoghatFarsi = Str_WordFarsi;
           loghat.LoghatMotaradef = Str_Motaradef;
           loghat.LogatSaier = Str_Saier;
           db.SubmitChanges();
       }

    }
}
