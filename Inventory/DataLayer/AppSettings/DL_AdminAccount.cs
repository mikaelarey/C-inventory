using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using Inventory.Models;
using Inventory.Configuration;

namespace Inventory.DataLayer.AppSettings
{
    class DL_AdminAccount
    {
        public static bool Execute_AdminAccount_Creation()
        {
            try
            {
                using (var connection = new MySqlConnection())
                {
                    connection.ConnectionString = General.Build_ConnectionString();

                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = Create_Default_Admin_User();
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private static string Create_Default_Admin_User()
        {
            string create_admin_user = @"
                INSERT INTO users (firstname, lastname, username, password, active)
                VALUES ('" + User.FirstName + "', '" + User.LastName + "', '" + User.Username + "', '" + User.Password + "', 1);";

            string get_last_inserted_id = @"
                SET @last_inserted_id = LAST_INSERT_ID();
            ";

            string create_admin_user_roles = @"
                INSERT INTO user_access (user_id, user_role_id, allowed)
                VALUES (@last_inserted_id, 1, 1),
                       (@last_inserted_id, 2, 1),
                       (@last_inserted_id, 3, 1),
                       (@last_inserted_id, 4, 1),
                       (@last_inserted_id, 5, 1),
                       (@last_inserted_id, 6, 1);
            ";

            return create_admin_user + get_last_inserted_id + create_admin_user_roles;
        }
    }
}
