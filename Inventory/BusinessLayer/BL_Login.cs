using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventory.DataLayer;

namespace Inventory.BusinessLayer
{
    class BL_Login
    {
        public static bool Is_Login_Successful(string Username, string Password)
        { 
            return DL_Login.Is_Login_Successful(Username, Password);
        }
    }
}
