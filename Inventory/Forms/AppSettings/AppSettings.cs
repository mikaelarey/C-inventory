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

namespace Inventory.Forms.AppSettings
{
    public partial class AppSettings : Form
    {
        public AppSettings()
        {
            InitializeComponent();
        }

        private void AppSettings_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form_Close);
            Set_Controls_Visibility();
            Check_AppSettings();
            BL_AppSettings.Set_ConnectionString();
        }

        public void Check_AppSettings()
        {
            if (!BL_AppSettings.HasConnectionString())
                Set_Controls_Visibility(connectionString1);

            else if (!BL_AppSettings.HasDatabase())
                Set_Controls_Visibility(database1);

            else if (!BL_AppSettings.HasDefaultUser())
            {
                if (AppSetting.HasUserInfo)
                    Set_Controls_Visibility(adminAccount1);
                else
                    Set_Controls_Visibility(adminInfo1);
            }

            else
                Application.Restart();
        }

        private void Form_Close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Set_Controls_Visibility()
        {
            connectionString1.Visible = false;
            database1.Visible = false;
            adminInfo1.Visible = false;
            adminAccount1.Visible = false;
        }

        private void Set_Controls_Visibility(UserControl control)
        {
            connectionString1.Visible = false;
            database1.Visible = false;
            adminInfo1.Visible = false;
            adminAccount1.Visible = false;

            control.Visible = true;
        }
    }
}
