using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using Inventory.Models;
using Inventory.Configuration;

namespace Inventory.DataLayer
{
    class DL_Suppplier
    {
        public static bool AddOrUpdate_Supplier(Supplier supplier)
        {
            string SQLCommand = (supplier.Id != 0)
                ? @"UPDATE `supplier` SET `code`='" + supplier.Code + "',`name`='" + supplier.Name + "',`contact`='" + supplier.Contact + "',`address`='" + supplier.Address + "',`remarks`='" + supplier.Remarks + "' WHERE supplier_id=" + supplier.Id + ";"
                : @"INSERT INTO `supplier`(`code`, `name`, `contact`, `address`, `remarks`) 
                    VALUES ('" + supplier.Code + "','" + supplier.Name + "','" + supplier.Contact + "','" + supplier.Address + "','" + supplier.Remarks + "')";

            try
            {
                using (var connection = new MySqlConnection())
                {
                    connection.ConnectionString = General.Build_ConnectionString();

                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = SQLCommand;
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static DataTable Get_All_Supplier()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var connection = new MySqlConnection())
                {
                    connection.ConnectionString = General.Build_ConnectionString();
                    connection.Open();
                    var adapter = new MySqlDataAdapter("SELECT * FROM supplier;", connection);
                    adapter.Fill(dt);
                }
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DataTable Get_Supplier_By_Search(string Search_Value)
        {
            string SQLCommand = @"SELECT * FROM supplier WHERE name LIKE '%" + Search_Value + "%'";

            DataTable dt = new DataTable();
            try
            {
                using (var connection = new MySqlConnection())
                {
                    connection.ConnectionString = General.Build_ConnectionString();
                    connection.Open();
                    var adapter = new MySqlDataAdapter(SQLCommand, connection);
                    adapter.Fill(dt);
                }
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
