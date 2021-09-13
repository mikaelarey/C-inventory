using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory.Models;

namespace Inventory.Forms.UserControls.MainUserControl
{
    public partial class Settings : UserControl
    {
        Stocks stocks = new Stocks();
        Products products = new Products();
        Customer customer = new Customer();
        Suppliers suppliers = new Suppliers();

        public Settings()
        {
            InitializeComponent();
            this.Load += new EventHandler(Settings_Load);
        }

        void Settings_Load(object sender, EventArgs e)
        {
            if (AuthenticatedUser.DeliveryModify != 1)
            {
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stocks.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            products.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customer.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            suppliers.ShowDialog();
        }
    }
}
