using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory.BusinessLayer;

namespace Inventory.Forms.UserControls.Main
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
            this.Load += new EventHandler(Menu_Load);
        }

        void Menu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BL_Menu.Get_Best_Seller();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;

            dataGridView1.Columns["name"].HeaderText = "Product Name";
            dataGridView1.Columns["price"].HeaderText = "Price";
            dataGridView1.Columns["sold_item"].HeaderText = "Number Of Items Sold";
            dataGridView1.Columns["total_price_sold"].HeaderText = "Total Sold Price";

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            Lbl_UserCount.Text = (BL_Menu.User_Count()).ToString();
            Lbl_ProductCount.Text = (BL_Menu.Product_Count()).ToString();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BL_Menu.Get_Best_Seller();
            Lbl_UserCount.Text = (BL_Menu.User_Count()).ToString();
        }
    }
}
