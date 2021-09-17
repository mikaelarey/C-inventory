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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            DG_Cart.DataSource = BL_Cart.CartData;

            DG_Cart.Columns["ID"].Visible = false;
            DG_Cart.Columns["Product"].HeaderText = "Product Name";
            DG_Cart.Columns["TotalPrice"].HeaderText = "Total Price";

            foreach (DataGridViewColumn col in DG_Cart.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            Pnl_ProductDetails.Visible = false;
            DG_Cart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DG_Cart.MultiSelect = false;
            DG_Cart.ReadOnly = true;

            Get_Cart_Summary();
            Set_Save_Button_Visibility();
            Set_Customer_detail();
        }

        private void GetSelectedData()
        {
            try
            {
                foreach (DataGridViewRow row in DG_Cart.SelectedRows)
                {
                    Product_Image.Image = Image.FromFile(Application.StartupPath + "\\images\\products\\" + row.Cells["ID"].Value.ToString() + ".jpg");
                    Lbl_ProductId.Text = row.Cells["ID"].Value.ToString();
                    Lbl_ProductName.Text = row.Cells["Product"].Value.ToString();
                    Lbl_Brand.Text = row.Cells["Brand"].Value.ToString();
                    Lbl_Unit.Text = row.Cells["Unit"].Value.ToString();
                    Lbl_Quantity.Text = row.Cells["Quantity"].Value.ToString();
                    Lbl_SellingPrice.Text = row.Cells["Price"].Value.ToString();
                    Lbl_TotalPrice.Text = row.Cells["TotalPrice"].Value.ToString(); 
                }

                Pnl_ProductDetails.Visible = true;
            }
            catch (Exception ex) { Pnl_ProductDetails.Visible = false; }

        }

        private void DG_Product_Selection_Change(object sender, EventArgs e)
        {
            GetSelectedData();
        }

        private void Get_Cart_Summary()
        {
            int TotalQuantity = 0;
            decimal TotalPrice = 0;

            try
            {
                for (int i = 0; i < DG_Cart.Rows.Count; ++i)
                {
                    TotalQuantity += Convert.ToInt32(DG_Cart.Rows[i].Cells["Quantity"].Value);
                    TotalPrice += Convert.ToDecimal(DG_Cart.Rows[i].Cells["TotalPrice"].Value);
                }
            }
            catch (Exception ex) { }

            Lbl_TotalQuantity.Text = TotalQuantity.ToString();
            Lbl_TotalPriceSummary.Text = TotalPrice.ToString();
            Lbl_NumberOfItems.Text = (DG_Cart.Rows.Count - 1).ToString();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (!BL_Cart.Delete_Data_From_Cart(Convert.ToInt32(Lbl_ProductId.Text)))
            {
                MessageBox.Show("Unable to remove item from cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pnl_ProductDetails.Visible = false;
            DG_Cart.DataSource = BL_Cart.CartData;
            Get_Cart_Summary();
            Set_Save_Button_Visibility();
        }

        private void Set_Save_Button_Visibility()
        {
            btn_Save.Visible = (BL_Cart.CartData.Rows.Count > 0);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            UpdateCart updateCart = new UpdateCart();

            SelectedCartItem.ProductImage = Product_Image.Image;
            SelectedCartItem.ID = Convert.ToInt32(Lbl_ProductId.Text);
            SelectedCartItem.Name = Lbl_ProductName.Text;
            SelectedCartItem.Brand = Lbl_Brand.Text;
            SelectedCartItem.Unit = Lbl_Unit.Text;
            SelectedCartItem.Quantity = Convert.ToInt32(Lbl_Quantity.Text);
            SelectedCartItem.Price = Convert.ToDecimal(Lbl_SellingPrice.Text);
            SelectedCartItem.TotalPrice = Convert.ToDecimal(Lbl_TotalPrice.Text);

            updateCart.ShowDialog();
            DG_Cart.DataSource = BL_Cart.CartData;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (BL_Cart.CartData.Rows.Count < 1)
            {
                MessageBox.Show("No items available on this cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(Lbl_Customer_ID.Text))
            {
                MessageBox.Show("There are no customer for this cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (BL_Cart.Save_Cart(Convert.ToInt32(Lbl_Customer_ID.Text)))
            {
                MessageBox.Show("Cart has been successfully saved and ready for checkout", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BL_Sales.Get_All_Transactions(1);
                
                this.Hide();
                this.Dispose();

                return;
            }

            MessageBox.Show("Unable to save cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Btn_Add_Customer_Click(object sender, EventArgs e)
        {
            SelectCustomer selectCustomer = new SelectCustomer();
            selectCustomer.ShowDialog();
            Set_Customer_detail();
        }

        private void Set_Customer_detail()
        {
            Lbl_Customer_ID.Text = SelectedCartCustomer.CustomerId.ToString() == "0" ? "" : SelectedCartCustomer.CustomerId.ToString();
            Lbl_ContactNumber.Text = SelectedCartCustomer.ContactNumber;
            Lbl_Customer_Name.Text = String.Format("{0} {1}", SelectedCartCustomer.FristName, SelectedCartCustomer.LastName);
            Lbl_Address.Text = SelectedCartCustomer.Address;
        }
    }
}
