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
    public partial class UserAccounts : UserControl
    {
        public UserAccounts()
        {
            InitializeComponent();
            this.Load += new EventHandler(UserAccounts_Load);
        }

        void UserAccounts_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BL_UserAccount.Get_All_Users();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;

            dataGridView1.Columns["user_id"].HeaderText = "User ID";
            dataGridView1.Columns["firstname"].HeaderText = "First Name";
            dataGridView1.Columns["lastname"].HeaderText = "Last Name";
            dataGridView1.Columns["username"].HeaderText = "Username";
            dataGridView1.Columns["active"].HeaderText = "Active Status";

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
            dataGridView1.DataSource = BL_UserAccount.Get_All_Users();
        }
    }
}
