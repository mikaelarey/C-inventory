namespace Inventory.Forms
{
    partial class UC_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Fullname = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_UserAccounts = new System.Windows.Forms.Button();
            this.btn_Reports = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Sales = new System.Windows.Forms.Button();
            this.btn_Inventory = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.menu1 = new Inventory.Forms.UserControls.MainUserControl.Menu();
            this.inventory1 = new Inventory.Forms.UserControls.MainUserControl.Inventory();
            this.reports1 = new Inventory.Forms.UserControls.MainUserControl.Reports();
            this.sales1 = new Inventory.Forms.UserControls.MainUserControl.Sales();
            this.settings1 = new Inventory.Forms.UserControls.MainUserControl.Settings();
            this.userAccounts1 = new Inventory.Forms.UserControls.MainUserControl.UserAccounts();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 42);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.Fullname);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(666, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 42);
            this.panel2.TabIndex = 0;
            // 
            // Fullname
            // 
            this.Fullname.AutoSize = true;
            this.Fullname.Dock = System.Windows.Forms.DockStyle.Right;
            this.Fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fullname.ForeColor = System.Drawing.Color.White;
            this.Fullname.Location = new System.Drawing.Point(120, 11);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(92, 20);
            this.Fullname.TabIndex = 3;
            this.Fullname.Text = "Admin User";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 11);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(212, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 42);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(223, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel5.Controls.Add(this.btn_UserAccounts);
            this.panel5.Controls.Add(this.btn_Reports);
            this.panel5.Controls.Add(this.btn_Settings);
            this.panel5.Controls.Add(this.btn_Sales);
            this.panel5.Controls.Add(this.btn_Inventory);
            this.panel5.Controls.Add(this.btn_Menu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(118, 536);
            this.panel5.TabIndex = 2;
            // 
            // btn_UserAccounts
            // 
            this.btn_UserAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_UserAccounts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.btn_UserAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UserAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UserAccounts.ForeColor = System.Drawing.Color.White;
            this.btn_UserAccounts.Location = new System.Drawing.Point(0, 375);
            this.btn_UserAccounts.Name = "btn_UserAccounts";
            this.btn_UserAccounts.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.btn_UserAccounts.Size = new System.Drawing.Size(118, 75);
            this.btn_UserAccounts.TabIndex = 5;
            this.btn_UserAccounts.Text = "User Accounts";
            this.btn_UserAccounts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_UserAccounts.UseVisualStyleBackColor = true;
            this.btn_UserAccounts.Click += new System.EventHandler(this.btn_UserAccounts_Click);
            // 
            // btn_Reports
            // 
            this.btn_Reports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Reports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.btn_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reports.ForeColor = System.Drawing.Color.White;
            this.btn_Reports.Location = new System.Drawing.Point(0, 300);
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.btn_Reports.Size = new System.Drawing.Size(118, 75);
            this.btn_Reports.TabIndex = 4;
            this.btn_Reports.Text = "Reports";
            this.btn_Reports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Reports.UseVisualStyleBackColor = true;
            this.btn_Reports.Click += new System.EventHandler(this.btn_Reports_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.ForeColor = System.Drawing.Color.White;
            this.btn_Settings.Location = new System.Drawing.Point(0, 225);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.btn_Settings.Size = new System.Drawing.Size(118, 75);
            this.btn_Settings.TabIndex = 3;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Sales
            // 
            this.btn_Sales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Sales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.btn_Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sales.ForeColor = System.Drawing.Color.White;
            this.btn_Sales.Location = new System.Drawing.Point(0, 150);
            this.btn_Sales.Name = "btn_Sales";
            this.btn_Sales.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.btn_Sales.Size = new System.Drawing.Size(118, 75);
            this.btn_Sales.TabIndex = 2;
            this.btn_Sales.Text = "Sales";
            this.btn_Sales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sales.UseVisualStyleBackColor = true;
            this.btn_Sales.Click += new System.EventHandler(this.btn_Sales_Click);
            // 
            // btn_Inventory
            // 
            this.btn_Inventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Inventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.btn_Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inventory.ForeColor = System.Drawing.Color.White;
            this.btn_Inventory.Location = new System.Drawing.Point(0, 75);
            this.btn_Inventory.Name = "btn_Inventory";
            this.btn_Inventory.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.btn_Inventory.Size = new System.Drawing.Size(118, 75);
            this.btn_Inventory.TabIndex = 1;
            this.btn_Inventory.Text = "Inventory";
            this.btn_Inventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Inventory.UseVisualStyleBackColor = true;
            this.btn_Inventory.Click += new System.EventHandler(this.btn_Inventory_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.ForeColor = System.Drawing.Color.White;
            this.btn_Menu.Location = new System.Drawing.Point(0, 0);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.btn_Menu.Size = new System.Drawing.Size(118, 75);
            this.btn_Menu.TabIndex = 0;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.menu1);
            this.panel6.Controls.Add(this.inventory1);
            this.panel6.Controls.Add(this.reports1);
            this.panel6.Controls.Add(this.sales1);
            this.panel6.Controls.Add(this.settings1);
            this.panel6.Controls.Add(this.userAccounts1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(118, 42);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(813, 536);
            this.panel6.TabIndex = 3;
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.White;
            this.menu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(813, 536);
            this.menu1.TabIndex = 5;
            // 
            // inventory1
            // 
            this.inventory1.BackColor = System.Drawing.Color.White;
            this.inventory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventory1.Location = new System.Drawing.Point(0, 0);
            this.inventory1.Name = "inventory1";
            this.inventory1.Size = new System.Drawing.Size(813, 536);
            this.inventory1.TabIndex = 4;
            // 
            // reports1
            // 
            this.reports1.BackColor = System.Drawing.Color.White;
            this.reports1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reports1.Location = new System.Drawing.Point(0, 0);
            this.reports1.Name = "reports1";
            this.reports1.Size = new System.Drawing.Size(813, 536);
            this.reports1.TabIndex = 3;
            // 
            // sales1
            // 
            this.sales1.BackColor = System.Drawing.Color.White;
            this.sales1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sales1.Location = new System.Drawing.Point(0, 0);
            this.sales1.Name = "sales1";
            this.sales1.Size = new System.Drawing.Size(813, 536);
            this.sales1.TabIndex = 2;
            // 
            // settings1
            // 
            this.settings1.BackColor = System.Drawing.Color.White;
            this.settings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings1.Location = new System.Drawing.Point(0, 0);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(813, 536);
            this.settings1.TabIndex = 1;
            // 
            // userAccounts1
            // 
            this.userAccounts1.BackColor = System.Drawing.Color.White;
            this.userAccounts1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userAccounts1.Location = new System.Drawing.Point(0, 0);
            this.userAccounts1.Name = "userAccounts1";
            this.userAccounts1.Size = new System.Drawing.Size(813, 536);
            this.userAccounts1.TabIndex = 0;
            // 
            // UC_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 578);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UC_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Fullname;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_UserAccounts;
        private System.Windows.Forms.Button btn_Reports;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_Sales;
        private System.Windows.Forms.Button btn_Inventory;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Panel panel6;
        private UserControls.MainUserControl.Reports reports1;
        private UserControls.MainUserControl.Sales sales1;
        private UserControls.MainUserControl.Settings settings1;
        private UserControls.MainUserControl.UserAccounts userAccounts1;
        private UserControls.MainUserControl.Menu menu1;
        private UserControls.MainUserControl.Inventory inventory1;

    }
}