using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory.Models;

namespace Inventory.Forms
{
    public partial class AdminUserProfileForm : Form
    {
        public AdminUserProfileForm()
        {
            InitializeComponent();
        }

        private void AdminUserProfileForm_Load(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(CustomerImage.DisplayRectangle);
            CustomerImage.Region = new Region(gp);

            textBox1.Text = String.Format("{0} {1}", AuthenticatedUser.FirstName, AuthenticatedUser.LastName);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateAdminProfile updateAdmin = new UpdateAdminProfile();
            updateAdmin.ShowDialog();

            textBox1.Text = String.Format("{0} {1}", AuthenticatedUser.FirstName, AuthenticatedUser.LastName);
        }


    }
}
