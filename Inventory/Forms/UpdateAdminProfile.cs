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

namespace Inventory.Forms
{
    public partial class UpdateAdminProfile : Form
    {
        public UpdateAdminProfile()
        {
            InitializeComponent();
        }

        private void UpdateAdminProfile_Load(object sender, EventArgs e)
        {
            TB_FirstName.Text = AuthenticatedUser.FirstName;
            TB_LastName.Text = AuthenticatedUser.LastName;
            TB_Username.Text = AuthenticatedUser.Username;

            TB_Password.UseSystemPasswordChar = true;
            TB_CurrentPassword.UseSystemPasswordChar = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TB_Username.Text) ||String.IsNullOrEmpty(TB_LastName.Text) ||String.IsNullOrEmpty(TB_FirstName.Text))
            {
                MessageBox.Show("Username, first name and lastname are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(TB_CurrentPassword.Text))
            {
                MessageBox.Show("Enter your current password to save changes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TB_CurrentPassword.Text != AuthenticatedUser.Password)
            {
                MessageBox.Show("Incorrect Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (TB_Username.Text == AuthenticatedUser.Username)
            {
                string SQLCommand = (String.IsNullOrEmpty(TB_Password.Text))
                        ? String.Format("UPDATE users SET firstname='{0}',lastname='{1}',username='{2}' WHERE user_id={3}",
                                        TB_FirstName.Text, TB_LastName.Text, TB_Username.Text, AuthenticatedUser.Id)
                        : String.Format("UPDATE users SET firstname='{0}',lastname='{1}',username='{2}', password={3} WHERE user_id={4}",
                                        TB_FirstName.Text, TB_LastName.Text, TB_Username.Text, TB_Password.Text, AuthenticatedUser.Id);

                if (BL_Profile.Update_Profile(SQLCommand))
                {
                    MessageBox.Show("Profile has been successfully updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AuthenticatedUser.FirstName = TB_FirstName.Text;
                    AuthenticatedUser.LastName = TB_LastName.Text;

                    if (!String.IsNullOrEmpty(TB_Password.Text))
                        AuthenticatedUser.Password = TB_Password.Text;

                    this.Hide();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Unable to update profile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (BL_Profile.Is_Username_Exists(TB_Username.Text))
                {
                    MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string SQLCommand = (String.IsNullOrEmpty(TB_Password.Text))
                        ? String.Format("UPDATE `users` SET `firstname`='{0}',`lastname`='{1}',`username`='{2}' WHERE `user_id`={3}",
                                        TB_FirstName.Text, TB_LastName.Text, TB_Username.Text, AuthenticatedUser.Id)
                        : String.Format("UPDATE `users` SET `firstname`='{0}',`lastname`='{1}',`username`='{2}', `password`={3} WHERE `user_id`={4}",
                                        TB_FirstName.Text, TB_LastName.Text, TB_Username.Text, TB_Password.Text, AuthenticatedUser.Id);

                    if (BL_Profile.Update_Profile(SQLCommand))
                    {
                        MessageBox.Show("Profile has been successfully updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AuthenticatedUser.FirstName = TB_FirstName.Text;
                        AuthenticatedUser.LastName = TB_LastName.Text;

                        if (!String.IsNullOrEmpty(TB_Password.Text))
                            AuthenticatedUser.Password = TB_Password.Text;

                        this.Hide();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Unable to update profile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }
    }
}
