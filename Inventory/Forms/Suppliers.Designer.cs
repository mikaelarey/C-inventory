namespace Inventory.Forms
{
    partial class Suppliers
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
            this.btn_AddSupplier = new System.Windows.Forms.Button();
            this.DG_Suppliers = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SupplierDetails = new System.Windows.Forms.Panel();
            this.Lbl_SupplierID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lbl_SupplierCode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_UpdateSupplier = new System.Windows.Forms.Button();
            this.Lbl_SupplierName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbl_SupplierRemarks = new System.Windows.Forms.Label();
            this.Lbl_SupplierAddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Contact = new System.Windows.Forms.Label();
            this.Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Suppliers)).BeginInit();
            this.SupplierDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AddSupplier
            // 
            this.btn_AddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_AddSupplier.FlatAppearance.BorderSize = 0;
            this.btn_AddSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.btn_AddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddSupplier.ForeColor = System.Drawing.Color.White;
            this.btn_AddSupplier.Location = new System.Drawing.Point(12, 61);
            this.btn_AddSupplier.Name = "btn_AddSupplier";
            this.btn_AddSupplier.Size = new System.Drawing.Size(150, 35);
            this.btn_AddSupplier.TabIndex = 81;
            this.btn_AddSupplier.Text = "Add New";
            this.btn_AddSupplier.UseVisualStyleBackColor = false;
            this.btn_AddSupplier.Click += new System.EventHandler(this.btn_AddSupplier_Click);
            // 
            // DG_Suppliers
            // 
            this.DG_Suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Suppliers.Location = new System.Drawing.Point(13, 102);
            this.DG_Suppliers.Name = "DG_Suppliers";
            this.DG_Suppliers.Size = new System.Drawing.Size(447, 289);
            this.DG_Suppliers.TabIndex = 80;
            this.DG_Suppliers.SelectionChanged += new System.EventHandler(this.DG_Suppliers_Selection_Change);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(465, 65);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(201, 24);
            this.Search.TabIndex = 79;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 78;
            this.label1.Text = "Search:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(498, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 94;
            this.label4.Text = "Supplier Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(263, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 31);
            this.label6.TabIndex = 95;
            this.label6.Text = "Suppliers";
            // 
            // SupplierDetails
            // 
            this.SupplierDetails.Controls.Add(this.Lbl_Contact);
            this.SupplierDetails.Controls.Add(this.Lbl);
            this.SupplierDetails.Controls.Add(this.Lbl_SupplierID);
            this.SupplierDetails.Controls.Add(this.label7);
            this.SupplierDetails.Controls.Add(this.Lbl_SupplierCode);
            this.SupplierDetails.Controls.Add(this.label5);
            this.SupplierDetails.Controls.Add(this.btn_UpdateSupplier);
            this.SupplierDetails.Controls.Add(this.Lbl_SupplierName);
            this.SupplierDetails.Controls.Add(this.label9);
            this.SupplierDetails.Controls.Add(this.Lbl_SupplierRemarks);
            this.SupplierDetails.Controls.Add(this.Lbl_SupplierAddress);
            this.SupplierDetails.Controls.Add(this.label3);
            this.SupplierDetails.Controls.Add(this.label2);
            this.SupplierDetails.Location = new System.Drawing.Point(465, 133);
            this.SupplierDetails.Name = "SupplierDetails";
            this.SupplierDetails.Size = new System.Drawing.Size(202, 258);
            this.SupplierDetails.TabIndex = 96;
            // 
            // Lbl_SupplierID
            // 
            this.Lbl_SupplierID.AutoSize = true;
            this.Lbl_SupplierID.Location = new System.Drawing.Point(59, 7);
            this.Lbl_SupplierID.Name = "Lbl_SupplierID";
            this.Lbl_SupplierID.Size = new System.Drawing.Size(27, 13);
            this.Lbl_SupplierID.TabIndex = 104;
            this.Lbl_SupplierID.Text = "asdf";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 103;
            this.label7.Text = "Supplier ID:";
            // 
            // Lbl_SupplierCode
            // 
            this.Lbl_SupplierCode.AutoSize = true;
            this.Lbl_SupplierCode.Location = new System.Drawing.Point(32, 50);
            this.Lbl_SupplierCode.Name = "Lbl_SupplierCode";
            this.Lbl_SupplierCode.Size = new System.Drawing.Size(27, 13);
            this.Lbl_SupplierCode.TabIndex = 102;
            this.Lbl_SupplierCode.Text = "asdf";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 101;
            this.label5.Text = "Code:";
            // 
            // btn_UpdateSupplier
            // 
            this.btn_UpdateSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_UpdateSupplier.FlatAppearance.BorderSize = 0;
            this.btn_UpdateSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.btn_UpdateSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateSupplier.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateSupplier.Location = new System.Drawing.Point(31, 219);
            this.btn_UpdateSupplier.Name = "btn_UpdateSupplier";
            this.btn_UpdateSupplier.Size = new System.Drawing.Size(150, 35);
            this.btn_UpdateSupplier.TabIndex = 100;
            this.btn_UpdateSupplier.Text = "Update";
            this.btn_UpdateSupplier.UseVisualStyleBackColor = false;
            this.btn_UpdateSupplier.Click += new System.EventHandler(this.btn_UpdateSupplier_Click);
            // 
            // Lbl_SupplierName
            // 
            this.Lbl_SupplierName.AutoSize = true;
            this.Lbl_SupplierName.Location = new System.Drawing.Point(76, 29);
            this.Lbl_SupplierName.Name = "Lbl_SupplierName";
            this.Lbl_SupplierName.Size = new System.Drawing.Size(27, 13);
            this.Lbl_SupplierName.TabIndex = 99;
            this.Lbl_SupplierName.Text = "asdf";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-1, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 98;
            this.label9.Text = "Supplier Name:";
            // 
            // Lbl_SupplierRemarks
            // 
            this.Lbl_SupplierRemarks.AutoSize = true;
            this.Lbl_SupplierRemarks.Location = new System.Drawing.Point(49, 93);
            this.Lbl_SupplierRemarks.Name = "Lbl_SupplierRemarks";
            this.Lbl_SupplierRemarks.Size = new System.Drawing.Size(27, 13);
            this.Lbl_SupplierRemarks.TabIndex = 97;
            this.Lbl_SupplierRemarks.Text = "asdf";
            // 
            // Lbl_SupplierAddress
            // 
            this.Lbl_SupplierAddress.AutoSize = true;
            this.Lbl_SupplierAddress.Location = new System.Drawing.Point(45, 70);
            this.Lbl_SupplierAddress.Name = "Lbl_SupplierAddress";
            this.Lbl_SupplierAddress.Size = new System.Drawing.Size(27, 13);
            this.Lbl_SupplierAddress.TabIndex = 96;
            this.Lbl_SupplierAddress.Text = "asdf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 95;
            this.label3.Text = "Remarks:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "Address:";
            // 
            // Lbl_Contact
            // 
            this.Lbl_Contact.AutoSize = true;
            this.Lbl_Contact.Location = new System.Drawing.Point(45, 115);
            this.Lbl_Contact.Name = "Lbl_Contact";
            this.Lbl_Contact.Size = new System.Drawing.Size(27, 13);
            this.Lbl_Contact.TabIndex = 106;
            this.Lbl_Contact.Text = "asdf";
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(0, 115);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(47, 13);
            this.Lbl.TabIndex = 105;
            this.Lbl.Text = "Contact:";
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 405);
            this.Controls.Add(this.SupplierDetails);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_AddSupplier);
            this.Controls.Add(this.DG_Suppliers);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Suppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Suppliers)).EndInit();
            this.SupplierDetails.ResumeLayout(false);
            this.SupplierDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddSupplier;
        private System.Windows.Forms.DataGridView DG_Suppliers;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel SupplierDetails;
        private System.Windows.Forms.Label Lbl_SupplierID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lbl_SupplierCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_UpdateSupplier;
        private System.Windows.Forms.Label Lbl_SupplierName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lbl_SupplierRemarks;
        private System.Windows.Forms.Label Lbl_SupplierAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Contact;
        private System.Windows.Forms.Label Lbl;
    }
}