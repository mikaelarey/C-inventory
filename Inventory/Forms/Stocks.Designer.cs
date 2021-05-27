namespace Inventory.Forms
{
    partial class Stocks
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
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.DG_Stocks = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.StockDetails = new System.Windows.Forms.Panel();
            this.Lbl_ProductId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbl_RemainingStocks = new System.Windows.Forms.Label();
            this.Lbl_SellingPrice = new System.Windows.Forms.Label();
            this.Lbl_PurchasedPrice = new System.Windows.Forms.Label();
            this.Lbl_Unit = new System.Windows.Forms.Label();
            this.Lbl_Brand = new System.Windows.Forms.Label();
            this.Lbl_ProductName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Product_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Stocks)).BeginInit();
            this.StockDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(465, 66);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(201, 24);
            this.Search.TabIndex = 1;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // DG_Stocks
            // 
            this.DG_Stocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Stocks.Location = new System.Drawing.Point(13, 103);
            this.DG_Stocks.Name = "DG_Stocks";
            this.DG_Stocks.Size = new System.Drawing.Size(447, 289);
            this.DG_Stocks.TabIndex = 2;
            this.DG_Stocks.SelectionChanged += new System.EventHandler(this.DG_Stocks_Selection_Change);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(284, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 31);
            this.label8.TabIndex = 35;
            this.label8.Text = "Stocks";
            // 
            // StockDetails
            // 
            this.StockDetails.Controls.Add(this.Lbl_ProductId);
            this.StockDetails.Controls.Add(this.label9);
            this.StockDetails.Controls.Add(this.Lbl_RemainingStocks);
            this.StockDetails.Controls.Add(this.Lbl_SellingPrice);
            this.StockDetails.Controls.Add(this.Lbl_PurchasedPrice);
            this.StockDetails.Controls.Add(this.Lbl_Unit);
            this.StockDetails.Controls.Add(this.Lbl_Brand);
            this.StockDetails.Controls.Add(this.Lbl_ProductName);
            this.StockDetails.Controls.Add(this.button1);
            this.StockDetails.Controls.Add(this.label6);
            this.StockDetails.Controls.Add(this.label7);
            this.StockDetails.Controls.Add(this.label4);
            this.StockDetails.Controls.Add(this.label5);
            this.StockDetails.Controls.Add(this.label3);
            this.StockDetails.Controls.Add(this.label2);
            this.StockDetails.Controls.Add(this.Product_Image);
            this.StockDetails.Location = new System.Drawing.Point(465, 103);
            this.StockDetails.Name = "StockDetails";
            this.StockDetails.Size = new System.Drawing.Size(210, 289);
            this.StockDetails.TabIndex = 36;
            // 
            // Lbl_ProductId
            // 
            this.Lbl_ProductId.AutoSize = true;
            this.Lbl_ProductId.Location = new System.Drawing.Point(59, 91);
            this.Lbl_ProductId.Name = "Lbl_ProductId";
            this.Lbl_ProductId.Size = new System.Drawing.Size(0, 13);
            this.Lbl_ProductId.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Product Id:";
            // 
            // Lbl_RemainingStocks
            // 
            this.Lbl_RemainingStocks.AutoSize = true;
            this.Lbl_RemainingStocks.Location = new System.Drawing.Point(96, 228);
            this.Lbl_RemainingStocks.Name = "Lbl_RemainingStocks";
            this.Lbl_RemainingStocks.Size = new System.Drawing.Size(0, 13);
            this.Lbl_RemainingStocks.TabIndex = 48;
            // 
            // Lbl_SellingPrice
            // 
            this.Lbl_SellingPrice.AutoSize = true;
            this.Lbl_SellingPrice.Location = new System.Drawing.Point(68, 205);
            this.Lbl_SellingPrice.Name = "Lbl_SellingPrice";
            this.Lbl_SellingPrice.Size = new System.Drawing.Size(0, 13);
            this.Lbl_SellingPrice.TabIndex = 47;
            // 
            // Lbl_PurchasedPrice
            // 
            this.Lbl_PurchasedPrice.AutoSize = true;
            this.Lbl_PurchasedPrice.Location = new System.Drawing.Point(88, 182);
            this.Lbl_PurchasedPrice.Name = "Lbl_PurchasedPrice";
            this.Lbl_PurchasedPrice.Size = new System.Drawing.Size(0, 13);
            this.Lbl_PurchasedPrice.TabIndex = 46;
            // 
            // Lbl_Unit
            // 
            this.Lbl_Unit.AutoSize = true;
            this.Lbl_Unit.Location = new System.Drawing.Point(29, 159);
            this.Lbl_Unit.Name = "Lbl_Unit";
            this.Lbl_Unit.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Unit.TabIndex = 45;
            // 
            // Lbl_Brand
            // 
            this.Lbl_Brand.AutoSize = true;
            this.Lbl_Brand.Location = new System.Drawing.Point(38, 136);
            this.Lbl_Brand.Name = "Lbl_Brand";
            this.Lbl_Brand.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Brand.TabIndex = 44;
            // 
            // Lbl_ProductName
            // 
            this.Lbl_ProductName.AutoSize = true;
            this.Lbl_ProductName.Location = new System.Drawing.Point(78, 113);
            this.Lbl_ProductName.Name = "Lbl_ProductName";
            this.Lbl_ProductName.Size = new System.Drawing.Size(0, 13);
            this.Lbl_ProductName.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(32, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 35);
            this.button1.TabIndex = 42;
            this.button1.Text = "Add Stock";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Remaining Stocks:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Selling Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Purchased Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Unit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Brand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Product Name:";
            // 
            // Product_Image
            // 
            this.Product_Image.Location = new System.Drawing.Point(64, 3);
            this.Product_Image.Name = "Product_Image";
            this.Product_Image.Size = new System.Drawing.Size(80, 80);
            this.Product_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Product_Image.TabIndex = 35;
            this.Product_Image.TabStop = false;
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 405);
            this.Controls.Add(this.StockDetails);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DG_Stocks);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Stocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.Stocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Stocks)).EndInit();
            this.StockDetails.ResumeLayout(false);
            this.StockDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.DataGridView DG_Stocks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel StockDetails;
        private System.Windows.Forms.Label Lbl_ProductId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lbl_RemainingStocks;
        private System.Windows.Forms.Label Lbl_SellingPrice;
        private System.Windows.Forms.Label Lbl_PurchasedPrice;
        private System.Windows.Forms.Label Lbl_Unit;
        private System.Windows.Forms.Label Lbl_Brand;
        private System.Windows.Forms.Label Lbl_ProductName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Product_Image;
    }
}