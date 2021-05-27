using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using Inventory.Models;

namespace Inventory.DataLayer.AppSettings
{
    class DL_Database
    {
        public static bool Execute_Database_Creation(string DatabaseName)
        {
            try
            {
                using (var connection = new MySqlConnection())
                {
                    connection.ConnectionString = Build_ConnectionString();

                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = Build_Query(DatabaseName);
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private static string Build_ConnectionString()
        {
            return String.Format("server={0};username={1};password={2}",
                ConnectionString.Server, ConnectionString.Username, ConnectionString.Password);
        }

        private static string Build_Query(string DatabaseName)
        {
            return
                Create_Database(DatabaseName) +
                Create_User_Role() +
                Create_User_Table() +
                Seed_User_Role() +
                Create_User_Access() +
                Create_Product_Brand() +
                Create_Product() +
                Create_Product_History() +
                Create_Customer() +
                Create_Supplier() +
                Create_Order_Status() +
                Create_Order() +
                Create_Order_Items();
        }

        private static string Create_Database(string DatabaseName)
        {
            return @"CREATE DATABASE IF NOT EXISTS " + DatabaseName + "; USE " + DatabaseName + ";";
        }

        private static string Create_User_Role()
        {
            return @"CREATE TABLE user_role (
                     user_role_id int NOT NULL AUTO_INCREMENT,
                     role_name varchar(100) NOT NULL UNIQUE,
                     description varchar(255) NOT NULL,
                     PRIMARY KEY (user_role_id)
                     );";
        }

        private static string Create_User_Table()
        {
            return @"CREATE TABLE users (
                        user_id int NOT NULL AUTO_INCREMENT,
                        firstname varchar(255) NOT NULL,
                        lastname varchar(255) NOT NULL,
                        username varchar(255) NOT NULL UNIQUE,
                        password varchar(255) NOT NULL,
                        active int(1) NOT NULL,
                        PRIMARY KEY (user_id)
                   );";
        }

        private static string Seed_User_Role()
        {
            return @"INSERT INTO user_role (role_name, description)
                     VALUES ('inventory_access', 'inventory access'),
                            ('edit_delete_products_in_inventory', 'edit delete products in inventory'),
                            ('sales_access', 'sales access'),
                            ('edit_delete_print_sales_transaction', 'edit delete print sales transaction'),
                            ('deliveries_access', 'deliveries access'),
                            ('edit_delete_deliveries_transaction', 'edit delete deliveries transaction')
                    ;";
        }

        private static string Create_User_Access()
        {
            return @"CREATE TABLE user_access (
                        user_access_id int NOT NULL AUTO_INCREMENT,
                        user_id int NOT NULL,
                        user_role_id int NOT NULL,
                        allowed int(1) NOT NULL,
                        PRIMARY KEY (user_access_id),
                        FOREIGN KEY (user_role_id) REFERENCES user_role(user_role_id),
                        FOREIGN KEY (user_id) REFERENCES users(user_id)
                   );";
        }

        private static string Create_Product_Brand()
        {
            return @"CREATE TABLE product_brand (
                     product_brand_id int NOT NULL AUTO_INCREMENT,
                     product_brand_name varchar(100) NOT NULL UNIQUE,
                     PRIMARY KEY (product_brand_id)
                     );";
        }

        private static string Create_Product()
        {
            return @"CREATE TABLE product (
                        product_id int NOT NULL AUTO_INCREMENT,
                        product_brand_id int NOT NULL,
                        name varchar(255) NOT NULL UNIQUE,
                        photo varchar(255),
                        quantity int(11),
                        unit varchar(255) NOT NULL,
                        description varchar(100) NOT NULL,
                        purchased_price DECIMAL(19 , 2) NOT NULL,
                        selling_price DECIMAL(19 , 2) NOT NULL,
                        PRIMARY KEY (product_id),
                        FOREIGN KEY (product_brand_id) REFERENCES product_brand(product_brand_id)
                   );";
        }

        private static string Create_Product_History()
        {
            return @"CREATE TABLE product_history (
                     product_history_id int NOT NULL AUTO_INCREMENT,
                     product_id int(11) NOT NULL,
                     product_history_quantity int(11) NOT NULL,
                     product_history_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                     PRIMARY KEY (product_history_id)
                     );";
        }

        private static string Create_Customer()
        {
            return @"CREATE TABLE customer (
                     customer_id int NOT NULL AUTO_INCREMENT,
                     first_name varchar(100) NOT NULL,
                     last_name varchar(100) NOT NULL,
                     contact varchar(100) NOT NULL,
                     address varchar(255) NOT NULL,
                     image varchar(255),
                     creation_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                     PRIMARY KEY (customer_id)
                     );";
        }

        private static string Create_Supplier()
        {
            return @"CREATE TABLE supplier (
                     supplier_id int NOT NULL AUTO_INCREMENT,
                     code varchar(100) NOT NULL,
                     name varchar(100) NOT NULL,
                     contact varchar(100) NOT NULL,
                     address varchar(255) NOT NULL,
                     remarks varchar(255),
                     creation_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                     PRIMARY KEY (supplier_id)
                     );";
        }

        private static string Create_Order_Status()
        {
            return @"CREATE TABLE order_status (
                     order_status_id int NOT NULL AUTO_INCREMENT,
                     order_status_name varchar(100) NOT NULL UNIQUE,
                     description varchar(255) NOT NULL,
                     PRIMARY KEY (order_status_id)
                     );
                     INSERT INTO `order_status`(`order_status_name`, `description`) 
                     VALUES ('Checkout', 'Ready for checkout / Ready for process'),
                     ('On Going', 'Processing / For delivery / For Pickup'),
                     ('Completed', 'Completed transaction'),
                     ('Cancelled', 'Cancelled transaction');
                    ";
        }

        private static string Create_Order()
        {
            return @"CREATE TABLE orders (
                     order_id int NOT NULL AUTO_INCREMENT,
                     order_status_id int NOT NULL,
                     customer_id int NOT NULL,
                     creation_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                     PRIMARY KEY (order_id),
                     FOREIGN KEY (order_status_id) REFERENCES order_status(order_status_id),
                     FOREIGN KEY (customer_id) REFERENCES customer(customer_id)
                     );";
        }

        private static string Create_Order_Items()
        {
            return @"CREATE TABLE order_items (
                     order_item_id int NOT NULL AUTO_INCREMENT,
                     order_id int NOT NULL,
                     product_id int NOT NULL,
                     quantity int NOT NULL,
                     creation_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                     PRIMARY KEY (order_item_id),
                     FOREIGN KEY (product_id) REFERENCES product(product_id),
                     FOREIGN KEY (order_id) REFERENCES orders(order_id)
                     );";
        }
    }
}
