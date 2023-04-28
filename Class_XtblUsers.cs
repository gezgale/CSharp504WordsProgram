using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logat504
{
    class Class_XtblUsers
    {
        public Class_XtblUsers()
        {
        }
        public Object UDF_GetUsers()
        {
            LSC_504LogatDataContext db = new LSC_504LogatDataContext();
            var Query = from Row in db.xtblDropUsers
                        select new
                        {
                            Row.UsersID,
                            Row.NameSname,
                            Row.UserNAme
                        };
            return Query;
        }
    }
}
