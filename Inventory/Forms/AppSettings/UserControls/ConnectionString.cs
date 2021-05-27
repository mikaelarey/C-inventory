using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory.Models;
using Inventory.BusinessLayer.AppSettings;

namespace Inventory.Forms.AppSettings.UserControls
{
    public partial class ConnectionString : UserControl
    {
        public ConnectionString()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Username.Text) || String.IsNullOrEmpty(Server.Text))
            {
                MessageBox.Show("Server and username are required.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
                
            if (!BL_ConnectionString.Is_ConnectionString_Created(Server.Text, Username.Text, Password.Text))
                    MessageBox.Show("It's either connection string is not valid or may be MySQL is not up and running.",
                        "Database Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                AppSetting.HasConnectionString = true;
                (this.Parent as AppSettings).Check_AppSettings();

                MessageBox.Show("MySQL connection details has been save.",
                    "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
