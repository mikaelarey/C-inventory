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
    public partial class Inventory : UserControl
    {
        public Inventory()
        {
            InitializeComponent();
            this.Load += new EventHandler(Inventory_Load);
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
        }

        void textBox1_TextChanged(object sender, EventArgs e)
        {
            DG_Products.DataSource = BL_Product.Get_Products_By_Search(textBox1.Text);
        }

        void Inventory_Load(object sender, EventArgs e)
        {
            try
            {
                BL_Cart.Initialize_CartData();

                ProductDetails.Visible = false;
                DG_Products.DataSource = BL_Product.Get_All_Product();
                DG_Products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DG_Products.MultiSelect = false;
                DG_Products.ReadOnly = true;

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

                btn_AddToCart.Visible = false;
                Lbl_AlreadyAddedToCart.Visible = false;
                Lbl_NoStocksAvailable.Visible = false;
                Lbl_Quantity.Visible = false;
                TB_Quantity.Visible = false;

                if (AuthenticatedUser.InventoryModify != 1)
                    btn_ViewCart.Visible = false;

                DG_Products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            { }

            
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
                    Lbl_Brand.Text = row.Cells["product_brand_name"].Value.ToString(); 
                    Lbl_Unit.Text = row.Cells["unit"].Value.ToString();
                    Lbl_PurchasedPrice.Text = row.Cells["purchased_price"].Value.ToString(); 
                    Lbl_SellingPrice.Text = row.Cells["selling_price"].Value.ToString(); 
                    Lbl_RemainigStocks.Text = row.Cells["quantity"].Value.ToString(); 
                }

                ProductDetails.Visible = true;
                TB_Quantity.Text = "";

                if (Convert.ToInt32(Lbl_RemainigStocks.Text) < 1)
                {
                    btn_AddToCart.Visible = false;
                    Lbl_AlreadyAddedToCart.Visible = false;
                    Lbl_NoStocksAvailable.Visible = true;
                    Lbl_Quantity.Visible = false;
                    TB_Quantity.Visible = false;
                }
                else 
                {
                    if (BL_Cart.Is_Already_In_Cart(Convert.ToInt32(Lbl_ProductId.Text)))
                    {
                        btn_AddToCart.Visible = false;
                        Lbl_AlreadyAddedToCart.Visible = true;
                        Lbl_NoStocksAvailable.Visible = false;
                        Lbl_Quantity.Visible = false;
                        TB_Quantity.Visible = false;
                    }
                    else
                    {
                        if (AuthenticatedUser.InventoryModify == 1)
                            btn_AddToCart.Visible = true;

                        Lbl_AlreadyAddedToCart.Visible = false;
                        Lbl_NoStocksAvailable.Visible = false;
                        Lbl_Quantity.Visible = true;
                        TB_Quantity.Visible = true;
                    }
                }
            }
            catch (Exception ex) { ProductDetails.Visible = false; }

        }

        private void DG_Product_Selection_Change(object sender, EventArgs e)
        {
            GetSelectedData();
        }

        private void btn_ViewCart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.ShowDialog();
            DG_Products.DataSource = BL_Product.Get_All_Product();
            cart.Dispose();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DG_Products.DataSource = BL_Product.Get_Products_By_Search(textBox1.Text);
        }

        private void btn_AddToCart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TB_Quantity.Text))
            {
                MessageBox.Show("Please provide quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try { Convert.ToInt32(TB_Quantity.Text); }
            catch (Exception ex) { MessageBox.Show("Invalid quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (Convert.ToInt32(TB_Quantity.Text) > Convert.ToInt32(Lbl_RemainigStocks.Text))
            {
                MessageBox.Show("Insufficient stocks. We only have " + Lbl_RemainigStocks.Text + " available stocks for the product " + Lbl_ProductName.Text + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product product = new Product() 
            {
                ProductId = Convert.ToInt32(Lbl_ProductId.Text), 
                ProductName = Lbl_ProductName.Text, 
                BrandName = Lbl_Brand.Text, 
                Unit = Lbl_Unit.Text, 
                Quantity = Convert.ToInt32(TB_Quantity.Text),   // Quantity to be added to cart
                SellingPrice = Convert.ToDecimal(Lbl_SellingPrice.Text)
            };

            try { BL_Cart.Add_To_Cart(product); }
            catch (Exception ex) { MessageBox.Show("Unable to add to cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            btn_AddToCart.Visible = false;
            Lbl_AlreadyAddedToCart.Visible = true;
            Lbl_NoStocksAvailable.Visible = false;
            Lbl_Quantity.Visible = false;
            TB_Quantity.Visible = false;

            MessageBox.Show("Successfully added to cart.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
