using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Inventory.DataLayer;
using Microsoft.Reporting.WinForms;

namespace Inventory.BusinessLayer
{
    class BL_Reports
    {
        public static ReportDataSource Transaction_Report_DataSource = new ReportDataSource();
        public static DataTable Transaction_Report = new DataTable();

        public static ReportDataSource Sales_Report_DataSource = new ReportDataSource();
        public static DataTable Sales_Report = new DataTable();

        public static string TotalEarnings = "";
        public static string ReportDate = "";

        public static DataTable Get_Transaction_Report_By_Product()
        { 
            return DL_Reports.Get_Transaction_Report_By_Product();
        }

        public static void Load_Transaction_Report()
        {
            Transaction_Report.Clear();
            Transaction_Report = Get_Transaction_Report_By_Product();
        }

        public static DataTable Get_Sales_Report()
        {
            return DL_Reports.Get_Transaction_Report_By_Order();
        }

        public static void Load_Sales_Report()
        {
            Sales_Report.Clear();
            Sales_Report = Get_Sales_Report();
        }
    }
}
