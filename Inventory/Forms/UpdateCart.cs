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
    public partial class UpdateCart : Form
    {
        public UpdateCart()
        {
            InitializeComponent();
        }

        private void UpdateCart_Load(object sender, EventArgs e)
        {
            Product_Image.Image = SelectedCartItem.ProductImage;
            Lbl_Brand.Text = SelectedCartItem.Brand;
            Lbl_ProductId.Text = SelectedCartItem.ID.ToString();
            Lbl_ProductName.Text = SelectedCartItem.Name;
            Lbl_SellingPrice.Text = SelectedCartItem.Price.ToString();
            Lbl_TotalPrice.Text = SelectedCartItem.TotalPrice.ToString();
            Lbl_Unit.Text = SelectedCartItem.Unit;
            TB_Quantity.Text = SelectedCartItem.Quantity.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try { Convert.ToInt32(TB_Quantity.Text); }
            catch (Exception ex) { MessageBox.Show("Invalid quantity value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (BL_Cart.Update_Data_From_Cart(Convert.ToInt32(Lbl_ProductId.Text), Convert.ToInt32(TB_Quantity.Text)))
            {
                MessageBox.Show("Cart item has been successfully updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                this.Dispose();
            }
            else
                MessageBox.Show("Unable to update cart item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TB_Quantity_TextChanged(object sender, EventArgs e)
        {
            try { 
                Convert.ToInt32(TB_Quantity.Text);
                Lbl_TotalPrice.Text = (Convert.ToInt32(TB_Quantity.Text) * Convert.ToDecimal(Lbl_SellingPrice.Text)).ToString();
            }
            catch (Exception ex) { return; }
        }
    }
}
