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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            DG_Suppliers.DataSource = BL_Supplier.Get_All_Supplier();
            DG_Suppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DG_Suppliers.MultiSelect = false;
            DG_Suppliers.ReadOnly = true;
            SupplierDetails.Visible = false;

            DG_Suppliers.Columns["supplier_id"].Visible = false;

            DG_Suppliers.Columns["code"].HeaderText = "Code";
            DG_Suppliers.Columns["name"].HeaderText = "Supplier Name";
            DG_Suppliers.Columns["contact"].HeaderText = "Contact Number";
            DG_Suppliers.Columns["address"].HeaderText = "Address";
            DG_Suppliers.Columns["remarks"].HeaderText = "Remarks";
            DG_Suppliers.Columns["creation_date"].HeaderText = "Creation Date";

            foreach (DataGridViewColumn col in DG_Suppliers.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void btn_AddSupplier_Click(object sender, EventArgs e)
        {
            Add_Supplier addSupplier = new Add_Supplier();
            addSupplier.ShowDialog();
            DG_Suppliers.DataSource = BL_Supplier.Get_All_Supplier();
        }

        private void GetSelectedData()
        {
            try
            {
                foreach (DataGridViewRow row in DG_Suppliers.SelectedRows)
                {
                    SelectedSupplier.Id = Convert.ToInt32(row.Cells["supplier_id"].Value.ToString());
                    SelectedSupplier.Code = row.Cells["code"].Value.ToString();
                    SelectedSupplier.Name = row.Cells["name"].Value.ToString();
                    SelectedSupplier.Address = row.Cells["address"].Value.ToString();
                    SelectedSupplier.Remarks = row.Cells["remarks"].Value.ToString();
                    SelectedSupplier.Contact = row.Cells["contact"].Value.ToString();

                    Lbl_SupplierID.Text = SelectedSupplier.Id.ToString();
                    Lbl_SupplierCode.Text = SelectedSupplier.Code;
                    Lbl_SupplierName.Text = SelectedSupplier.Name;
                    Lbl_SupplierAddress.Text = SelectedSupplier.Address;
                    Lbl_SupplierRemarks.Text = SelectedSupplier.Remarks;
                    Lbl_Contact.Text = SelectedSupplier.Contact;
                }
                btn_UpdateSupplier.Visible = true;
                SupplierDetails.Visible = true;
            }
            catch (Exception ex) { SupplierDetails.Visible = false; }
        }

        private void DG_Suppliers_Selection_Change(object sender, EventArgs e)
        {
            GetSelectedData();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Search.Text))
            {
                DG_Suppliers.DataSource = BL_Supplier.Get_All_Supplier();
                return;
            }

            DG_Suppliers.DataSource = BL_Supplier.Get_Supplier_By_Search(Search.Text);
        }

        private void btn_UpdateSupplier_Click(object sender, EventArgs e)
        {
            UpdateSupplier updateSupplier = new UpdateSupplier();
            updateSupplier.ShowDialog();
            DG_Suppliers.DataSource = BL_Supplier.Get_All_Supplier();
        }
    }
}
