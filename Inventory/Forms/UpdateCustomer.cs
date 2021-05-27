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
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(CustomerImage.DisplayRectangle);
            CustomerImage.Region = new Region(gp);

            CustomerID.Text = SelectedCustomer.CustomerId.ToString();
            FirstName.Text = SelectedCustomer.FristName;
            LastName.Text = SelectedCustomer.LastName;
            ContactNumber.Text = SelectedCustomer.ContactNumber;
            Address.Text = SelectedCustomer.Address;
            CustomerImage.Image = SelectedCustomer.CustomerImage;
            CustomerImage.BackgroundImage = (SelectedCustomer.CustomerImage == null) 
                ? new Bitmap(Inventory.Properties.Resources.user) 
                : new Bitmap(Inventory.Properties.Resources.textbox_placeholder);
        }

        private void CustomerImage_Click(object sender, EventArgs e)
        {
            if (CustomerImage.Image != null)
            {
                MessageBox.Show("Unable to change the uploaded customer image.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
                CustomerImage.Image = Image.FromFile(op.FileName);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FirstName.Text) || String.IsNullOrEmpty(LastName.Text) || String.IsNullOrEmpty(ContactNumber.Text) || String.IsNullOrEmpty(Address.Text))
            {
                MessageBox.Show("Please provide all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try { Convert.ToInt64(ContactNumber.Text); }
            catch (Exception ex) { MessageBox.Show("Invalid contact number. Please enter numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            Inventory.Models.Customer customer = new Inventory.Models.Customer()
            {
                CustomerId = Convert.ToInt32(CustomerID.Text),
                FristName = FirstName.Text,
                LastName = LastName.Text,
                ContactNumber = ContactNumber.Text,
                Address = Address.Text,
                CustomerImage = CustomerImage.Image,
                ImageFileName = CustomerID.Text
            };

            if (BL_Customer.Update_Customer(customer))
            {
                MessageBox.Show("Customer details has been successfully updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else MessageBox.Show("There was an error updating customer details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
