namespace Inventory.Forms.AppSettings
{
    partial class AppSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminAccount1 = new Inventory.Forms.AppSettings.UserControls.AdminAccount();
            this.adminInfo1 = new Inventory.Forms.AppSettings.UserControls.AdminInfo();
            this.database1 = new Inventory.Forms.AppSettings.UserControls.Database();
            this.connectionString1 = new Inventory.Forms.AppSettings.UserControls.ConnectionString();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 326);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 180);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management\r\nSystem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminAccount1
            // 
            this.adminAccount1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminAccount1.Location = new System.Drawing.Point(320, 0);
            this.adminAccount1.Name = "adminAccount1";
            this.adminAccount1.Size = new System.Drawing.Size(319, 326);
            this.adminAccount1.TabIndex = 3;
            // 
            // adminInfo1
            // 
            this.adminInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminInfo1.Location = new System.Drawing.Point(320, 0);
            this.adminInfo1.Name = "adminInfo1";
            this.adminInfo1.Size = new System.Drawing.Size(319, 326);
            this.adminInfo1.TabIndex = 2;
            // 
            // database1
            // 
            this.database1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.database1.Location = new System.Drawing.Point(320, 0);
            this.database1.Name = "database1";
            this.database1.Size = new System.Drawing.Size(319, 326);
            this.database1.TabIndex = 1;
            // 
            // connectionString1
            // 
            this.connectionString1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionString1.Location = new System.Drawing.Point(320, 0);
            this.connectionString1.Name = "connectionString1";
            this.connectionString1.Size = new System.Drawing.Size(319, 326);
            this.connectionString1.TabIndex = 0;
            // 
            // AppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 326);
            this.Controls.Add(this.adminAccount1);
            this.Controls.Add(this.adminInfo1);
            this.Controls.Add(this.database1);
            this.Controls.Add(this.connectionString1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Settings";
            this.Load += new System.EventHandler(this.AppSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UserControls.ConnectionString connectionString1;
        private UserControls.Database database1;
        private UserControls.AdminAccount adminAccount1;
        private UserControls.AdminInfo adminInfo1;
    }
}