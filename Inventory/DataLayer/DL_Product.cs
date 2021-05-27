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
    class DL_Product
    {
        public static bool Add_BrandName(string BrandName)
        {
            try
            {
                using (var connection = new MySqlConnection())
                {
                    connection.ConnectionString = General.Build_ConnectionString();

                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO product_brand(product_brand_name) VALUES('" + BrandName + "');";
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static int Add_Product(Product product)
        {
            int InsertedId = 0;

            string InsertProduct = @"SELECT @product_brand_id := product_brand.product_brand_id FROM `product_brand` WHERE product_brand.product_brand_name = '" + product.BrandName + "' LIMIT 1;" +
                                    "INSERT INTO `product`(`product_brand_id`, `name`, `quantity`, `unit`, `description`, `purchased_price`, `selling_price`) " +
                                    "VALUES (@product_brand_id,'" + product.ProductName + "', '" + product.Quantity + "', '" + product.Unit + "', '" + product.Description + "', '" + product.PurchasedPrice + "', '" + product.SellingPrice + "');" +
                                    "SET @last_id = LAST_INSERT_ID(); UPDATE `product` SET `photo`= CONCAT(@last_id, '.jpg') WHERE product_id = @last_id;SELECT * FROM `product` WHERE product_id=@last_id LIMIT 1;";

            try
            {
                //using (var connection = new MySqlConnection())
                //{
                //    connection.ConnectionString = General.Build_ConnectionString();

                //    connection.Open();
                //    var command = connection.CreateCommand();
                //    command.CommandText = InsertProduct;
                //    command.ExecuteNonQuery();
                //}

                using (MySqlConnection connect = new MySqlConnection(General.Build_ConnectionString()))
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    //string commandLine = "SELECT * FROM `product` WHERE product_id=@last_id LIMIT 1;";
                    cmd.CommandText = InsertProduct;

                    cmd.Connection = connect;
                    cmd.Connection.Open();

                    //using (MySqlDataReader reader = cmd.ExecuteReader())
                    //{
                    //    if (reader.HasRows)
                    //    {
                    //        reader.Read();
                    //        InsertedId = Convert.ToInt32(reader[1]["product_id"].ToString());
                    //    }
                    //}

                    DataSet ds = new DataSet();

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(ds);

                        if (ds.Tables[1].Rows.Count > 0)
                            InsertedId = Convert.ToInt32(ds.Tables[1].Rows[0]["product_id"]);
                    }
                }

                return InsertedId;
            }
            catch (Exception ex)
            {
                return InsertedId;
            }
        }

        public static DataTable Get_All_Brand()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var connection = new MySqlConnection())
                {
                    connection.ConnectionString = General.Build_ConnectionString();
                    connection.Open();
                    var adapter = new MySqlDataAdapter("SELECT * FROM product_brand;", connection);
                    adapter.Fill(dt);
                }
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DataTable Get_All_Product()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var connection = new MySqlConnection())
                {
                    connection.ConnectionString = General.Build_ConnectionString();
                    connection.Open();
                    var adapter = new MySqlDataAdapter(@"SELECT product.*, product_brand.product_brand_name 
                                                         FROM product INNER JOIN product_brand 
                                                         ON product_brand.product_brand_id = product.product_brand_id;", 
                                                         connection);
                    adapter.Fill(dt);
                }
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DataTable Get_Products_By_Search(string Search_Value)
        {
            string SQLCommand = @"SELECT product.*, product_brand.product_brand_name 
                                  FROM product INNER JOIN product_brand 
                                  ON product_brand.product_brand_id = product.product_brand_id
                                  WHERE product.name LIKE '%" + Search_Value + "%'";

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

        public static bool Update_Stock(int ProductId, int UpdatedStock) 
        {
            try
            {
                using (var connection = new MySqlConnection())
                {
                    connection.ConnectionString = General.Build_ConnectionString();

                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = @"UPDATE `product` SET `quantity`=" + UpdatedStock + " WHERE product_id=" + ProductId + ";";
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
