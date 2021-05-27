using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory.Models;
using Inventory.BusinessLayer;

namespace Inventory.Forms
{
    public partial class SelectCustomer : Form
    {
        public SelectCustomer()
        {
            InitializeComponent();
        }

        private void SelectCustomer_Load(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(Profile_Image.DisplayRectangle);
            Profile_Image.Region = new Region(gp);

            btn_UpdateCustomer.Visible = false;
            DG_Customers.DataSource = BL_Customer.Get_All_Customer();
            DG_Customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DG_Customers.MultiSelect = false;
            DG_Customers.ReadOnly = true;
            panel1.Visible = false;

            DG_Customers.Columns["customer_id"].Visible = false;
            DG_Customers.Columns["image"].Visible = false;

            DG_Customers.Columns["first_name"].HeaderText = "First Name";
            DG_Customers.Columns["last_name"].HeaderText = "Last Name";
            DG_Customers.Columns["contact"].HeaderText = "Contact Number";
            DG_Customers.Columns["address"].HeaderText = "Address";
            DG_Customers.Columns["creation_date"].HeaderText = "Creation Date";

            foreach (DataGridViewColumn col in DG_Customers.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
            DG_Customers.DataSource = BL_Customer.Get_All_Customer();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Search.Text))
            {
                DG_Customers.DataSource = BL_Customer.Get_All_Customer();
                return;
            }

            DG_Customers.DataSource = BL_Customer.Get_Customers_By_Search(Search.Text);
        }

        private void GetSelectedData()
        {
            try
            {
                foreach (DataGridViewRow row in DG_Customers.SelectedRows)
                {
                    SelectedCustomer.CustomerId = Convert.ToInt32(row.Cells["customer_id"].Value.ToString());
                    SelectedCustomer.FristName = row.Cells["first_name"].Value.ToString();
                    SelectedCustomer.LastName = row.Cells["last_name"].Value.ToString();
                    SelectedCustomer.ContactNumber = row.Cells["contact"].Value.ToString();
                    SelectedCustomer.Address = row.Cells["address"].Value.ToString();
                    SelectedCustomer.CustomerImage = (String.IsNullOrEmpty(row.Cells["image"].Value.ToString()))
                        ? null : (Image.FromFile(Application.StartupPath + "\\images\\customers\\" + row.Cells["image"].Value.ToString())).Clone() as Image;

                    Lbl_CustomerId.Text = SelectedCustomer.CustomerId.ToString();
                    Lbl_FirstName.Text = SelectedCustomer.FristName;
                    Lbl_LastName.Text = SelectedCustomer.LastName;
                    Lbl_Contact.Text = SelectedCustomer.ContactNumber;
                    Lbl_Address.Text = SelectedCustomer.Address;
                    Profile_Image.Image = (String.IsNullOrEmpty(row.Cells["image"].Value.ToString()))
                        ? new Bitmap(Inventory.Properties.Resources.user)
                        : Image.FromFile(Application.StartupPath + "\\images\\customers\\" + row.Cells["image"].Value.ToString());
                }

                btn_UpdateCustomer.Visible = true;
                panel1.Visible = true;
            }
            catch (Exception ex) { btn_UpdateCustomer.Visible = false; panel1.Visible = false; }
        }

        private void DG_Customers_Selection_Change(object sender, EventArgs e)
        {
            GetSelectedData();
        }

        private void btn_UpdateCustomer_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer();
            updateCustomer.ShowDialog();
            DG_Customers.DataSource = BL_Customer.Get_All_Customer();
        }

        private void btn_SelectCustomer_Click(object sender, EventArgs e)
        {
            SelectedCartCustomer.Address = Lbl_Address.Text;
            SelectedCartCustomer.ContactNumber = Lbl_Contact.Text;
            SelectedCartCustomer.CustomerId = Convert.ToInt32(Lbl_CustomerId.Text);
            SelectedCartCustomer.FristName = Lbl_FirstName.Text;
            SelectedCartCustomer.LastName = Lbl_LastName.Text;

            this.Hide();
            this.Dispose();
        }
    }
}
