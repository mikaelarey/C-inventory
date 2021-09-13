namespace Inventory.Forms.UserControls.MainUserControl
{
    partial class Sales
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
            this.Use_Filter = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Date_Filter = new System.Windows.Forms.DateTimePicker();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProductDetails = new System.Windows.Forms.Panel();
            this.OrderDetails = new System.Windows.Forms.Panel();
            this.Lbl_CancelledOrder = new System.Windows.Forms.Label();
            this.Lbl_ProcessCompleted = new System.Windows.Forms.Label();
            this.btn_OrderRecieved = new System.Windows.Forms.Button();
            this.btn_CancelOrder = new System.Windows.Forms.Button();
            this.btn_Checkout = new System.Windows.Forms.Button();
            this.Lbl_OrderStatus = new System.Windows.Forms.Label();
            this.Lbl_Address = new System.Windows.Forms.Label();
            this.Lbl_ContactNumber = new System.Windows.Forms.Label();
            this.Lbl_CustomerName = new System.Windows.Forms.Label();
            this.Lbl_TotalPrice = new System.Windows.Forms.Label();
            this.Lbl_NumberOfItems = new System.Windows.Forms.Label();
            this.Lbl_NumberOfProducts = new System.Windows.Forms.Label();
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerImage = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Lbl_OrderStatusId = new System.Windows.Forms.Label();
            this.Lbl_OrderID = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DG_Products = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.DG_OrderDetails = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ProductDetails.SuspendLayout();
            this.OrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerImage)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Products)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_OrderDetails)).BeginInit();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Use_Filter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 55);
            this.panel1.TabIndex = 3;
            // 
            // Use_Filter
            // 
            this.Use_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Use_Filter.AutoSize = true;
            this.Use_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Use_Filter.Location = new System.Drawing.Point(603, 33);
            this.Use_Filter.Name = "Use_Filter";
            this.Use_Filter.Size = new System.Drawing.Size(101, 19);
            this.Use_Filter.TabIndex = 1;
            this.Use_Filter.Text = "Use date filter";
            this.Use_Filter.UseVisualStyleBackColor = true;
            this.Use_Filter.CheckedChanged += new System.EventHandler(this.Search_And_Filter);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-2, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 18);
            this.label9.TabIndex = 83;
            this.label9.Text = "Filter";
            // 
            // Date_Filter
            // 
            this.Date_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Date_Filter.CustomFormat = "ddd dd MMM yyyy";
            this.Date_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Filter.Location = new System.Drawing.Point(44, 5);
            this.Date_Filter.Name = "Date_Filter";
            this.Date_Filter.Size = new System.Drawing.Size(178, 24);
            this.Date_Filter.TabIndex = 1;
            this.Date_Filter.ValueChanged += new System.EventHandler(this.Search_And_Filter);
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
            this.btn_Refresh.TabIndex = 48;
            this.btn_Refresh.Text = "Reload Data";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProductDetails);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(468, 55);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 20);
            this.panel2.Size = new System.Drawing.Size(252, 421);
            this.panel2.TabIndex = 46;
            // 
            // ProductDetails
            // 
            this.ProductDetails.Controls.Add(this.OrderDetails);
            this.ProductDetails.Controls.Add(this.panel7);
            this.ProductDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductDetails.Location = new System.Drawing.Point(10, 0);
            this.ProductDetails.Name = "ProductDetails";
            this.ProductDetails.Size = new System.Drawing.Size(222, 401);
            this.ProductDetails.TabIndex = 9;
            // 
            // OrderDetails
            // 
            this.OrderDetails.Controls.Add(this.Lbl_CancelledOrder);
            this.OrderDetails.Controls.Add(this.Lbl_ProcessCompleted);
            this.OrderDetails.Controls.Add(this.btn_OrderRecieved);
            this.OrderDetails.Controls.Add(this.btn_CancelOrder);
            this.OrderDetails.Controls.Add(this.btn_Checkout);
            this.OrderDetails.Controls.Add(this.Lbl_OrderStatus);
            this.OrderDetails.Controls.Add(this.Lbl_Address);
            this.OrderDetails.Controls.Add(this.Lbl_ContactNumber);
            this.OrderDetails.Controls.Add(this.Lbl_CustomerName);
            this.OrderDetails.Controls.Add(this.Lbl_TotalPrice);
            this.OrderDetails.Controls.Add(this.Lbl_NumberOfItems);
            this.OrderDetails.Controls.Add(this.Lbl_NumberOfProducts);
            this.OrderDetails.Controls.Add(this.Lbl_Date);
            this.OrderDetails.Controls.Add(this.label10);
            this.OrderDetails.Controls.Add(this.label11);
            this.OrderDetails.Controls.Add(this.label12);
            this.OrderDetails.Controls.Add(this.label13);
            this.OrderDetails.Controls.Add(this.label8);
            this.OrderDetails.Controls.Add(this.label7);
            this.OrderDetails.Controls.Add(this.label6);
            this.OrderDetails.Controls.Add(this.label5);
            this.OrderDetails.Controls.Add(this.CustomerImage);
            this.OrderDetails.Controls.Add(this.label4);
            this.OrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDetails.Location = new System.Drawing.Point(0, 52);
            this.OrderDetails.Name = "OrderDetails";
            this.OrderDetails.Size = new System.Drawing.Size(222, 349);
            this.OrderDetails.TabIndex = 85;
            // 
            // Lbl_CancelledOrder
            // 
            this.Lbl_CancelledOrder.AutoSize = true;
            this.Lbl_CancelledOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CancelledOrder.Location = new System.Drawing.Point(50, 295);
            this.Lbl_CancelledOrder.Name = "Lbl_CancelledOrder";
            this.Lbl_CancelledOrder.Size = new System.Drawing.Size(130, 18);
            this.Lbl_CancelledOrder.TabIndex = 109;
            this.Lbl_CancelledOrder.Text = "Order Cancelled";
            // 
            // Lbl_ProcessCompleted
            // 
            this.Lbl_ProcessCompleted.AutoSize = true;
            this.Lbl_ProcessCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ProcessCompleted.Location = new System.Drawing.Point(35, 295);
            this.Lbl_ProcessCompleted.Name = "Lbl_ProcessCompleted";
            this.Lbl_ProcessCompleted.Size = new System.Drawing.Size(157, 18);
            this.Lbl_ProcessCompleted.TabIndex = 89;
            this.Lbl_ProcessCompleted.Text = "Process Completed";
            // 
            // btn_OrderRecieved
            // 
            this.btn_OrderRecieved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_OrderRecieved.FlatAppearance.BorderSize = 0;
            this.btn_OrderRecieved.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.btn_OrderRecieved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OrderRecieved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrderRecieved.ForeColor = System.Drawing.Color.White;
            this.btn_OrderRecieved.Location = new System.Drawing.Point(44, 288);
            this.btn_OrderRecieved.Name = "btn_OrderRecieved";
            this.btn_OrderRecieved.Size = new System.Drawing.Size(129, 32);
            this.btn_OrderRecieved.TabIndex = 49;
            this.btn_OrderRecieved.Text = "Order Recieved";
            this.btn_OrderRecieved.UseVisualStyleBackColor = false;
            this.btn_OrderRecieved.Click += new System.EventHandler(this.btn_OrderRecieved_Click);
            // 
            // btn_CancelOrder
            // 
            this.btn_CancelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_CancelOrder.FlatAppearance.BorderSize = 0;
            this.btn_CancelOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_CancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelOrder.ForeColor = System.Drawing.Color.White;
            this.btn_CancelOrder.Location = new System.Drawing.Point(114, 288);
            this.btn_CancelOrder.Name = "btn_CancelOrder";
            this.btn_CancelOrder.Size = new System.Drawing.Size(105, 32);
            this.btn_CancelOrder.TabIndex = 108;
            this.btn_CancelOrder.Text = "Cancel Order";
            this.btn_CancelOrder.UseVisualStyleBackColor = false;
            this.btn_CancelOrder.Click += new System.EventHandler(this.btn_CancelOrder_Click);
            // 
            // btn_Checkout
            // 
            this.btn_Checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_Checkout.FlatAppearance.BorderSize = 0;
            this.btn_Checkout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.btn_Checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Checkout.ForeColor = System.Drawing.Color.White;
            this.btn_Checkout.Location = new System.Drawing.Point(0, 288);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(105, 32);
            this.btn_Checkout.TabIndex = 99;
            this.btn_Checkout.Text = "Checkout";
            this.btn_Checkout.UseVisualStyleBackColor = false;
            this.btn_Checkout.Click += new System.EventHandler(this.btn_Checkout_Click);
            // 
            // Lbl_OrderStatus
            // 
            this.Lbl_OrderStatus.AutoSize = true;
            this.Lbl_OrderStatus.Location = new System.Drawing.Point(82, 162);
            this.Lbl_OrderStatus.Name = "Lbl_OrderStatus";
            this.Lbl_OrderStatus.Size = new System.Drawing.Size(69, 13);
            this.Lbl_OrderStatus.TabIndex = 107;
            this.Lbl_OrderStatus.Text = "Order Status:";
            // 
            // Lbl_Address
            // 
            this.Lbl_Address.AutoSize = true;
            this.Lbl_Address.Location = new System.Drawing.Point(82, 141);
            this.Lbl_Address.Name = "Lbl_Address";
            this.Lbl_Address.Size = new System.Drawing.Size(48, 13);
            this.Lbl_Address.TabIndex = 106;
            this.Lbl_Address.Text = "Address:";
            // 
            // Lbl_ContactNumber
            // 
            this.Lbl_ContactNumber.AutoSize = true;
            this.Lbl_ContactNumber.Location = new System.Drawing.Point(82, 120);
            this.Lbl_ContactNumber.Name = "Lbl_ContactNumber";
            this.Lbl_ContactNumber.Size = new System.Drawing.Size(87, 13);
            this.Lbl_ContactNumber.TabIndex = 105;
            this.Lbl_ContactNumber.Text = "Contact Number:";
            // 
            // Lbl_CustomerName
            // 
            this.Lbl_CustomerName.AutoSize = true;
            this.Lbl_CustomerName.Location = new System.Drawing.Point(82, 100);
            this.Lbl_CustomerName.Name = "Lbl_CustomerName";
            this.Lbl_CustomerName.Size = new System.Drawing.Size(85, 13);
            this.Lbl_CustomerName.TabIndex = 104;
            this.Lbl_CustomerName.Text = "Customer Name:";
            // 
            // Lbl_TotalPrice
            // 
            this.Lbl_TotalPrice.AutoSize = true;
            this.Lbl_TotalPrice.Location = new System.Drawing.Point(103, 261);
            this.Lbl_TotalPrice.Name = "Lbl_TotalPrice";
            this.Lbl_TotalPrice.Size = new System.Drawing.Size(61, 13);
            this.Lbl_TotalPrice.TabIndex = 103;
            this.Lbl_TotalPrice.Text = "Total Price:";
            // 
            // Lbl_NumberOfItems
            // 
            this.Lbl_NumberOfItems.AutoSize = true;
            this.Lbl_NumberOfItems.Location = new System.Drawing.Point(103, 240);
            this.Lbl_NumberOfItems.Name = "Lbl_NumberOfItems";
            this.Lbl_NumberOfItems.Size = new System.Drawing.Size(89, 13);
            this.Lbl_NumberOfItems.TabIndex = 102;
            this.Lbl_NumberOfItems.Text = "Number Of Items:";
            // 
            // Lbl_NumberOfProducts
            // 
            this.Lbl_NumberOfProducts.AutoSize = true;
            this.Lbl_NumberOfProducts.Location = new System.Drawing.Point(103, 219);
            this.Lbl_NumberOfProducts.Name = "Lbl_NumberOfProducts";
            this.Lbl_NumberOfProducts.Size = new System.Drawing.Size(106, 13);
            this.Lbl_NumberOfProducts.TabIndex = 101;
            this.Lbl_NumberOfProducts.Text = "Number Of Products:";
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.AutoSize = true;
            this.Lbl_Date.Location = new System.Drawing.Point(103, 199);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(33, 13);
            this.Lbl_Date.TabIndex = 100;
            this.Lbl_Date.Text = "Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-1, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 97;
            this.label10.Text = "Sub Total Price:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-1, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 96;
            this.label11.Text = "Number Of Items:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-1, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 95;
            this.label12.Text = "Number Of Products:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-1, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 94;
            this.label13.Text = "Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 93;
            this.label8.Text = "Order Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Contact Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 90;
            this.label5.Text = "Customer Name:";
            // 
            // CustomerImage
            // 
            this.CustomerImage.Location = new System.Drawing.Point(81, 34);
            this.CustomerImage.Name = "CustomerImage";
            this.CustomerImage.Size = new System.Drawing.Size(61, 53);
            this.CustomerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CustomerImage.TabIndex = 89;
            this.CustomerImage.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 88;
            this.label4.Text = "Order Details";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Lbl_OrderStatusId);
            this.panel7.Controls.Add(this.Lbl_OrderID);
            this.panel7.Controls.Add(this.Date_Filter);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel7.Size = new System.Drawing.Size(222, 52);
            this.panel7.TabIndex = 85;
            // 
            // Lbl_OrderStatusId
            // 
            this.Lbl_OrderStatusId.AutoSize = true;
            this.Lbl_OrderStatusId.Location = new System.Drawing.Point(138, 36);
            this.Lbl_OrderStatusId.Name = "Lbl_OrderStatusId";
            this.Lbl_OrderStatusId.Size = new System.Drawing.Size(0, 13);
            this.Lbl_OrderStatusId.TabIndex = 110;
            this.Lbl_OrderStatusId.Visible = false;
            // 
            // Lbl_OrderID
            // 
            this.Lbl_OrderID.AutoSize = true;
            this.Lbl_OrderID.Location = new System.Drawing.Point(-1, 39);
            this.Lbl_OrderID.Name = "Lbl_OrderID";
            this.Lbl_OrderID.Size = new System.Drawing.Size(0, 13);
            this.Lbl_OrderID.TabIndex = 109;
            this.Lbl_OrderID.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel8);
            this.splitContainer1.Size = new System.Drawing.Size(468, 421);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20, 0, 10, 20);
            this.panel3.Size = new System.Drawing.Size(468, 251);
            this.panel3.TabIndex = 48;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DG_Products);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(20, 35);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(438, 196);
            this.panel6.TabIndex = 3;
            // 
            // DG_Products
            // 
            this.DG_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_Products.Location = new System.Drawing.Point(0, 0);
            this.DG_Products.Name = "DG_Products";
            this.DG_Products.Size = new System.Drawing.Size(438, 196);
            this.DG_Products.TabIndex = 0;
            this.DG_Products.SelectionChanged += new System.EventHandler(this.DG_Stocks_Selection_Change);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.Search);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(20, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(438, 35);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 9);
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
            this.label3.Size = new System.Drawing.Size(169, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cart / Transactions Lists";
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Location = new System.Drawing.Point(243, 6);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(195, 24);
            this.Search.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(20, 0, 10, 20);
            this.panel8.Size = new System.Drawing.Size(468, 166);
            this.panel8.TabIndex = 48;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.DG_OrderDetails);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(20, 35);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(438, 111);
            this.panel9.TabIndex = 3;
            // 
            // DG_OrderDetails
            // 
            this.DG_OrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_OrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_OrderDetails.Location = new System.Drawing.Point(0, 0);
            this.DG_OrderDetails.Name = "DG_OrderDetails";
            this.DG_OrderDetails.Size = new System.Drawing.Size(438, 111);
            this.DG_OrderDetails.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label15);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(20, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(438, 35);
            this.panel10.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(-2, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(187, 18);
            this.label15.TabIndex = 9;
            this.label15.Text = "Selected Cart / Transaction";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.panel1);
            this.Name = "Sales";
            this.Size = new System.Drawing.Size(720, 476);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ProductDetails.ResumeLayout(false);
            this.OrderDetails.ResumeLayout(false);
            this.OrderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerImage)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Products)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_OrderDetails)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ProductDetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker Date_Filter;
        private System.Windows.Forms.CheckBox Use_Filter;
        private System.Windows.Forms.Panel OrderDetails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox CustomerImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label Lbl_OrderStatus;
        private System.Windows.Forms.Label Lbl_Address;
        private System.Windows.Forms.Label Lbl_ContactNumber;
        private System.Windows.Forms.Label Lbl_CustomerName;
        private System.Windows.Forms.Label Lbl_TotalPrice;
        private System.Windows.Forms.Label Lbl_NumberOfItems;
        private System.Windows.Forms.Label Lbl_NumberOfProducts;
        private System.Windows.Forms.Label Lbl_Date;
        private System.Windows.Forms.Button btn_Checkout;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView DG_Products;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView DG_OrderDetails;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_CancelOrder;
        private System.Windows.Forms.Label Lbl_OrderID;
        private System.Windows.Forms.Label Lbl_ProcessCompleted;
        private System.Windows.Forms.Button btn_OrderRecieved;
        private System.Windows.Forms.Label Lbl_OrderStatusId;
        private System.Windows.Forms.Label Lbl_CancelledOrder;
    }
}
