using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory.Models;
using Inventory.BusinessLayer;
using Inventory.BusinessLayer.AppSettings;

namespace Inventory.Forms.AppSettings.UserControls
{
    public partial class AdminAccount : UserControl
    {
        public AdminAccount()
        {
            InitializeComponent();
            Password.UseSystemPasswordChar = true;
            RetypePassword.UseSystemPasswordChar = true;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Username.Text) || String.IsNullOrEmpty(Password.Text) || String.IsNullOrEmpty(RetypePassword.Text))
            {
                MessageBox.Show("Please fill up all fields",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (Password.Text != RetypePassword.Text)
            {
                MessageBox.Show("Two passwords did not match.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User.Username = Username.Text;
                User.Password = Password.Text;

                if (BL_AdminAccount.Is_AdminAccount_Created())
                {
                    MessageBox.Show("Thank you for setting up everything. You can now use the application for the inventory management of your business.",
                        "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BL_AppSettings.Set_FirstRun_To_False();
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("There was an error creating a user account.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AppSetting.HasUserInfo = false;
            (this.Parent as AppSettings).Check_AppSettings();
        }
    }
}
