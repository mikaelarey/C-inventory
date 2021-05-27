using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using Inventory.Configuration;

namespace Inventory.DataLayer
{
    class DL_Cart
    {
        public static bool Save_Cart(DataTable CartData, int CustomerID)
        {
            int InsertedId = 0;
            string ItemValues = "";

            try
            {
                //using (var connection = new MySqlConnection())
                //{
                //    connection.ConnectionString = General.Build_ConnectionString();

                //    connection.Open();
                //    var command = connection.CreateCommand();
                //    command.CommandText = "INSERT INTO orders(`order_status_id`, `customer_id`) VALUES (1, " + CustomerID + "); SET @last_id = LAST_INSERT_ID();SELECT * FROM orders WHERE order_id=@last_id LIMIT 1;";
                //    command.ExecuteNonQuery();
                //}

                using (MySqlConnection connect = new MySqlConnection(General.Build_ConnectionString()))
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    //string commandLine = "SELECT * FROM orders WHERE order_id=@last_id LIMIT 1;";

                    string commandLine = "INSERT INTO orders(`order_status_id`, `customer_id`) VALUES (1, " + CustomerID + "); SET @last_id = LAST_INSERT_ID();SELECT * FROM orders WHERE order_id=@last_id LIMIT 1;";
                    cmd.CommandText = commandLine;

                    cmd.Connection = connect;
                    cmd.Connection.Open();

                    //using (MySqlDataReader reader = cmd.ExecuteReader())
                    //{
                    //    if (reader.HasRows)
                    //    {
                    //        reader.Read();
                    //        InsertedId = Convert.ToInt32(reader["order_id"].ToString());
                    //    }
                    //}

                    DataSet ds = new DataSet();

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(ds);

                        if (ds.Tables[0].Rows.Count > 0)
                            InsertedId = Convert.ToInt32(ds.Tables[0].Rows[0]["order_id"]);
                    }
                }

                for (int i = CartData.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow dr = CartData.Rows[i];
                    ItemValues += "('" + InsertedId.ToString() + "', '" + dr["ID"].ToString() + "', '" + dr["Quantity"].ToString() + "')";

                    ItemValues += (i > 0) ? "," : ";";
                }

                using (var connection = new MySqlConnection())
                {
                    connection.ConnectionString = General.Build_ConnectionString();

                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO order_items(`order_id`, `product_id`, `quantity`) VALUES " + ItemValues;
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
