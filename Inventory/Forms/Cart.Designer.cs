namespace Inventory.Forms
{
    partial class Cart
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
            this.DG_Cart = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_ProductDetails = new System.Windows.Forms.Panel();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.Product_Image = new System.Windows.Forms.PictureBox();
            this.Lbl_ProductId = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.Lbl_TotalPrice = new System.Windows.Forms.Label();
            this.Lbl_SellingPrice = new System.Windows.Forms.Label();
            this.Lbl_Quantity = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Lbl_Unit = new System.Windows.Forms.Label();
            this.Lbl_Brand = new System.Windows.Forms.Label();
            this.Lbl_ProductName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_TotalPriceSummary = new System.Windows.Forms.Label();
            this.Lbl_TotalQuantity = new System.Windows.Forms.Label();
            this.Lbl_NumberOfItems = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_ContactNumber = new System.Windows.Forms.Label();
            this.Lbl_Customer_Name = new System.Windows.Forms.Label();
            this.Lbl_Customer_ID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Lbl_Address = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Btn_Add_Customer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Cart)).BeginInit();
            this.Pnl_ProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_Cart
            // 
            this.DG_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Cart.Location = new System.Drawing.Point(12, 200);
            this.DG_Cart.Name = "DG_Cart";
            this.DG_Cart.Size = new System.Drawing.Size(499, 238);
            this.DG_Cart.TabIndex = 0;
            this.DG_Cart.SelectionChanged += new System.EventHandler(this.DG_Product_Selection_Change);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cart";
            // 
            // Pnl_ProductDetails
            // 
            this.Pnl_ProductDetails.Controls.Add(this.btn_Remove);
            this.Pnl_ProductDetails.Controls.Add(this.Product_Image);
            this.Pnl_ProductDetails.Controls.Add(this.Lbl_ProductId);
            this.Pnl_ProductDetails.Controls.Add(this.label23);
            this.Pnl_ProductDetails.Controls.Add(this.btn_Edit);
            this.Pnl_ProductDetails.Controls.Add(this.Lbl_TotalPrice);
            this.Pnl_ProductDetails.Controls.Add(this.Lbl_SellingPrice);
            this.Pnl_ProductDetails.Controls.Add(this.Lbl_Quantity);
            this.Pnl_ProductDetails.Controls.Add(this.label18);
            this.Pnl_ProductDetails.Controls.Add(this.label19);
            this.Pnl_ProductDetails.Controls.Add(this.label20);
            this.Pnl_ProductDetails.Controls.Add(this.Lbl_Unit);
            this.Pnl_ProductDetails.Controls.Add(this.Lbl_Brand);
            this.Pnl_ProductDetails.Controls.Add(this.Lbl_ProductName);
            this.Pnl_ProductDetails.Controls.Add(this.label12);
            this.Pnl_ProductDetails.Controls.Add(this.label13);
            this.Pnl_ProductDetails.Controls.Add(this.label14);
            this.Pnl_ProductDetails.Location = new System.Drawing.Point(520, 62);
            this.Pnl_ProductDetails.Name = "Pnl_ProductDetails";
            this.Pnl_ProductDetails.Size = new System.Drawing.Size(210, 243);
            this.Pnl_ProductDetails.TabIndex = 2;
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Remove.FlatAppearance.BorderSize = 0;
            this.btn_Remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.ForeColor = System.Drawing.Color.White;
            this.btn_Remove.Location = new System.Drawing.Point(115, 208);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(95, 32);
            this.btn_Remove.TabIndex = 52;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // Product_Image
            // 
            this.Product_Image.Location = new System.Drawing.Point(77, 1);
            this.Product_Image.Name = "Product_Image";
            this.Product_Image.Size = new System.Drawing.Size(60, 60);
            this.Product_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Product_Image.TabIndex = 51;
            this.Product_Image.TabStop = false;
            // 
            // Lbl_ProductId
            // 
            this.Lbl_ProductId.AutoSize = true;
            this.Lbl_ProductId.Location = new System.Drawing.Point(85, 67);
            this.Lbl_ProductId.Name = "Lbl_ProductId";
            this.Lbl_ProductId.Size = new System.Drawing.Size(41, 13);
            this.Lbl_ProductId.TabIndex = 50;
            this.Lbl_ProductId.Text = "label22";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 67);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 13);
            this.label23.TabIndex = 49;
            this.label23.Text = "Product ID:";
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(6, 208);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(95, 32);
            this.btn_Edit.TabIndex = 47;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // Lbl_TotalPrice
            // 
            this.Lbl_TotalPrice.AutoSize = true;
            this.Lbl_TotalPrice.Location = new System.Drawing.Point(85, 187);
            this.Lbl_TotalPrice.Name = "Lbl_TotalPrice";
            this.Lbl_TotalPrice.Size = new System.Drawing.Size(41, 13);
            this.Lbl_TotalPrice.TabIndex = 21;
            this.Lbl_TotalPrice.Text = "label15";
            // 
            // Lbl_SellingPrice
            // 
            this.Lbl_SellingPrice.AutoSize = true;
            this.Lbl_SellingPrice.Location = new System.Drawing.Point(85, 167);
            this.Lbl_SellingPrice.Name = "Lbl_SellingPrice";
            this.Lbl_SellingPrice.Size = new System.Drawing.Size(41, 13);
            this.Lbl_SellingPrice.TabIndex = 20;
            this.Lbl_SellingPrice.Text = "label16";
            // 
            // Lbl_Quantity
            // 
            this.Lbl_Quantity.AutoSize = true;
            this.Lbl_Quantity.Location = new System.Drawing.Point(85, 147);
            this.Lbl_Quantity.Name = "Lbl_Quantity";
            this.Lbl_Quantity.Size = new System.Drawing.Size(41, 13);
            this.Lbl_Quantity.TabIndex = 19;
            this.Lbl_Quantity.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 187);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Total Price:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 167);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Price:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 147);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Quantity:";
            // 
            // Lbl_Unit
            // 
            this.Lbl_Unit.AutoSize = true;
            this.Lbl_Unit.Location = new System.Drawing.Point(85, 127);
            this.Lbl_Unit.Name = "Lbl_Unit";
            this.Lbl_Unit.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Unit.TabIndex = 15;
            this.Lbl_Unit.Text = "label9";
            // 
            // Lbl_Brand
            // 
            this.Lbl_Brand.AutoSize = true;
            this.Lbl_Brand.Location = new System.Drawing.Point(85, 107);
            this.Lbl_Brand.Name = "Lbl_Brand";
            this.Lbl_Brand.Size = new System.Drawing.Size(41, 13);
            this.Lbl_Brand.TabIndex = 14;
            this.Lbl_Brand.Text = "label10";
            // 
            // Lbl_ProductName
            // 
            this.Lbl_ProductName.AutoSize = true;
            this.Lbl_ProductName.Location = new System.Drawing.Point(85, 87);
            this.Lbl_ProductName.Name = "Lbl_ProductName";
            this.Lbl_ProductName.Size = new System.Drawing.Size(41, 13);
            this.Lbl_ProductName.TabIndex = 13;
            this.Lbl_ProductName.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Unit:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Brand:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cart Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number Of Items:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Price: ";
            // 
            // Lbl_TotalPriceSummary
            // 
            this.Lbl_TotalPriceSummary.AutoSize = true;
            this.Lbl_TotalPriceSummary.Location = new System.Drawing.Point(609, 381);
            this.Lbl_TotalPriceSummary.Name = "Lbl_TotalPriceSummary";
            this.Lbl_TotalPriceSummary.Size = new System.Drawing.Size(35, 13);
            this.Lbl_TotalPriceSummary.TabIndex = 9;
            this.Lbl_TotalPriceSummary.Text = "label6";
            // 
            // Lbl_TotalQuantity
            // 
            this.Lbl_TotalQuantity.AutoSize = true;
            this.Lbl_TotalQuantity.Location = new System.Drawing.Point(609, 361);
            this.Lbl_TotalQuantity.Name = "Lbl_TotalQuantity";
            this.Lbl_TotalQuantity.Size = new System.Drawing.Size(35, 13);
            this.Lbl_TotalQuantity.TabIndex = 8;
            this.Lbl_TotalQuantity.Text = "label7";
            // 
            // Lbl_NumberOfItems
            // 
            this.Lbl_NumberOfItems.AutoSize = true;
            this.Lbl_NumberOfItems.Location = new System.Drawing.Point(609, 341);
            this.Lbl_NumberOfItems.Name = "Lbl_NumberOfItems";
            this.Lbl_NumberOfItems.Size = new System.Drawing.Size(35, 13);
            this.Lbl_NumberOfItems.TabIndex = 7;
            this.Lbl_NumberOfItems.Text = "label8";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(635, 405);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(95, 32);
            this.btn_Save.TabIndex = 46;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(517, 41);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 16);
            this.label21.TabIndex = 48;
            this.label21.Text = "Product Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Customer Details";
            // 
            // Lbl_ContactNumber
            // 
            this.Lbl_ContactNumber.AutoSize = true;
            this.Lbl_ContactNumber.Location = new System.Drawing.Point(97, 108);
            this.Lbl_ContactNumber.Name = "Lbl_ContactNumber";
            this.Lbl_ContactNumber.Size = new System.Drawing.Size(0, 13);
            this.Lbl_ContactNumber.TabIndex = 55;
            // 
            // Lbl_Customer_Name
            // 
            this.Lbl_Customer_Name.AutoSize = true;
            this.Lbl_Customer_Name.Location = new System.Drawing.Point(97, 88);
            this.Lbl_Customer_Name.Name = "Lbl_Customer_Name";
            this.Lbl_Customer_Name.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Customer_Name.TabIndex = 54;
            // 
            // Lbl_Customer_ID
            // 
            this.Lbl_Customer_ID.AutoSize = true;
            this.Lbl_Customer_ID.Location = new System.Drawing.Point(97, 68);
            this.Lbl_Customer_ID.Name = "Lbl_Customer_ID";
            this.Lbl_Customer_ID.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Customer_ID.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Contact Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Customer Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 50;
            this.label15.Text = "Customer ID:";
            // 
            // Lbl_Address
            // 
            this.Lbl_Address.AutoSize = true;
            this.Lbl_Address.Location = new System.Drawing.Point(97, 129);
            this.Lbl_Address.Name = "Lbl_Address";
            this.Lbl_Address.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Address.TabIndex = 57;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 56;
            this.label17.Text = "Address:";
            // 
            // Btn_Add_Customer
            // 
            this.Btn_Add_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Btn_Add_Customer.FlatAppearance.BorderSize = 0;
            this.Btn_Add_Customer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.Btn_Add_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add_Customer.ForeColor = System.Drawing.Color.White;
            this.Btn_Add_Customer.Location = new System.Drawing.Point(345, 160);
            this.Btn_Add_Customer.Name = "Btn_Add_Customer";
            this.Btn_Add_Customer.Size = new System.Drawing.Size(166, 32);
            this.Btn_Add_Customer.TabIndex = 58;
            this.Btn_Add_Customer.Text = "Add Customer";
            this.Btn_Add_Customer.UseVisualStyleBackColor = false;
            this.Btn_Add_Customer.Click += new System.EventHandler(this.Btn_Add_Customer_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.Btn_Add_Customer);
            this.Controls.Add(this.Lbl_Address);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Lbl_ContactNumber);
            this.Controls.Add(this.Lbl_Customer_Name);
            this.Controls.Add(this.Lbl_Customer_ID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.Lbl_TotalPriceSummary);
            this.Controls.Add(this.Lbl_TotalQuantity);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.Lbl_NumberOfItems);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pnl_ProductDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DG_Cart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Cart)).EndInit();
            this.Pnl_ProductDetails.ResumeLayout(false);
            this.Pnl_ProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Cart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pnl_ProductDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_TotalPriceSummary;
        private System.Windows.Forms.Label Lbl_TotalQuantity;
        private System.Windows.Forms.Label Lbl_NumberOfItems;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label Lbl_ProductId;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Label Lbl_TotalPrice;
        private System.Windows.Forms.Label Lbl_SellingPrice;
        private System.Windows.Forms.Label Lbl_Quantity;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label Lbl_Unit;
        private System.Windows.Forms.Label Lbl_Brand;
        private System.Windows.Forms.Label Lbl_ProductName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox Product_Image;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_ContactNumber;
        private System.Windows.Forms.Label Lbl_Customer_Name;
        private System.Windows.Forms.Label Lbl_Customer_ID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label Lbl_Address;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button Btn_Add_Customer;
    }
}