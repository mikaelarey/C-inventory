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
    class DL_Reports
    {
        public static DataTable Get_Transaction_Report_By_Order()
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
                                  ON orders.order_status_id = order_status.order_status_id
                                  WHERE orders.order_status_id IN (2, 3);";

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

        public static DataTable Get_Transaction_Report_By_Product()
        {
            string SQLCommand = @"SELECT
	                                  orders.creation_date as creation_date,
                                      CONCAT(customer.first_name, ' ', customer.last_name) as customer_name,
                                      product.name,
                                      order_items.quantity as item_quantity,
                                      product.unit,
                                      product.selling_price as price,
                                      (
                                          SELECT (item_quantity * price)
                                      ) as total_price
                                  FROM product
                                  INNER JOIN order_items
	                                  ON product.product_id = order_items.product_id
                                  INNER JOIN orders
	                                  ON orders.order_id = order_items.order_id
                                  INNER JOIN customer
	                                  ON customer.customer_id = orders.customer_id
                                  WHERE orders.order_status_id IN (2, 3);";

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
