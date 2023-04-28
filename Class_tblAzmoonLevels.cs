using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logat504
{
   public class Class_tblAzmoonLevels
    {
       private String Str_DescLevel = String.Empty;
       private int int_LevelID = 0;

       public Class_tblAzmoonLevels(String _DescLevel)
       {
           this.Str_DescLevel = _DescLevel;
       }


       public Class_tblAzmoonLevels(int _LevelID , String _Desc)
       {
           this.int_LevelID = _LevelID;
           this.Str_DescLevel = _Desc;
       }

       public Boolean UDF_ReternDescAzmoon()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           try
           {
               tblAzmoonLevel Azmntb = db.tblAzmoonLevels.Single(n => n.AzmoonLevelDescription.Trim() == Str_DescLevel.Trim());
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
           tblAzmoonLevel Azmntbl = new tblAzmoonLevel();
           Azmntbl.AzmoonLevelDescription = Str_DescLevel;
           db.tblAzmoonLevels.InsertOnSubmit(Azmntbl);
           db.SubmitChanges();
       }

       public void UDF_Delete()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           tblAzmoonLevel azmntb = db.tblAzmoonLevels.Single(n => n.AzmoonLevelDescription.Trim() == Str_DescLevel.Trim());
           db.tblAzmoonLevels.DeleteOnSubmit(azmntb);
           db.SubmitChanges();
       }

       public void UDF_Edit()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           tblAzmoonLevel azmnbt = db.tblAzmoonLevels.Single(n => n.AzmoonLevelID == int_LevelID);
           azmnbt.AzmoonLevelDescription = Str_DescLevel;
           db.SubmitChanges();
       }
    }
}
