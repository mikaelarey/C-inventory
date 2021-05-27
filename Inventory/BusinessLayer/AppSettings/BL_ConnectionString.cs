using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventory.Models;
using Inventory.Configuration;
using Inventory.DataLayer.AppSettings;

namespace Inventory.BusinessLayer.AppSettings
{
    class BL_ConnectionString
    {
        public static bool Is_Connection_Successful()
        {
            return DL_ConnectionString.Is_Connection_Successful();
        }

        private static void Set_ConnectionString(string Server, string Username, string Password)
        {
            ConnectionString.Server = Server;
            ConnectionString.Username = Username;
            ConnectionString.Password = Password;
        }

        public static bool Is_ConnectionString_Created(string Server, string Username, string Password)
        {
            Set_ConnectionString(Server, Username, Password);
            return DL_ConnectionString.Is_Connection_Successful() ?
                Save_ConnectionString_To_ConfigurationFile(Server, Username, Password) : false;
        }

        public static bool Save_ConnectionString_To_ConfigurationFile(string Server, string Username, string Password)
        {
            BL_AppSettings.Save_ConnectionString_To_ConfigurationFile(Server, Username, Password);
            return true;
        }
    }
}
