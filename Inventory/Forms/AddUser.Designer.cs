namespace Inventory.Forms
{
    partial class AddUser
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
            this.TB_LastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_FirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_InventoryAccess = new System.Windows.Forms.CheckBox();
            this.CB_InventoryModify = new System.Windows.Forms.CheckBox();
            this.CB_SalesAccess = new System.Windows.Forms.CheckBox();
            this.CB_SalesModify = new System.Windows.Forms.CheckBox();
            this.CB_DeliveryAccess = new System.Windows.Forms.CheckBox();
            this.CB_DeliveryModify = new System.Windows.Forms.CheckBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB_LastName
            // 
            this.TB_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_LastName.Location = new System.Drawing.Point(104, 180);
            this.TB_LastName.Name = "TB_LastName";
            this.TB_LastName.Size = new System.Drawing.Size(199, 24);
            this.TB_LastName.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Last Name:";
            // 
            // TB_FirstName
            // 
            this.TB_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_FirstName.Location = new System.Drawing.Point(104, 143);
            this.TB_FirstName.Name = "TB_FirstName";
            this.TB_FirstName.Size = new System.Drawing.Size(199, 24);
            this.TB_FirstName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "First Name:";
            // 
            // TB_Password
            // 
            this.TB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.Location = new System.Drawing.Point(104, 107);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(199, 24);
            this.TB_Password.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password:";
            // 
            // TB_Username
            // 
            this.TB_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Username.Location = new System.Drawing.Point(104, 71);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(199, 24);
            this.TB_Username.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "____________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Permissions";
            // 
            // CB_InventoryAccess
            // 
            this.CB_InventoryAccess.AutoSize = true;
            this.CB_InventoryAccess.Location = new System.Drawing.Point(16, 280);
            this.CB_InventoryAccess.Name = "CB_InventoryAccess";
            this.CB_InventoryAccess.Size = new System.Drawing.Size(169, 17);
            this.CB_InventoryAccess.TabIndex = 18;
            this.CB_InventoryAccess.Text = "Allow user to access inventory";
            this.CB_InventoryAccess.UseVisualStyleBackColor = true;
            // 
            // CB_InventoryModify
            // 
            this.CB_InventoryModify.AutoSize = true;
            this.CB_InventoryModify.Location = new System.Drawing.Point(16, 303);
            this.CB_InventoryModify.Name = "CB_InventoryModify";
            this.CB_InventoryModify.Size = new System.Drawing.Size(247, 17);
            this.CB_InventoryModify.TabIndex = 19;
            this.CB_InventoryModify.Text = "Allow user to edit / delete products in inventory";
            this.CB_InventoryModify.UseVisualStyleBackColor = true;
            // 
            // CB_SalesAccess
            // 
            this.CB_SalesAccess.AutoSize = true;
            this.CB_SalesAccess.Location = new System.Drawing.Point(16, 326);
            this.CB_SalesAccess.Name = "CB_SalesAccess";
            this.CB_SalesAccess.Size = new System.Drawing.Size(150, 17);
            this.CB_SalesAccess.TabIndex = 20;
            this.CB_SalesAccess.Text = "Allow user to access sales";
            this.CB_SalesAccess.UseVisualStyleBackColor = true;
            // 
            // CB_SalesModify
            // 
            this.CB_SalesModify.AutoSize = true;
            this.CB_SalesModify.Location = new System.Drawing.Point(16, 349);
            this.CB_SalesModify.Name = "CB_SalesModify";
            this.CB_SalesModify.Size = new System.Drawing.Size(259, 17);
            this.CB_SalesModify.TabIndex = 21;
            this.CB_SalesModify.Text = "Allow user to edit / delete / print transaction sales";
            this.CB_SalesModify.UseVisualStyleBackColor = true;
            // 
            // CB_DeliveryAccess
            // 
            this.CB_DeliveryAccess.AutoSize = true;
            this.CB_DeliveryAccess.Location = new System.Drawing.Point(16, 372);
            this.CB_DeliveryAccess.Name = "CB_DeliveryAccess";
            this.CB_DeliveryAccess.Size = new System.Drawing.Size(170, 17);
            this.CB_DeliveryAccess.TabIndex = 22;
            this.CB_DeliveryAccess.Text = "Allow user to access deliveries";
            this.CB_DeliveryAccess.UseVisualStyleBackColor = true;
            // 
            // CB_DeliveryModify
            // 
            this.CB_DeliveryModify.AutoSize = true;
            this.CB_DeliveryModify.Location = new System.Drawing.Point(16, 395);
            this.CB_DeliveryModify.Name = "CB_DeliveryModify";
            this.CB_DeliveryModify.Size = new System.Drawing.Size(259, 17);
            this.CB_DeliveryModify.TabIndex = 23;
            this.CB_DeliveryModify.Text = "Allow user to edit / delete transaction in deliveries";
            this.CB_DeliveryModify.UseVisualStyleBackColor = true;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(96, 427);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(129, 32);
            this.btn_Refresh.TabIndex = 50;
            this.btn_Refresh.Text = "Save";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 471);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.CB_DeliveryModify);
            this.Controls.Add(this.CB_DeliveryAccess);
            this.Controls.Add(this.CB_SalesModify);
            this.Controls.Add(this.CB_SalesAccess);
            this.Controls.Add(this.CB_InventoryModify);
            this.Controls.Add(this.CB_InventoryAccess);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_LastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_FirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Username);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_LastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_FirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CB_InventoryAccess;
        private System.Windows.Forms.CheckBox CB_InventoryModify;
        private System.Windows.Forms.CheckBox CB_SalesAccess;
        private System.Windows.Forms.CheckBox CB_SalesModify;
        private System.Windows.Forms.CheckBox CB_DeliveryAccess;
        private System.Windows.Forms.CheckBox CB_DeliveryModify;
        private System.Windows.Forms.Button btn_Refresh;
    }
}