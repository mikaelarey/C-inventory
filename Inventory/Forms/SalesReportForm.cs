﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using Microsoft.Reporting.WinForms;
using Inventory.BusinessLayer;

namespace Inventory.Forms
{
    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
        {
            InitializeComponent();
        }

        private void SalesReportForm_Load(object sender, EventArgs e)
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

            this.FormClosing += new FormClosingEventHandler(SalesReportForm_FormClosing);
            this.reportViewer1.RefreshReport();
            Initialize_Report();
            this.reportViewer1.RefreshReport();
        }

        void SalesReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

        void TransactionReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

        private void Initialize_Report()
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(BL_Reports.Transaction_Report_DataSource);
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.SalesReport.rdlc";

            ReportParameter[] param = new ReportParameter[]
            {
                new ReportParameter("TotalEarnings", BL_Reports.TotalEarnings),
                new ReportParameter("ReportDate", BL_Reports.ReportDate)
            };
            reportViewer1.LocalReport.SetParameters(param);

            reportViewer1.RefreshReport();
        }
    }
}
