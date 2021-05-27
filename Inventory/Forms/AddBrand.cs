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
    public partial class AddBrand : Form
    {
        public AddBrand()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(BrandName.Text))
                MessageBox.Show("Please enter a brand name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else 
            {
                if (BL_Product.Add_BrandName(BrandName.Text))
                    MessageBox.Show(BrandName.Text + " has been successfully added to the lists.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                else
                    MessageBox.Show("There was an error adding new brand.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Hide();
            }
        }
    }
}
