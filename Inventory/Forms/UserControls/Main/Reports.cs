using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory.Models;
using Inventory.BusinessLayer;

namespace Inventory.Forms.UserControls.MainUserControl
{
    public partial class Reports : UserControl
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Btn_Transaction_Report_Click(object sender, EventArgs e)
        {
            List<TransactionReportModel> list = new List<TransactionReportModel>();
            list.Clear();

            BL_Reports.Load_Transaction_Report();

            foreach (DataRow row in BL_Reports.Transaction_Report.Rows)
            {
                if (dateTimePicker1.Value.ToShortDateString() == (Convert.ToDateTime(row["creation_date"].ToString())).ToShortDateString())
                {
                    TransactionReportModel report = new TransactionReportModel()
                    {
                        creation_date = row["creation_date"].ToString(),
                        customer_name = row["customer_name"].ToString(),
                        item_quantity = row["item_quantity"].ToString(),
                        name = row["name"].ToString(),
                        price = row["price"].ToString(),
                        total_price = row["total_price"].ToString(),
                        unit = row["unit"].ToString()
                    };

                    list.Add(report);
                }
            }

            BL_Reports.Transaction_Report_DataSource.Name = "TransactionDataSet";
            BL_Reports.Transaction_Report_DataSource.Value = list;
            BL_Reports.ReportDate = String.Format("Report Date: {0}", dateTimePicker1.Value.ToShortDateString());

            TransactionReportForm transactionReport = new TransactionReportForm();
            transactionReport.ShowDialog();
        }

        private void Btn_Cash_Sales_Report_Click(object sender, EventArgs e)
        {
            List<SalesReportModel> list = new List<SalesReportModel>();
            list.Clear();

            BL_Reports.Load_Sales_Report();

            decimal TotalEarnings = 0;

            foreach (DataRow row in BL_Reports.Sales_Report.Rows)
            {
                if (dateTimePicker1.Value.ToShortDateString() == (Convert.ToDateTime(row["purchased_date"].ToString())).ToShortDateString())
                {
                    SalesReportModel salesReport = new SalesReportModel()
                    {
                        purchased_date = row["purchased_date"].ToString(),
                        order_ids = row["order_ids"].ToString(),
                        customer_name = row["customer_name"].ToString(),
                        cashier = "",
                        total_price = row["total_price"].ToString(),
                    };

                    list.Add(salesReport);

                    TotalEarnings += Convert.ToDecimal(row["total_price"].ToString());
                }
            }

            BL_Reports.Transaction_Report_DataSource.Name = "SalesDataSet";
            BL_Reports.Transaction_Report_DataSource.Value = list;
            BL_Reports.TotalEarnings = TotalEarnings.ToString();
            BL_Reports.ReportDate = String.Format("Report Date: {0}", dateTimePicker1.Value.ToShortDateString());

            SalesReportForm salesReportForm = new SalesReportForm();
            salesReportForm.ShowDialog();
        }
    }
}
