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
    class DL_Sales
    {
        public static DataTable Get_All_Transactions()
        {
            string SQLCommand = @"SELECT orders.order_id as order_ids,
	                                     CONCAT(customer.first_name, ' ', customer.last_name) as customer_name,
	                                     customer.address as customer_address,
                                         customer.contact as customer_contact,
                                         customer.image as customer_image,
                                         (
                                             SELECT COUNT(order_items.product_id) 
                                             FROM order_items 
                                             WHERE order_items.order_id = order_ids
                                         ) as number_of_products,
                                         (
                                             SELECT SUM(order_items.quantity) 
                                             FROM order_items 
                                             WHERE order_items.order_id = order_ids
                                         ) as number_of_items,
                                         (
                                         	SELECT SUM((product.selling_price * order_items.quantity))
                                            FROM product
                                            INNER JOIN order_items
                                                ON product.product_id = order_items.product_id
                                            INNER JOIN orders
                                                ON order_items.order_id = orders.order_id
                                            WHERE orders.order_id = order_ids
                                         ) as total_price,
                                         orders.creation_date as purchased_date,
                                         order_status.order_status_name as order_status,
                                         order_status.order_status_id as order_status_id
                                  FROM customer
                                  INNER JOIN orders 
                                    ON customer.customer_id = orders.customer_id
                                  INNER JOIN order_status
                                    ON orders.order_status_id = order_status.order_status_id;";

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

        public static DataTable Get_Cart_Data_By_Order_Number(int OrderID)
        {
            string SQLCommand = @"SELECT
	                                    customer.customer_id,
	                                    orders.order_id,
	                                    product.product_id,
	                                    product.name, 
                                        product_brand.product_brand_name,
                                        product.unit,
                                        order_items.quantity,
                                        product.selling_price,
                                        (order_items.quantity * product.selling_price) as total_price
                                    FROM orders
                                    INNER JOIN customer
	                                    ON customer.customer_id = orders.customer_id
                                    INNER JOIN order_items
	                                    ON order_items.order_id = orders.order_id
                                    INNER JOIN product
	                                    ON product.product_id = order_items.product_id
                                    INNER JOIN product_brand
	                                    ON product.product_brand_id = product_brand.product_brand_id
                                    WHERE orders.order_id = " + OrderID;

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

        

        public static DataTable Get_All_Order_Status()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var connection = new MySqlConnection())
                {
                    connection.ConnectionString = General.Build_ConnectionString();
                    connection.Open();
                    var adapter = new MySqlDataAdapter("SELECT * FROM order_status;", connection);
                    adapter.Fill(dt);
                }
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool Update_Product_On_Checkout(string Query)
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

        
        public static bool Update_Order_From_OnGoing_To_Completed(int OrderId)
        {
            try
            {
                using (var connection = new MySqlConnection())
                {
                    connection.ConnectionString = General.Build_ConnectionString();

                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = "UPDATE orders SET order_status_id = 3 WHERE order_id = " + OrderId;
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool Cancel_Order(string productQuery)
        {
            try
            {
                using (var connection = new MySqlConnection())
                {
                    connection.ConnectionString = General.Build_ConnectionString();

                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = productQuery;
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
