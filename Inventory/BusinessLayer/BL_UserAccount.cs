using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Inventory.DataLayer;

namespace Inventory.BusinessLayer
{
    class BL_UserAccount
    {
        public static DataTable Get_All_Users()
        {
            return DL_UserAccounts.Get_All_Users();
        }

        public static bool Add_User(string Query)
        {
            return DL_UserAccounts.Add_User(Query);
        }
    }
}
