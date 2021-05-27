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
    public partial class UpdateSupplier : Form
    {
        public UpdateSupplier()
        {
            InitializeComponent();
        }

        private void UpdateSupplier_Load(object sender, EventArgs e)
        {
            SupplierID.Text = SelectedSupplier.Id.ToString();
            Name.Text = SelectedSupplier.Name;
            Code.Text = SelectedSupplier.Code;
            Address.Text = SelectedSupplier.Address;
            Remarks.Text = SelectedSupplier.Remarks;
            Contact.Text = SelectedSupplier.Contact;
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
                Id = Convert.ToInt32(SupplierID.Text),
                Name = Name.Text,
                Contact = Contact.Text,
                Address = Address.Text,
                Remarks = Remarks.Text,
                Code = Code.Text
            };

            if (!BL_Supplier.AddOrUpdate_Supplier(supplier))
            {
                MessageBox.Show("Unable to updated supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Successfully updated supplier", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
