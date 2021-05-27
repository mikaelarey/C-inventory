using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Inventory.Models;
using Inventory.BusinessLayer;

namespace Inventory.Forms
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            pg.Margins.Top = 0;
            pg.Margins.Bottom = 0;
            pg.Margins.Left = 1;
            pg.Margins.Right = 0;
            System.Drawing.Printing.PaperSize size = new PaperSize();
            size.RawKind = (int)PaperKind.Executive;
            pg.PaperSize = size;
            pg.Landscape = true;
            reportViewer1.SetPageSettings(pg);

            this.FormClosing += new FormClosingEventHandler(ReceiptForm_FormClosing);
            this.reportViewer1.RefreshReport();
            Initialize_Report();
        }

        void ReceiptForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

        private void Initialize_Report()
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(BL_Sales.Receipt_Report_DataSource);
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.ReceiptReport.rdlc";

            ReportParameter[] param = new ReportParameter[]
            {
                new ReportParameter("Total", ReceiptData.Total),
                new ReportParameter("Tax", ReceiptData.Tax),
                new ReportParameter("SubTotal", ReceiptData.SubTotal),
                new ReportParameter("OrderNumber", ReceiptData.OrderNumber),
                new ReportParameter("Name", ReceiptData.Name),
                new ReportParameter("ItemSold", ReceiptData.ItemSold),
                new ReportParameter("PurchaseDate", ReceiptData.Date),
                new ReportParameter("Contact", ReceiptData.Contact),
                new ReportParameter("Cashier", ReceiptData.Cashier),
                new ReportParameter("Address", ReceiptData.Address)
            };
            reportViewer1.LocalReport.SetParameters(param);
            reportViewer1.RefreshReport();
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            BL_Sales.Proceed_To_Checkout = true;
            this.Hide();
        }
    }
}
