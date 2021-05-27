using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using Inventory.Configuration;

namespace Inventory.DataLayer
{
    class DL_Profile
    {
        public static bool Is_Username_Exists(string Username)
        {
            using (MySqlConnection connect = new MySqlConnection(General.Build_ConnectionString()))
            using (MySqlCommand cmd = new MySqlCommand())
            {
                string commandLine = "SELECT * FROM `users` WHERE username=@username;";
                cmd.CommandText = commandLine;

                cmd.Parameters.AddWithValue("@username", Username);

                cmd.Connection = connect;
                cmd.Connection.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool Update_Profile(string query)
        {
            try
            {
                using (var connection = new MySqlConnection())
                {
                    connection.ConnectionString = General.Build_ConnectionString();

                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = query;
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
