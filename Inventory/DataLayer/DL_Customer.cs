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
    class DL_Customer
    {
        public static int Add_Customer(Customer customer)
        {
            int InsertedId = 0;

            string InsertProductWithOutImage = @"INSERT INTO customer(first_name, last_name, contact, address, image) 
                                                 VALUES('" + customer.FristName + "', '" + customer.LastName + "', '" + customer.ContactNumber + "', '" + customer.Address + "', '" + customer.ImageFileName + "');" +
                                                "SET @last_id = LAST_INSERT_ID();";

            string InsertProductWithImage = @"INSERT INTO customer(first_name, last_name, contact, address, image) 
                                              VALUES('" + customer.FristName + "', '" + customer.LastName + "', '" + customer.ContactNumber + "', '" + customer.Address + "', '" + customer.ImageFileName + "');" +
                                             "SET @last_id = LAST_INSERT_ID(); UPDATE `customer` SET `image`= CONCAT(@last_id, '.jpg') WHERE customer_id = @last_id;";

            try
            {
                using (var connection = new MySqlConnection())
                {
                    connection.ConnectionString = General.Build_ConnectionString();

                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = (customer.CustomerImage == null) ? InsertProductWithOutImage : InsertProductWithImage;
                    command.ExecuteNonQuery();
                }

                using (MySqlConnection connect = new MySqlConnection(General.Build_ConnectionString()))
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string commandLine = "SELECT * FROM `customer` WHERE customer_id=@last_id LIMIT 1;";
                    cmd.CommandText = commandLine;

                    cmd.Connection = connect;
                    cmd.Connection.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            InsertedId = Convert.ToInt32(reader["customer_id"].ToString());
                        }
                    }
                }

                return InsertedId;
            }
            catch (Exception ex)
            {
                return InsertedId;
            }
        }

        public static DataTable Get_All_Customer()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var connection = new MySqlConnection())
                {
                    connection.ConnectionString = General.Build_ConnectionString();
                    connection.Open();
                    var adapter = new MySqlDataAdapter("SELECT * FROM customer;", connection);
                    adapter.Fill(dt);
                }
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DataTable Get_Customers_By_Search(string Search_Value)
        {
            string SQLCommand = @"SELECT * FROM customer
                                  WHERE first_name LIKE '%" + Search_Value + "%' OR last_name LIKE '%" + Search_Value + "%'";

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

        public static bool Update_Customer(Customer customer)
        {
            string SQLCommand = (customer.CustomerImage == null)
                ? @"UPDATE `customer` SET `first_name`='" + customer.FristName + "', `last_name`='" + customer.LastName + "', `contact`='" + customer.ContactNumber + "', `address`='" + customer.Address + "' WHERE customer_id=" + customer.CustomerId + ";"
                : @"UPDATE `customer` SET `first_name`='" + customer.FristName + "', `last_name`='" + customer.LastName + "', `contact`='" + customer.ContactNumber + "', `address`='" + customer.Address + "', `image`=CONCAT(" + customer.CustomerId.ToString() + ", '.jpg') WHERE customer_id=" + customer.CustomerId + ";";

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
    }
}
