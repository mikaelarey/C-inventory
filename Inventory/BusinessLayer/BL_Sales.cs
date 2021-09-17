using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Inventory.DataLayer;
using Microsoft.Reporting.WinForms;

namespace Inventory.BusinessLayer
{
    class BL_Sales
    {
        public static ReportDataSource Receipt_Report_DataSource = new ReportDataSource();
        public static DataTable Receipt_Report = new DataTable();

        public static DataTable ProductsData = new DataTable("productsData");
        public static DataTable TransactionData = new DataTable("transactionData");

        public static int ActiveOrderStatus { get; set; }

        public static bool Proceed_To_Checkout = false;

        public static void Get_All_Transactions(int order_status_id)
        {
            TransactionData.Clear();
            TransactionData = DL_Sales.Get_All_Transactions(order_status_id);

            foreach (DataRow row in TransactionData.Rows)
            {
                DateTime dt = DateTime.Parse(row["purchased_date"].ToString());
                row["purchased_date"] = dt.ToShortDateString();
            }
        }

        public static void Get_All_Products()
        {
            ProductsData.Clear();
            ProductsData = DL_Product.Get_All_Product();
        }

        public static DataTable Get_All_Order_Status()
        {
            return DL_Sales.Get_All_Order_Status();
        }

        public static DataTable Get_Cart_Data_By_Order_Number(int OrderID)
        {
            return DL_Sales.Get_Cart_Data_By_Order_Number(OrderID);
        }

        public static bool Update_Product_On_Checkout(string Query)
        {
            return DL_Sales.Update_Product_On_Checkout(Query);
        }

        public static bool Update_Order_From_OnGoing_To_Completed(int OrderId)
        {
            return DL_Sales.Update_Order_From_OnGoing_To_Completed(OrderId);
        }

        public static bool Cancel_Order(string productQuery)
        {
            return DL_Sales.Cancel_Order(productQuery);
        }
    }
}
