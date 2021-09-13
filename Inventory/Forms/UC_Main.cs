using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory.Models;

namespace Inventory.Forms
{
    public partial class UC_Main : Form
    {
        public UC_Main()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Close_Form);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(877, 531);
            Fullname.Text = String.Format("{0} {1}", AuthenticatedUser.FirstName, AuthenticatedUser.LastName);
            Set_Controls_Visibility(menu1, btn_Menu);
            pictureBox1.Click += new EventHandler(Show_Profile);
            Fullname.Click += new EventHandler(Show_Profile);

            btn_Inventory.Visible = (AuthenticatedUser.InventoryAccess == 1);
            btn_Sales.Visible = (AuthenticatedUser.SalesAccess == 1);
            btn_Settings.Visible = (AuthenticatedUser.DeliveryAccess == 1);

            this.WindowState = FormWindowState.Maximized;
        }

        void Show_Profile(object sender, EventArgs e)
        {
            AdminUserProfileForm adminForm = new AdminUserProfileForm();
            adminForm.ShowDialog();

            Fullname.Text = String.Format("{0} {1}", AuthenticatedUser.FirstName, AuthenticatedUser.LastName);
        }

        private void Close_Form(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Set_Controls_Visibility(UserControl control, Button button)
        {
            menu1.Visible = false;
            inventory1.Visible = false;
            reports1.Visible = false;
            sales1.Visible = false;
            settings1.Visible = false;
            userAccounts1.Visible = false;

            btn_Menu.BackColor = Color.FromArgb(0, 84, 84);
            btn_Inventory.BackColor = Color.FromArgb(0, 84, 84);
            btn_Reports.BackColor = Color.FromArgb(0, 84, 84);
            btn_Sales.BackColor = Color.FromArgb(0, 84, 84);
            btn_Settings.BackColor = Color.FromArgb(0, 84, 84);
            btn_UserAccounts.BackColor = Color.FromArgb(0, 84, 84);

            control.Visible = true;
            button.BackColor = Color.FromArgb(0, 60, 60);
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Set_Controls_Visibility(menu1, btn_Menu);
        }

        private void btn_Inventory_Click(object sender, EventArgs e)
        {
            Set_Controls_Visibility(inventory1, btn_Inventory);
        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            Set_Controls_Visibility(sales1, btn_Sales);
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            Set_Controls_Visibility(settings1, btn_Settings);
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            Set_Controls_Visibility(reports1, btn_Reports);
        }

        private void btn_UserAccounts_Click(object sender, EventArgs e)
        {
            Set_Controls_Visibility(userAccounts1, btn_UserAccounts);
        }
    }
}
