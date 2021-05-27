using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Inventory.Models;
using Inventory.BusinessLayer;

namespace Inventory.Forms
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(CustomerImage.DisplayRectangle);
            CustomerImage.Region = new Region(gp);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FirstName.Text) || String.IsNullOrEmpty(LastName.Text) || String.IsNullOrEmpty(ContactNumber.Text) || String.IsNullOrEmpty(Address.Text))
            {
                MessageBox.Show("Please provide all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try { Convert.ToInt64(ContactNumber.Text); }
            catch (Exception ex) { MessageBox.Show("Invalid contact number. Please enter numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                 
            Inventory.Models.Customer customer = new Inventory.Models.Customer()
            {
                FristName = FirstName.Text,
                LastName = LastName.Text,
                ContactNumber = ContactNumber.Text,
                Address = Address.Text,
                CustomerImage = CustomerImage.Image
            };

            if (BL_Customer.Add_Customer(customer))
            {
                MessageBox.Show("Customer has been successfully added.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
                MessageBox.Show("An Error occured when adding customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void CustomerImage_Click(object sender, EventArgs e)
        {
            var op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
                CustomerImage.Image = Image.FromFile(op.FileName);
        }
    }
}
