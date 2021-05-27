using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory.Models;

namespace Inventory.Forms.AppSettings.UserControls
{
    public partial class AdminInfo : UserControl
    {
        public AdminInfo()
        {
            InitializeComponent();

            FirstName.Text = User.FirstName;
            MiddleName.Text = User.MiddleName;
            LastName.Text = User.LastName;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FirstName.Text) || String.IsNullOrEmpty(MiddleName.Text) || String.IsNullOrEmpty(LastName.Text))
            {
                MessageBox.Show("Please fill up all fields",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            User.FirstName = FirstName.Text;
            User.MiddleName = MiddleName.Text;
            User.LastName = LastName.Text;

            AppSetting.HasUserInfo = true;
            (this.Parent as AppSettings).Check_AppSettings();
        }
    }
}
