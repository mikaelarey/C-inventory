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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TB_FirstName.Text) || String.IsNullOrEmpty(TB_LastName.Text) || String.IsNullOrEmpty(TB_Password.Text) || String.IsNullOrEmpty(TB_Username.Text))
            {
                MessageBox.Show("Username, password, first name and last name are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string SQLCommand = String.Format("INSERT INTO `users`(`firstname`, `lastname`, `username`, `password`, `active`) VALUES ('{0}', '{1}', '{2}', '{3}', 1);",
                                               TB_FirstName.Text, TB_LastName.Text, TB_Username.Text, TB_Password.Text);

            SQLCommand += "SET @last_id = LAST_INSERT_ID();";

            SQLCommand += (CB_InventoryAccess.Checked == true)
                ? "INSERT INTO `user_access`(`user_id`, `user_role_id`, `allowed`) VALUES (@last_id, 1, 1);"
                : "INSERT INTO `user_access`(`user_id`, `user_role_id`, `allowed`) VALUES (@last_id, 1, 0);";

            SQLCommand += (CB_InventoryModify.Checked == true)
                ? "INSERT INTO `user_access`(`user_id`, `user_role_id`, `allowed`) VALUES (@last_id, 2, 1);"
                : "INSERT INTO `user_access`(`user_id`, `user_role_id`, `allowed`) VALUES (@last_id, 2, 0);";

            SQLCommand += (CB_SalesAccess.Checked == true)
                ? "INSERT INTO `user_access`(`user_id`, `user_role_id`, `allowed`) VALUES (@last_id, 3, 1);"
                : "INSERT INTO `user_access`(`user_id`, `user_role_id`, `allowed`) VALUES (@last_id, 3, 0);";

            SQLCommand += (CB_SalesModify.Checked == true)
                ? "INSERT INTO `user_access`(`user_id`, `user_role_id`, `allowed`) VALUES (@last_id, 4, 1);"
                : "INSERT INTO `user_access`(`user_id`, `user_role_id`, `allowed`) VALUES (@last_id, 4, 0);";

            SQLCommand += (CB_DeliveryAccess.Checked == true)
                ? "INSERT INTO `user_access`(`user_id`, `user_role_id`, `allowed`) VALUES (@last_id, 5, 1);"
                : "INSERT INTO `user_access`(`user_id`, `user_role_id`, `allowed`) VALUES (@last_id, 5, 0);";

            SQLCommand += (CB_DeliveryModify.Checked == true)
                ? "INSERT INTO `user_access`(`user_id`, `user_role_id`, `allowed`) VALUES (@last_id, 6, 1);"
                : "INSERT INTO `user_access`(`user_id`, `user_role_id`, `allowed`) VALUES (@last_id, 6, 0);";

            if (BL_UserAccount.Add_User(SQLCommand))
            {
                MessageBox.Show("New user has been successfully added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Unable to add new user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
