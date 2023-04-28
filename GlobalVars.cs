using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logat504
{
    static class GlobalClass //set= GlobalClass.GlobalVar = "aliki"; Get= MessageBox.Show(GlobalClass.GlobalVar);
    {
        private static string LogedUserName = "";
        private static int LogedUserID = 0;

        public static string ThisLogedUserName
        {
            get
            {
                return LogedUserName;
            }
            set
            {
                LogedUserName = value;
            }
        }

        public static int ThisLogedUserID
        {
            get
            {
                return LogedUserID;
            }
            set
            {
                LogedUserID = value;
            }
        }
    }
}
