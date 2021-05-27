namespace Inventory.Forms
{
    partial class Products
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
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.DG_Products = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductDetails = new System.Windows.Forms.Panel();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Product_Image = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Products)).BeginInit();
            this.ProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_AddProduct.FlatAppearance.BorderSize = 0;
            this.btn_AddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.btn_AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddProduct.ForeColor = System.Drawing.Color.White;
            this.btn_AddProduct.Location = new System.Drawing.Point(12, 61);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(150, 35);
            this.btn_AddProduct.TabIndex = 43;
            this.btn_AddProduct.Text = "Add Procuct";
            this.btn_AddProduct.UseVisualStyleBackColor = false;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // DG_Products
            // 
            this.DG_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Products.Location = new System.Drawing.Point(13, 102);
            this.DG_Products.Name = "DG_Products";
            this.DG_Products.Size = new System.Drawing.Size(447, 289);
            this.DG_Products.TabIndex = 35;
            this.DG_Products.SelectionChanged += new System.EventHandler(this.DG_Product_Selection_Change);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(465, 65);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(201, 24);
            this.Search.TabIndex = 34;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Search:";
            // 
            // ProductDetails
            // 
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
            this.ProductDetails.Controls.Add(this.label4);
            this.ProductDetails.Controls.Add(this.label5);
            this.ProductDetails.Controls.Add(this.label3);
            this.ProductDetails.Controls.Add(this.label2);
            this.ProductDetails.Controls.Add(this.Product_Image);
            this.ProductDetails.Location = new System.Drawing.Point(465, 102);
            this.ProductDetails.Name = "ProductDetails";
            this.ProductDetails.Size = new System.Drawing.Size(211, 289);
            this.ProductDetails.TabIndex = 44;
            this.ProductDetails.Visible = false;
            // 
            // Lbl_ProductId
            // 
            this.Lbl_ProductId.AutoSize = true;
            this.Lbl_ProductId.Location = new System.Drawing.Point(93, 96);
            this.Lbl_ProductId.Name = "Lbl_ProductId";
            this.Lbl_ProductId.Size = new System.Drawing.Size(0, 13);
            this.Lbl_ProductId.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "Product Name ID:";
            // 
            // Lbl_RemainigStocks
            // 
            this.Lbl_RemainigStocks.AutoSize = true;
            this.Lbl_RemainigStocks.Location = new System.Drawing.Point(96, 234);
            this.Lbl_RemainigStocks.Name = "Lbl_RemainigStocks";
            this.Lbl_RemainigStocks.Size = new System.Drawing.Size(0, 13);
            this.Lbl_RemainigStocks.TabIndex = 62;
            // 
            // Lbl_SellingPrice
            // 
            this.Lbl_SellingPrice.AutoSize = true;
            this.Lbl_SellingPrice.Location = new System.Drawing.Point(68, 211);
            this.Lbl_SellingPrice.Name = "Lbl_SellingPrice";
            this.Lbl_SellingPrice.Size = new System.Drawing.Size(0, 13);
            this.Lbl_SellingPrice.TabIndex = 61;
            // 
            // Lbl_PurchasedPrice
            // 
            this.Lbl_PurchasedPrice.AutoSize = true;
            this.Lbl_PurchasedPrice.Location = new System.Drawing.Point(88, 188);
            this.Lbl_PurchasedPrice.Name = "Lbl_PurchasedPrice";
            this.Lbl_PurchasedPrice.Size = new System.Drawing.Size(0, 13);
            this.Lbl_PurchasedPrice.TabIndex = 60;
            // 
            // Lbl_Unit
            // 
            this.Lbl_Unit.AutoSize = true;
            this.Lbl_Unit.Location = new System.Drawing.Point(29, 165);
            this.Lbl_Unit.Name = "Lbl_Unit";
            this.Lbl_Unit.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Unit.TabIndex = 59;
            // 
            // Lbl_Brand
            // 
            this.Lbl_Brand.AutoSize = true;
            this.Lbl_Brand.Location = new System.Drawing.Point(38, 142);
            this.Lbl_Brand.Name = "Lbl_Brand";
            this.Lbl_Brand.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Brand.TabIndex = 58;
            // 
            // Lbl_ProductName
            // 
            this.Lbl_ProductName.AutoSize = true;
            this.Lbl_ProductName.Location = new System.Drawing.Point(78, 119);
            this.Lbl_ProductName.Name = "Lbl_ProductName";
            this.Lbl_ProductName.Size = new System.Drawing.Size(0, 13);
            this.Lbl_ProductName.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Remaining Stocks:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Selling Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Purchased Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Unit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Brand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Product Name:";
            // 
            // Product_Image
            // 
            this.Product_Image.Location = new System.Drawing.Point(64, 3);
            this.Product_Image.Name = "Product_Image";
            this.Product_Image.Size = new System.Drawing.Size(80, 80);
            this.Product_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Product_Image.TabIndex = 50;
            this.Product_Image.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(268, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 31);
            this.label8.TabIndex = 45;
            this.label8.Text = "Products";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 405);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProductDetails);
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.DG_Products);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Products)).EndInit();
            this.ProductDetails.ResumeLayout(false);
            this.ProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.DataGridView DG_Products;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ProductDetails;
        private System.Windows.Forms.Label Lbl_RemainigStocks;
        private System.Windows.Forms.Label Lbl_SellingPrice;
        private System.Windows.Forms.Label Lbl_PurchasedPrice;
        private System.Windows.Forms.Label Lbl_Unit;
        private System.Windows.Forms.Label Lbl_Brand;
        private System.Windows.Forms.Label Lbl_ProductName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Product_Image;
        private System.Windows.Forms.Label Lbl_ProductId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}