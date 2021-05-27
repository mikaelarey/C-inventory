namespace Inventory.Forms
{
    partial class Customer
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
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.DG_Customers = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_CustomerId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lbl_LastName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_UpdateCustomer = new System.Windows.Forms.Button();
            this.Lbl_FirstName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbl_Address = new System.Windows.Forms.Label();
            this.Lbl_Contact = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Profile_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Customers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_AddCustomer.FlatAppearance.BorderSize = 0;
            this.btn_AddCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.btn_AddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_AddCustomer.Location = new System.Drawing.Point(7, 64);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(150, 35);
            this.btn_AddCustomer.TabIndex = 48;
            this.btn_AddCustomer.Text = "Add New";
            this.btn_AddCustomer.UseVisualStyleBackColor = false;
            this.btn_AddCustomer.Click += new System.EventHandler(this.btn_AddCustomer_Click);
            // 
            // DG_Customers
            // 
            this.DG_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Customers.Location = new System.Drawing.Point(8, 105);
            this.DG_Customers.Name = "DG_Customers";
            this.DG_Customers.Size = new System.Drawing.Size(447, 289);
            this.DG_Customers.TabIndex = 47;
            this.DG_Customers.SelectionChanged += new System.EventHandler(this.DG_Customers_Selection_Change);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(460, 68);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(201, 24);
            this.Search.TabIndex = 46;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "Search:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 31);
            this.label4.TabIndex = 78;
            this.label4.Text = "Customers";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lbl_CustomerId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Lbl_LastName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_UpdateCustomer);
            this.panel1.Controls.Add(this.Lbl_FirstName);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Lbl_Address);
            this.panel1.Controls.Add(this.Lbl_Contact);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Profile_Image);
            this.panel1.Location = new System.Drawing.Point(460, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 289);
            this.panel1.TabIndex = 79;
            // 
            // Lbl_CustomerId
            // 
            this.Lbl_CustomerId.AutoSize = true;
            this.Lbl_CustomerId.Location = new System.Drawing.Point(66, 94);
            this.Lbl_CustomerId.Name = "Lbl_CustomerId";
            this.Lbl_CustomerId.Size = new System.Drawing.Size(0, 13);
            this.Lbl_CustomerId.TabIndex = 89;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 88;
            this.label7.Text = "Customer ID:";
            // 
            // Lbl_LastName
            // 
            this.Lbl_LastName.AutoSize = true;
            this.Lbl_LastName.Location = new System.Drawing.Point(59, 137);
            this.Lbl_LastName.Name = "Lbl_LastName";
            this.Lbl_LastName.Size = new System.Drawing.Size(0, 13);
            this.Lbl_LastName.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "Last Name:";
            // 
            // btn_UpdateCustomer
            // 
            this.btn_UpdateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_UpdateCustomer.FlatAppearance.BorderSize = 0;
            this.btn_UpdateCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.btn_UpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateCustomer.Location = new System.Drawing.Point(32, 253);
            this.btn_UpdateCustomer.Name = "btn_UpdateCustomer";
            this.btn_UpdateCustomer.Size = new System.Drawing.Size(150, 35);
            this.btn_UpdateCustomer.TabIndex = 85;
            this.btn_UpdateCustomer.Text = "Update";
            this.btn_UpdateCustomer.UseVisualStyleBackColor = false;
            this.btn_UpdateCustomer.Click += new System.EventHandler(this.btn_UpdateCustomer_Click);
            // 
            // Lbl_FirstName
            // 
            this.Lbl_FirstName.AutoSize = true;
            this.Lbl_FirstName.Location = new System.Drawing.Point(58, 116);
            this.Lbl_FirstName.Name = "Lbl_FirstName";
            this.Lbl_FirstName.Size = new System.Drawing.Size(0, 13);
            this.Lbl_FirstName.TabIndex = 84;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "First Name:";
            // 
            // Lbl_Address
            // 
            this.Lbl_Address.AutoSize = true;
            this.Lbl_Address.Location = new System.Drawing.Point(47, 180);
            this.Lbl_Address.Name = "Lbl_Address";
            this.Lbl_Address.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Address.TabIndex = 82;
            // 
            // Lbl_Contact
            // 
            this.Lbl_Contact.AutoSize = true;
            this.Lbl_Contact.Location = new System.Drawing.Point(45, 157);
            this.Lbl_Contact.Name = "Lbl_Contact";
            this.Lbl_Contact.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Contact.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Contact:";
            // 
            // Profile_Image
            // 
            this.Profile_Image.Location = new System.Drawing.Point(66, 0);
            this.Profile_Image.Name = "Profile_Image";
            this.Profile_Image.Size = new System.Drawing.Size(80, 80);
            this.Profile_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Profile_Image.TabIndex = 78;
            this.Profile_Image.TabStop = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 405);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_AddCustomer);
            this.Controls.Add(this.DG_Customers);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Customers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddCustomer;
        private System.Windows.Forms.DataGridView DG_Customers;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_CustomerId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lbl_LastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_UpdateCustomer;
        private System.Windows.Forms.Label Lbl_FirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lbl_Address;
        private System.Windows.Forms.Label Lbl_Contact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Profile_Image;
    }
}