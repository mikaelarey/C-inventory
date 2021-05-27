using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventory.DataLayer;

namespace Inventory.BusinessLayer
{
    class BL_Profile
    {
        public static bool Is_Username_Exists(string Username)
        {
            return DL_Profile.Is_Username_Exists(Username);
        }

        public static bool Update_Profile(string query)
        {
            return DL_Profile.Update_Profile(query);
        }
    }
}
