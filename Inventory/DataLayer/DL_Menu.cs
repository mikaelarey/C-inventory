using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using Inventory.Configuration;

namespace Inventory.DataLayer
{
    class DL_Menu
    {
        public static DataTable Get_Best_Seller()
        {
            /*
            string SQLCommand = @"SELECT 
	                                product.name as name, 
                                    product.selling_price as price, 
                                    SUM(order_items.quantity) as sold_item,
                                    (
                                        SELECT (price * SUM(order_items.quantity))
                                    ) as total_price_sold
                                FROM `order_items` 
                                INNER JOIN product
	                                ON order_items.product_id = product.product_id
                                GROUP BY order_items.product_id
                                ORDER BY sold_item DESC;";
             */

            string SQLCommand = @"SELECT 
	                                product.name as name, 
                                    product.selling_price as price, 
                                    SUM(order_items.quantity) as sold_item, 
                                    ( 
                                        SELECT (price * SUM(order_items.quantity)) 
                                    ) as total_price_sold 
                                FROM `order_items` 
                                INNER JOIN product 
	                                ON order_items.product_id = product.product_id 
                                INNER JOIN orders
	                                ON orders.order_id = order_items.order_id
                                WHERE orders.order_status_id IN (2, 3)
                                GROUP BY order_items.product_id 
                                ORDER BY sold_item DESC;";

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

        public static int User_Count()
        {
            int UserCount = 0;

            try
            {
                using (MySqlConnection connect = new MySqlConnection(General.Build_ConnectionString()))
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string commandLine = "SELECT COUNT(*) as user_count FROM users;";

                    cmd.CommandText = commandLine;
                    cmd.Connection = connect;
                    cmd.Connection.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            UserCount = Convert.ToInt32(reader["user_count"].ToString());
                        }
                    }
                }
            }
            catch (Exception e) { UserCount = 0; }

            return UserCount;
        }

        public static int Product_Count()
        {
            int UserCount = 0;

            try
            {
                using (MySqlConnection connect = new MySqlConnection(General.Build_ConnectionString()))
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string commandLine = "SELECT COUNT(*) as product_count FROM `product` WHERE product.quantity = 0;";

                    cmd.CommandText = commandLine;
                    cmd.Connection = connect;
                    cmd.Connection.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            UserCount = Convert.ToInt32(reader["product_count"].ToString());
                        }
                    }
                }
            }
            catch (Exception e) { UserCount = 0; }

            return UserCount;
        }
    }
}
