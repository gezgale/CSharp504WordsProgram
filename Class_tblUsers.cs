using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logat504
{
   public class Class_tblUsers
    {
       private String Str_UserName = String.Empty;
       private String Str_Password = String.Empty;
       private String Str_Name = String.Empty;
       private String Str_Family = String.Empty;
       private String Str_Tell = String.Empty;
       private String Str_Email = String.Empty;
       private int int_UserTypeID = 0;

       public Class_tblUsers(String _UserName)
       {
           this.Str_UserName = _UserName;
       }

       public Class_tblUsers(String _UserName, String _Password, String _Name, String _Family, String _Tell, String _Email)
       {
           this.Str_UserName = _UserName;
           this.Str_Password = _Password;
           this.Str_Name = _Name;
           this.Str_Family = _Family;
           this.Str_Tell = _Tell;
           this.Str_Email = _Email;
       }

       public Class_tblUsers(String _UserName, String _Password, String _Name, String _Family, String _Tell, String _Email , int _UserTypeID)
       {
           this.Str_UserName = _UserName;
           this.Str_Password = _Password;
           this.Str_Name = _Name;
           this.Str_Family = _Family;
           this.Str_Tell = _Tell;
           this.Str_Email = _Email;
           this.int_UserTypeID = _UserTypeID;
       }

       public void UDF_EditProfile()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           tblUser TbUsr = db.tblUsers.Single(n => n.UserNAme.Trim() == Str_UserName.Trim());
           TbUsr.UserPWA = Str_Password;
           TbUsr.NameOfUsr = Str_Name;
           TbUsr.SNameOfUsr = Str_Family;
           TbUsr.MobilePhone = Str_Tell;
           TbUsr.EmailOfUser = Str_Email;

           db.SubmitChanges();
       }

       public void UDF_UpDateUser()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           tblUser TbUsr = db.tblUsers.Single(n => n.UserNAme.Trim() == Str_UserName.Trim());
           TbUsr.UserPWA = Str_Password;
           TbUsr.NameOfUsr = Str_Name;
           TbUsr.SNameOfUsr = Str_Family;
           TbUsr.MobilePhone = Str_Tell;
           TbUsr.EmailOfUser = Str_Email;
           TbUsr.UserTypeID = int_UserTypeID;

           db.SubmitChanges();
       }

       public void UDF_ReternInfo()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           var Query = from Row in db.tblUsers
                       where Row.UserNAme == Str_UserName
                       select new
                       {
                           Row.UserNAme ,
                           Row.UserPWA ,
                           Row.NameOfUsr ,
                           Row.SNameOfUsr ,
                           Row.MobilePhone ,
                           Row.EmailOfUser 
                       };
           foreach (var Row in Query)
           {
               Str_UserName = Row.UserNAme;
               Str_Password = Row.UserPWA;
               Str_Name = Row.NameOfUsr;
               Str_Family = Row.SNameOfUsr;
               Str_Tell = Row.MobilePhone;
               Str_Email = Row.EmailOfUser;
           }
       }

       public void UDF_Save()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           tblUser tbusertb = new tblUser();
           tbusertb.UserNAme = Str_UserName;
           tbusertb.UserPWA = Str_Password;
           tbusertb.NameOfUsr = Str_Name;
           tbusertb.SNameOfUsr = Str_Family;
           tbusertb.MobilePhone = Str_Tell;
           tbusertb.EmailOfUser = Str_Email;
           tbusertb.UserTypeID = int_UserTypeID;

           db.tblUsers.InsertOnSubmit(tbusertb);
           db.SubmitChanges();
       }

       public void UDF_Delete()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           tblUser TbUsr = db.tblUsers.Single(n => n.UserNAme.Trim() == Str_UserName.Trim());
           db.tblUsers.DeleteOnSubmit(TbUsr);
           db.SubmitChanges();
       }

       public Boolean UDF_CheckUserName()
       {
           LSC_504LogatDataContext db = new LSC_504LogatDataContext();
           try
           {
               tblUser Usertb = db.tblUsers.Single(n => n.UserNAme.Trim() == Str_UserName.Trim());
               return true;
           }
           catch
           {
               return false;
           }

       }

       public String Str_UserName2
       {
           get
           {
               return Str_UserName;
           }
       }

       public String Str_Password2
       {
           get
           {
               return Str_Password;
           }
       }
       public String Str_Name2
       {
           get
           {
               return Str_Name;
           }
       }
       public String Str_Family2
       {
           get
           {
               return Str_Family;
           }
       }
       public String Str_Tell2
       {
           get
           {
               return Str_Tell;
           }
       }
       public String Str_Email2
       {
           get
           {
               return Str_Email;
           }
       }

    }
}
