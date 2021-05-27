namespace Inventory.Forms.UserControls.Main
{
    partial class Inventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DG_Products = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ViewCart = new System.Windows.Forms.Button();
            this.ProductDetails = new System.Windows.Forms.Panel();
            this.Lbl_AlreadyAddedToCart = new System.Windows.Forms.Label();
            this.Lbl_NoStocksAvailable = new System.Windows.Forms.Label();
            this.TB_Quantity = new System.Windows.Forms.TextBox();
            this.Lbl_Quantity = new System.Windows.Forms.Label();
            this.btn_AddToCart = new System.Windows.Forms.Button();
            this.Lbl_ProductId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbl_RemainigStocks = new System.Windows.Forms.Label();
            this.Lbl_SellingPrice = new System.Windows.Forms.Label();
            this.Lbl_PurchasedPrice = new System.Windows.Forms.Label();
            this.Lbl_Unit = new System.Windows.Forms.Label();
            this.Lbl_Brand = new System.Windows.Forms.Label();
            this.Lbl_ProductName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Product_Image = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Products)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Refresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 55);
            this.panel1.TabIndex = 2;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(21, 16);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(129, 32);
            this.btn_Refresh.TabIndex = 45;
            this.btn_Refresh.Text = "Reload Data";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20, 0, 10, 20);
            this.panel3.Size = new System.Drawing.Size(495, 399);
            this.panel3.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DG_Products);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(20, 35);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(465, 344);
            this.panel6.TabIndex = 3;
            // 
            // DG_Products
            // 
            this.DG_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_Products.Location = new System.Drawing.Point(0, 0);
            this.DG_Products.Name = "DG_Products";
            this.DG_Products.Size = new System.Drawing.Size(465, 344);
            this.DG_Products.TabIndex = 0;
            this.DG_Products.SelectionChanged += new System.EventHandler(this.DG_Product_Selection_Change);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(20, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(465, 35);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Products Lists";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(270, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 24);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ViewCart);
            this.panel2.Controls.Add(this.ProductDetails);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(495, 55);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 20);
            this.panel2.Size = new System.Drawing.Size(225, 399);
            this.panel2.TabIndex = 5;
            // 
            // btn_ViewCart
            // 
            this.btn_ViewCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_ViewCart.FlatAppearance.BorderSize = 0;
            this.btn_ViewCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.btn_ViewCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewCart.ForeColor = System.Drawing.Color.White;
            this.btn_ViewCart.Location = new System.Drawing.Point(13, 344);
            this.btn_ViewCart.Name = "btn_ViewCart";
            this.btn_ViewCart.Size = new System.Drawing.Size(192, 35);
            this.btn_ViewCart.TabIndex = 44;
            this.btn_ViewCart.Text = "View Cart";
            this.btn_ViewCart.UseVisualStyleBackColor = false;
            this.btn_ViewCart.Click += new System.EventHandler(this.btn_ViewCart_Click);
            // 
            // ProductDetails
            // 
            this.ProductDetails.Controls.Add(this.Lbl_AlreadyAddedToCart);
            this.ProductDetails.Controls.Add(this.Lbl_NoStocksAvailable);
            this.ProductDetails.Controls.Add(this.TB_Quantity);
            this.ProductDetails.Controls.Add(this.Lbl_Quantity);
            this.ProductDetails.Controls.Add(this.btn_AddToCart);
            this.ProductDetails.Controls.Add(this.Lbl_ProductId);
            this.ProductDetails.Controls.Add(this.label9);
            this.ProductDetails.Controls.Add(this.Lbl_RemainigStocks);
            this.ProductDetails.Controls.Add(this.Lbl_SellingPrice);
            this.ProductDetails.Controls.Add(this.Lbl_PurchasedPrice);
            this.ProductDetails.Controls.Add(this.Lbl_Unit);
            this.ProductDetails.Controls.Add(this.Lbl_Brand);
            this.ProductDetails.Controls.Add(this.Lbl_ProductName);
            this.ProductDetails.Controls.Add(this.label6);
            this.ProductDetails.Controls.Add(this.label7);
            this.ProductDetails.Controls.Add(this.label5);
            this.ProductDetails.Controls.Add(this.label8);
            this.ProductDetails.Controls.Add(this.label10);
            this.ProductDetails.Controls.Add(this.label11);
            this.ProductDetails.Controls.Add(this.Product_Image);
            this.ProductDetails.Controls.Add(this.label4);
            this.ProductDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductDetails.Location = new System.Drawing.Point(10, 0);
            this.ProductDetails.Name = "ProductDetails";
            this.ProductDetails.Size = new System.Drawing.Size(195, 329);
            this.ProductDetails.TabIndex = 9;
            // 
            // Lbl_AlreadyAddedToCart
            // 
            this.Lbl_AlreadyAddedToCart.AutoSize = true;
            this.Lbl_AlreadyAddedToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AlreadyAddedToCart.Location = new System.Drawing.Point(10, 263);
            this.Lbl_AlreadyAddedToCart.Name = "Lbl_AlreadyAddedToCart";
            this.Lbl_AlreadyAddedToCart.Size = new System.Drawing.Size(176, 18);
            this.Lbl_AlreadyAddedToCart.TabIndex = 84;
            this.Lbl_AlreadyAddedToCart.Text = "Already Added To Cart\r\n";
            // 
            // Lbl_NoStocksAvailable
            // 
            this.Lbl_NoStocksAvailable.AutoSize = true;
            this.Lbl_NoStocksAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NoStocksAvailable.Location = new System.Drawing.Point(18, 263);
            this.Lbl_NoStocksAvailable.Name = "Lbl_NoStocksAvailable";
            this.Lbl_NoStocksAvailable.Size = new System.Drawing.Size(159, 18);
            this.Lbl_NoStocksAvailable.TabIndex = 83;
            this.Lbl_NoStocksAvailable.Text = "No Stocks Available";
            // 
            // TB_Quantity
            // 
            this.TB_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Quantity.Location = new System.Drawing.Point(52, 252);
            this.TB_Quantity.Name = "TB_Quantity";
            this.TB_Quantity.Size = new System.Drawing.Size(143, 21);
            this.TB_Quantity.TabIndex = 82;
            // 
            // Lbl_Quantity
            // 
            this.Lbl_Quantity.AutoSize = true;
            this.Lbl_Quantity.Location = new System.Drawing.Point(0, 255);
            this.Lbl_Quantity.Name = "Lbl_Quantity";
            this.Lbl_Quantity.Size = new System.Drawing.Size(49, 13);
            this.Lbl_Quantity.TabIndex = 81;
            this.Lbl_Quantity.Text = "Quantity:";
            // 
            // btn_AddToCart
            // 
            this.btn_AddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_AddToCart.FlatAppearance.BorderSize = 0;
            this.btn_AddToCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.btn_AddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddToCart.ForeColor = System.Drawing.Color.White;
            this.btn_AddToCart.Location = new System.Drawing.Point(3, 279);
            this.btn_AddToCart.Name = "btn_AddToCart";
            this.btn_AddToCart.Size = new System.Drawing.Size(192, 35);
            this.btn_AddToCart.TabIndex = 80;
            this.btn_AddToCart.Text = "Add To Cart";
            this.btn_AddToCart.UseVisualStyleBackColor = false;
            this.btn_AddToCart.Click += new System.EventHandler(this.btn_AddToCart_Click);
            // 
            // Lbl_ProductId
            // 
            this.Lbl_ProductId.AutoSize = true;
            this.Lbl_ProductId.Location = new System.Drawing.Point(89, 121);
            this.Lbl_ProductId.Name = "Lbl_ProductId";
            this.Lbl_ProductId.Size = new System.Drawing.Size(0, 13);
            this.Lbl_ProductId.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-2, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "Product Name ID:";
            // 
            // Lbl_RemainigStocks
            // 
            this.Lbl_RemainigStocks.AutoSize = true;
            this.Lbl_RemainigStocks.Location = new System.Drawing.Point(92, 232);
            this.Lbl_RemainigStocks.Name = "Lbl_RemainigStocks";
            this.Lbl_RemainigStocks.Size = new System.Drawing.Size(0, 13);
            this.Lbl_RemainigStocks.TabIndex = 77;
            // 
            // Lbl_SellingPrice
            // 
            this.Lbl_SellingPrice.AutoSize = true;
            this.Lbl_SellingPrice.Location = new System.Drawing.Point(64, 213);
            this.Lbl_SellingPrice.Name = "Lbl_SellingPrice";
            this.Lbl_SellingPrice.Size = new System.Drawing.Size(0, 13);
            this.Lbl_SellingPrice.TabIndex = 76;
            // 
            // Lbl_PurchasedPrice
            // 
            this.Lbl_PurchasedPrice.AutoSize = true;
            this.Lbl_PurchasedPrice.Location = new System.Drawing.Point(84, 194);
            this.Lbl_PurchasedPrice.Name = "Lbl_PurchasedPrice";
            this.Lbl_PurchasedPrice.Size = new System.Drawing.Size(0, 13);
            this.Lbl_PurchasedPrice.TabIndex = 75;
            // 
            // Lbl_Unit
            // 
            this.Lbl_Unit.AutoSize = true;
            this.Lbl_Unit.Location = new System.Drawing.Point(25, 176);
            this.Lbl_Unit.Name = "Lbl_Unit";
            this.Lbl_Unit.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Unit.TabIndex = 74;
            // 
            // Lbl_Brand
            // 
            this.Lbl_Brand.AutoSize = true;
            this.Lbl_Brand.Location = new System.Drawing.Point(34, 158);
            this.Lbl_Brand.Name = "Lbl_Brand";
            this.Lbl_Brand.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Brand.TabIndex = 73;
            // 
            // Lbl_ProductName
            // 
            this.Lbl_ProductName.AutoSize = true;
            this.Lbl_ProductName.Location = new System.Drawing.Point(74, 140);
            this.Lbl_ProductName.Name = "Lbl_ProductName";
            this.Lbl_ProductName.Size = new System.Drawing.Size(0, 13);
            this.Lbl_ProductName.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "Remaining Stocks:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-2, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Selling Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Purchased Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-2, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Unit:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-2, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "Brand:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-2, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "Product Name:";
            // 
            // Product_Image
            // 
            this.Product_Image.Location = new System.Drawing.Point(66, 53);
            this.Product_Image.Name = "Product_Image";
            this.Product_Image.Size = new System.Drawing.Size(61, 53);
            this.Product_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Product_Image.TabIndex = 65;
            this.Product_Image.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Product Details";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(720, 454);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Products)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ProductDetails.ResumeLayout(false);
            this.ProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView DG_Products;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel ProductDetails;
        private System.Windows.Forms.Label Lbl_ProductId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lbl_RemainigStocks;
        private System.Windows.Forms.Label Lbl_SellingPrice;
        private System.Windows.Forms.Label Lbl_PurchasedPrice;
        private System.Windows.Forms.Label Lbl_Unit;
        private System.Windows.Forms.Label Lbl_Brand;
        private System.Windows.Forms.Label Lbl_ProductName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox Product_Image;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ViewCart;
        private System.Windows.Forms.Button btn_AddToCart;
        private System.Windows.Forms.TextBox TB_Quantity;
        private System.Windows.Forms.Label Lbl_Quantity;
        private System.Windows.Forms.Label Lbl_AlreadyAddedToCart;
        private System.Windows.Forms.Label Lbl_NoStocksAvailable;
        private System.Windows.Forms.Button btn_Refresh;

    }
}
