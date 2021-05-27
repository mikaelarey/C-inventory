using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Inventory.BusinessLayer;

namespace Inventory.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(ProfilePicture.DisplayRectangle);
            ProfilePicture.Region = new Region(gp);

            Password.UseSystemPasswordChar = true;
            this.FormClosing += new FormClosingEventHandler(Close_Application);
            Username.KeyDown += new KeyEventHandler(KeyDown_Event);
            Password.KeyDown += new KeyEventHandler(KeyDown_Event);
        }

        void KeyDown_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_User();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_User();
        }

        private void Login_User()
        {
            if (String.IsNullOrEmpty(Username.Text) || String.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show("Please enter your username and passowrd.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (BL_Login.Is_Login_Successful(Username.Text, Password.Text))
            {
                this.Hide();

                Main main = new Main();
                main.Show();
            }

            else
                MessageBox.Show("Username and password did not match.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Close_Application(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
