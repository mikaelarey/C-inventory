using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory.Models;
using Inventory.BusinessLayer;

namespace Inventory.Forms
{
    public partial class Stocks : Form
    {
        AddStock addStock = new AddStock();

        public Stocks()
        {
            InitializeComponent();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            DG_Stocks.DataSource = BL_Product.Get_All_Product();
            DG_Stocks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DG_Stocks.MultiSelect = false;
            DG_Stocks.ReadOnly = true;
            button1.Visible = false;
            StockDetails.Visible = false;

            DG_Stocks.Columns["product_id"].Visible = false;
            DG_Stocks.Columns["product_brand_id"].Visible = false;
            DG_Stocks.Columns["photo"].Visible = false;

            DG_Stocks.Columns["name"].HeaderText = "Product Name";
            DG_Stocks.Columns["quantity"].HeaderText = "Remaining Stocks";
            DG_Stocks.Columns["unit"].HeaderText = "Unit";
            DG_Stocks.Columns["description"].HeaderText = "Description";
            DG_Stocks.Columns["purchased_price"].HeaderText = "Purchased Price";
            DG_Stocks.Columns["selling_price"].HeaderText = "Selling Price";
            DG_Stocks.Columns["product_brand_name"].HeaderText = "Product Brand";

            foreach (DataGridViewColumn col in DG_Stocks.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addStock.ShowDialog();
            DG_Stocks.DataSource = BL_Product.Get_All_Product();
            GetSelectedData();
        }

        private void GetSelectedData()
        {
            try
            {
                foreach (DataGridViewRow row in DG_Stocks.SelectedRows)
                {
                    SelectedStock.ProductImage = Image.FromFile(Application.StartupPath + "\\images\\products\\" + row.Cells["photo"].Value.ToString());
                    SelectedStock.ProductId = Convert.ToInt32(row.Cells["product_id"].Value.ToString());
                    SelectedStock.ProductName = row.Cells["name"].Value.ToString();
                    SelectedStock.BrandName = row.Cells["product_brand_name"].Value.ToString();
                    SelectedStock.Unit = row.Cells["unit"].Value.ToString();
                    SelectedStock.PurchasedPrice = Convert.ToDecimal(row.Cells["purchased_price"].Value.ToString());
                    SelectedStock.SellingPrice = Convert.ToDecimal(row.Cells["selling_price"].Value.ToString());
                    SelectedStock.Quantity = Convert.ToInt32(row.Cells["quantity"].Value.ToString());

                    Product_Image.Image = SelectedStock.ProductImage;
                    Lbl_ProductId.Text = SelectedStock.ProductId.ToString();
                    Lbl_ProductName.Text = SelectedStock.ProductName;
                    Lbl_Brand.Text = SelectedStock.BrandName;
                    Lbl_Unit.Text = SelectedStock.Unit;
                    Lbl_PurchasedPrice.Text = SelectedStock.PurchasedPrice.ToString();
                    Lbl_SellingPrice.Text = SelectedStock.SellingPrice.ToString();
                    Lbl_RemainingStocks.Text = SelectedStock.Quantity.ToString();
                }
                button1.Visible = true;
                StockDetails.Visible = true;
            }
            catch (Exception ex) { StockDetails.Visible = false; }
        }

        private void DG_Stocks_Selection_Change(object sender, EventArgs e)
        {
            GetSelectedData();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Search.Text))
            {
                DG_Stocks.DataSource = BL_Product.Get_All_Product();
                return;
            }

            DG_Stocks.DataSource = BL_Product.Get_Products_By_Search(Search.Text);
        }
    }
}
