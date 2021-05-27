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
    public partial class Add_Supplier : Form
    {
        public Add_Supplier()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Name.Text) || String.IsNullOrEmpty(Contact.Text) || String.IsNullOrEmpty(Address.Text) || String.IsNullOrEmpty(Remarks.Text))
            {
                MessageBox.Show("Supplier name, contact, address and remarks are required. Code is optional", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try { Convert.ToInt64(Contact.Text); }
            catch (Exception ex) { MessageBox.Show("Invalid contact number. Enter numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            Supplier supplier = new Supplier() 
            {
                Id = 0,
                Name = Name.Text,
                Contact = Contact.Text,
                Address = Address.Text,
                Remarks = Remarks.Text,
                Code = Code.Text
            };

            if (!BL_Supplier.AddOrUpdate_Supplier(supplier))
            {
                MessageBox.Show("Unable to add new supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Successfully added new supplier", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
