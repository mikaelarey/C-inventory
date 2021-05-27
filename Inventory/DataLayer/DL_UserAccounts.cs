using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using Inventory.Configuration;

namespace Inventory.DataLayer
{
    class DL_UserAccounts
    {
        public static DataTable Get_All_Users()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var connection = new MySqlConnection())
                {
                    connection.ConnectionString = General.Build_ConnectionString();
                    connection.Open();
                    var adapter = new MySqlDataAdapter("SELECT * FROM users;", connection);
                    adapter.Fill(dt);
                }
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool Add_User(string Query)
        {
            try
            {
                using (var connection = new MySqlConnection())
                {
                    connection.ConnectionString = General.Build_ConnectionString();

                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = Query;
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
