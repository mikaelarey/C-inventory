using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using Inventory.Models;
using Inventory.Configuration;

namespace Inventory.DataLayer
{
    class DL_Login
    {
        public static bool Is_Login_Successful(string Username, string Password)
        {
            using ( MySqlConnection connect = new MySqlConnection(General.Build_ConnectionString()))
            using (MySqlCommand cmd = new MySqlCommand())
            {
                string commandLine = "SELECT * FROM `users` WHERE username=@username AND password=@password LIMIT 1;";
                cmd.CommandText = commandLine;

                cmd.Parameters.AddWithValue("@username", Username);
                cmd.Parameters.AddWithValue("@password", Password);

                cmd.Connection = connect;
                cmd.Connection.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();

                        AuthenticatedUser.Id = reader["user_id"].ToString();
                        AuthenticatedUser.FirstName = reader["firstname"].ToString();
                        AuthenticatedUser.LastName = reader["lastname"].ToString();
                        AuthenticatedUser.Username = reader["username"].ToString();
                        AuthenticatedUser.Password = reader["password"].ToString();

                        Get_User_Roles(Convert.ToInt32(AuthenticatedUser.Id));

                        return true;
                    }
                }
            }

            return false;
        }

        public static void Get_User_Roles(int user_id)
        {
            for (int i = 1; i < 7; i++)
            {
                using (MySqlConnection connect = new MySqlConnection(General.Build_ConnectionString()))
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string commandLine = "SELECT * FROM `user_access` WHERE user_id=@user_id AND user_role_id=@user_role_id LIMIT 1;";
                    cmd.CommandText = commandLine;

                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    cmd.Parameters.AddWithValue("@user_role_id", i);

                    cmd.Connection = connect;
                    cmd.Connection.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            if (i == 1)
                                AuthenticatedUser.InventoryAccess = Convert.ToInt32(reader["allowed"].ToString());

                            else if (i == 2)
                                AuthenticatedUser.InventoryModify = Convert.ToInt32(reader["allowed"].ToString());

                            else if (i == 3)
                                AuthenticatedUser.SalesAccess = Convert.ToInt32(reader["allowed"].ToString());

                            else if (i == 4)
                                AuthenticatedUser.SalesModify = Convert.ToInt32(reader["allowed"].ToString());

                            else if (i == 5)
                                AuthenticatedUser.DeliveryAccess = Convert.ToInt32(reader["allowed"].ToString());

                            else
                                AuthenticatedUser.DeliveryModify = Convert.ToInt32(reader["allowed"].ToString());
                            
                        }
                    }
                }
            }

                
        }
    }
}
