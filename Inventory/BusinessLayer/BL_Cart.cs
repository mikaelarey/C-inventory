using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Inventory.Models;
using Inventory.DataLayer;

namespace Inventory.BusinessLayer
{
    class BL_Cart
    {
        public static DataTable CartData = new DataTable("cartData");

        public static void Initialize_CartData()
        {
            DataColumn ID = new DataColumn("ID", typeof(System.Int32));
            DataColumn Product = new DataColumn("Product", typeof(System.String));
            DataColumn Price = new DataColumn("Price", typeof(System.Decimal));
            DataColumn Quantity = new DataColumn("Quantity", typeof(System.Int32));
            DataColumn Brand = new DataColumn("Brand", typeof(System.String));
            DataColumn Unit = new DataColumn("Unit", typeof(System.String));
            DataColumn TotalPrice = new DataColumn("TotalPrice", typeof(System.Decimal));

            CartData.Columns.AddRange(new DataColumn[] { ID, Product, Brand, Unit, Quantity, Price, TotalPrice });
        }

        public static bool Is_Already_In_Cart(int Id)
        {
            bool IsAlreadyExists = false;
              
            if (CartData.Rows.Count > 0)
            {
                for (int i = 0; i < CartData.Rows.Count; i++)
                {
                    int dtItems = Convert.ToInt32(CartData.Rows[i]["ID"].ToString());
                    IsAlreadyExists = dtItems == Id;

                    if (IsAlreadyExists) break;
                }
            }

            return IsAlreadyExists;
        }

        public static void Add_To_Cart(Product product)
        {
            CartData.Rows.Add(
                product.ProductId,
                product.ProductName,
                product.BrandName,
                product.Unit,
                product.Quantity,   // Quantity to be added to cart
                product.SellingPrice,
                product.SellingPrice * product.Quantity
            );
        }

        public static bool Delete_Data_From_Cart(int ProductId)
        {
            try
            {
                for (int i = CartData.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow dr = CartData.Rows[i];
                    if (dr["ID"].ToString() == ProductId.ToString())
                        dr.Delete();
                }

                CartData.AcceptChanges();
                return true;
            }
            catch (Exception ex) { return false; }
        }

        public static bool Update_Data_From_Cart(int ProductId, int Quantity)
        {
            try
            {
                foreach (DataRow dr in CartData.Rows)
                {
                    if (dr["ID"].ToString() == ProductId.ToString())
                    {
                        dr["Quantity"] = Quantity;
                        dr["TotalPrice"] = Quantity * Convert.ToDecimal(dr["Price"]);
                    }
                }

                CartData.AcceptChanges();
                return true;
            }
            catch (Exception ex) { return false; }
        }

        public static bool Save_Cart(int CustomerID)
        {
            if (DL_Cart.Save_Cart(CartData, CustomerID))
            {
                CartData.Clear();
                SelectedCartCustomer.Address = null;
                SelectedCartCustomer.ContactNumber = null;
                SelectedCartCustomer.CustomerId = 0;
                SelectedCartCustomer.FristName = null;
                SelectedCartCustomer.LastName = null;
                return true;
            }

            return false;
        }
    }
}
