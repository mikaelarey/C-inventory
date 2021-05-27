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
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            Product_Image.Image = SelectedStock.ProductImage;
            ProductId.Text = SelectedStock.ProductId.ToString();
            ProductName.Text = SelectedStock.ProductName;
            Brand.Text = SelectedStock.BrandName;
            Unit.Text = SelectedStock.Unit;
            PurchasedPrice.Text = SelectedStock.PurchasedPrice.ToString();
            SellingPrice.Text = SelectedStock.SellingPrice.ToString();
            RemainingStocks.Text = SelectedStock.Quantity.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int addedQuantity = Convert.ToInt32(AddedQuantity.Text);
                int remaingQuantity = SelectedStock.Quantity;

                if (BL_Product.Update_Stock(SelectedStock.ProductId, addedQuantity + remaingQuantity))
                {
                    MessageBox.Show("Stock is successfully added.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                    MessageBox.Show("Something went wrong when adding stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please provide numbers only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
