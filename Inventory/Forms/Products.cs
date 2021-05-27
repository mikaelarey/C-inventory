using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory.BusinessLayer;

namespace Inventory.Forms
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            DG_Products.SelectionChanged += new EventHandler(DG_Product_Selection_Change);
            addProduct.ShowDialog();
            DG_Products.DataSource = BL_Product.Get_All_Product();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            DG_Products.DataSource = BL_Product.Get_All_Product();
            DG_Products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DG_Products.MultiSelect = false;
            DG_Products.ReadOnly = true;
            ProductDetails.Visible = false;

            DG_Products.Columns["product_id"].Visible = false;
            DG_Products.Columns["product_brand_id"].Visible = false;
            DG_Products.Columns["photo"].Visible = false;

            DG_Products.Columns["name"].HeaderText = "Product Name";
            DG_Products.Columns["quantity"].HeaderText = "Remaining Stocks";
            DG_Products.Columns["unit"].HeaderText = "Unit";
            DG_Products.Columns["description"].HeaderText = "Description";
            DG_Products.Columns["purchased_price"].HeaderText = "Purchased Price";
            DG_Products.Columns["selling_price"].HeaderText = "Selling Price";
            DG_Products.Columns["product_brand_name"].HeaderText = "Product Brand";

            foreach (DataGridViewColumn col in DG_Products.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void GetSelectedData()
        {
            try
            {
                foreach (DataGridViewRow row in DG_Products.SelectedRows)
                {
                    Product_Image.Image = Image.FromFile(Application.StartupPath + "\\images\\products\\" + row.Cells["photo"].Value.ToString());
                    Lbl_ProductId.Text = row.Cells["product_id"].Value.ToString();
                    Lbl_ProductName.Text = row.Cells["name"].Value.ToString();
                    Lbl_Brand.Text = row.Cells["product_brand_name"].Value.ToString(); ;
                    Lbl_Unit.Text = row.Cells["unit"].Value.ToString();
                    Lbl_PurchasedPrice.Text = row.Cells["purchased_price"].Value.ToString(); ;
                    Lbl_SellingPrice.Text = row.Cells["selling_price"].Value.ToString(); ;
                    Lbl_RemainigStocks.Text = row.Cells["quantity"].Value.ToString(); ;
                }

                ProductDetails.Visible = true;
            }
            catch (Exception ex) { ProductDetails.Visible = false; }
                
        }

        private void DG_Product_Selection_Change(object sender, EventArgs e)
        { 
            GetSelectedData();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Search.Text))
            {
                DG_Products.DataSource = BL_Product.Get_All_Product();
                return;
            }

            DG_Products.DataSource = BL_Product.Get_Products_By_Search(Search.Text);
        }

    }
}
