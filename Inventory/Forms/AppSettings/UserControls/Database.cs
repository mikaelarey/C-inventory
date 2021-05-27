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
    public partial class Database : UserControl
    {
        public Database()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(DatabaseName.Text))
            {
                MessageBox.Show("Database name is required.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (!BL_Database.Is_Database_Created(DatabaseName.Text))
                MessageBox.Show("It's either connection string or database name are not valid or may be MySQL is not up and running.",
                    "Database Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                AppSetting.HasDatabase = true;
                (this.Parent as AppSettings).Check_AppSettings();

                MessageBox.Show("Database has been successfully created.",
                    "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
