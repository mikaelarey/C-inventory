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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var op  = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
                ProductImage.Image = Image.FromFile(op.FileName);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ProductName.Text) || String.IsNullOrEmpty(Brand.Text) || String.IsNullOrEmpty(Unit.Text) || String.IsNullOrEmpty(PurchasedPrice.Text) ||
                String.IsNullOrEmpty(SellingPrice.Text) || String.IsNullOrEmpty(Desc.Text) || String.IsNullOrEmpty(Quantity.Text) || ProductImage.Image == null)
            {
                MessageBox.Show("Please provide the required fields including product image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Convert.ToDecimal(PurchasedPrice.Text);
                    Convert.ToDecimal(SellingPrice.Text);
                    Convert.ToInt32(Quantity.Text);
                }
                catch (Exception ex) { MessageBox.Show("Invalid either purchased price, selling price or quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                
                Product product = new Product()
                {
                    ProductName = ProductName.Text,
                    BrandName = Brand.Text,
                    Unit = Unit.Text,
                    PurchasedPrice = Convert.ToDecimal(PurchasedPrice.Text),
                    SellingPrice = Convert.ToDecimal(SellingPrice.Text),
                    Description = Desc.Text,
                    Quantity = Convert.ToInt32(Quantity.Text),
                    ProductImage = ProductImage.Image
                };

                if (BL_Product.Save_Product(product))
                {
                    MessageBox.Show("Successfully added new product,", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("There was an error inserting new product. Product name should be unique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddBrand_Click(object sender, EventArgs e)
        {
            AddBrand addBrand = new AddBrand();
            addBrand.ShowDialog();
            Reload_Brand_Items();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            Reload_Brand_Items();
        }

        private void Reload_Brand_Items()
        {
            Brand.Items.Clear();

            DataTable brand = new DataTable();
            brand = BL_Product.Get_All_Brand();

            foreach (DataRow row in brand.Rows)
            {
                Brand.Items.Add(row["product_brand_name"].ToString());
            }
        }
    }
}
