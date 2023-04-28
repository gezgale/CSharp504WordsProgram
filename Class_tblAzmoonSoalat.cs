using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logat504
{
   public class Class_tblAzmoonSoalat
    {
       private int int_SoalID = 0;
       private Decimal Dec_AzmoonTitleID = 0;
       private String Str_AzmoonTitle = String.Empty;
       private String Str_SoalDesc = String.Empty;
       private String Str_Gozine1 = String.Empty;
       private String Str_Gozine2 = String.Empty;
       private String Str_Gozine3 = String.Empty;
       private String Str_Gozine4 = String.Empty;
       private int int_GozineSahih = 0;

       public Class_tblAzmoonSoalat(Decimal _AzmoonTitleID, String _SoalDesc, String _Gozine1, String _Gozine2, String _Gozine3, String _Gozine4, int _GozineSahih)
       {
           this.Dec_AzmoonTitleID = _AzmoonTitleID;
           this.Str_SoalDesc = _SoalDesc;
           this.Str_Gozine1 = _Gozine1;
           this.Str_Gozine2 = _Gozine2;
           this.Str_Gozine3 = _Gozine3;
           this.Str_Gozine4 = _Gozine4;
           this.int_GozineSahih = _GozineSahih;
       }

       public Class_tblAzmoonSoalat(int _SoalID, Decimal _AzmoonTitleID, String _SoalDesc, String _Gozine1, String _Gozine2, String _Gozine3, String _Gozine4, int _GozineSahih)
       {
           this.int_SoalID = _SoalID;
           this.Dec_AzmoonTitleID = _AzmoonTitleID;
           this.Str_SoalDesc = _SoalDesc;
           this.Str_Gozine1 = _Gozine1;
           this.Str_Gozine2 = _Gozine2;
           this.Str_Gozine3 = _Gozine3;
           this.Str_Gozine4 = _Gozine4;
           this.int_GozineSahih = _GozineSahih;
       }

       public Class_tblAzmoonSoalat(int _SoalID)
       {
           this.int_SoalID = _SoalID;
       }

       public Boolean UDF_CheckSoalDesc()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           try
           {
               tblAzmoonSoalat AzmnSoal = db.tblAzmoonSoalats.Single(n => n.SoAlDescription.Trim() == Str_SoalDesc.Trim());
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
           tblAzmoonSoalat AzmnSltb = new tblAzmoonSoalat();
           AzmnSltb.AzmoonTitleID = Dec_AzmoonTitleID;
           AzmnSltb.SoAlDescription = Str_SoalDesc;
           AzmnSltb.Gozineie1 = Str_Gozine1;
           AzmnSltb.Gozineie2 = Str_Gozine2;
           AzmnSltb.Gozineie3 = Str_Gozine3;
           AzmnSltb.Gozineie4 = Str_Gozine4;
           AzmnSltb.GozineieSahih = int_GozineSahih;

           db.tblAzmoonSoalats.InsertOnSubmit(AzmnSltb);
           db.SubmitChanges();
       }

       public void UDF_Delete()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           tblAzmoonSoalat AzmnSoal = db.tblAzmoonSoalats.Single(n => n.SoalID == int_SoalID);
           db.tblAzmoonSoalats.DeleteOnSubmit(AzmnSoal);
           db.SubmitChanges();
       }

       public void UDF_Edit()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           tblAzmoonSoalat AzmnSoal = db.tblAzmoonSoalats.Single(n => n.SoalID == int_SoalID);
           AzmnSoal.SoAlDescription = Str_SoalDesc;
           AzmnSoal.Gozineie1 = Str_Gozine1;
           AzmnSoal.Gozineie2 = Str_Gozine2;
           AzmnSoal.Gozineie3 = Str_Gozine3;
           AzmnSoal.Gozineie4 = Str_Gozine4;
           AzmnSoal.GozineieSahih = int_GozineSahih;
           AzmnSoal.AzmoonTitleID = Dec_AzmoonTitleID;

           db.SubmitChanges();
       }
    }
}
