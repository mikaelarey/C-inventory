using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using Inventory.Models;

namespace Inventory.DataLayer.AppSettings
{
    class DL_ConnectionString
    {
        private static string Get_Server_ConnectionString()
        {
            return String.Format("server={0};user={1};password={2}",
                ConnectionString.Server, ConnectionString.Username, ConnectionString.Password);
        }

        public static bool Is_Connection_Successful()
        {
            using (MySqlConnection connection = new MySqlConnection(Get_Server_ConnectionString()))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
