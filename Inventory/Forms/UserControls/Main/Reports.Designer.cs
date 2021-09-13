namespace Inventory.Forms.UserControls.MainUserControl
{
    partial class Reports
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Cash_Sales_Report = new System.Windows.Forms.Button();
            this.Btn_Transaction_Report = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 55);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            // 
            // Btn_Cash_Sales_Report
            // 
            this.Btn_Cash_Sales_Report.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Cash_Sales_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Btn_Cash_Sales_Report.FlatAppearance.BorderSize = 0;
            this.Btn_Cash_Sales_Report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.Btn_Cash_Sales_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cash_Sales_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cash_Sales_Report.ForeColor = System.Drawing.Color.White;
            this.Btn_Cash_Sales_Report.Location = new System.Drawing.Point(135, 189);
            this.Btn_Cash_Sales_Report.Name = "Btn_Cash_Sales_Report";
            this.Btn_Cash_Sales_Report.Size = new System.Drawing.Size(204, 65);
            this.Btn_Cash_Sales_Report.TabIndex = 43;
            this.Btn_Cash_Sales_Report.Text = "Cash Sales Report";
            this.Btn_Cash_Sales_Report.UseVisualStyleBackColor = false;
            this.Btn_Cash_Sales_Report.Click += new System.EventHandler(this.Btn_Cash_Sales_Report_Click);
            // 
            // Btn_Transaction_Report
            // 
            this.Btn_Transaction_Report.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Transaction_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.Btn_Transaction_Report.FlatAppearance.BorderSize = 0;
            this.Btn_Transaction_Report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.Btn_Transaction_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Transaction_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Transaction_Report.ForeColor = System.Drawing.Color.White;
            this.Btn_Transaction_Report.Location = new System.Drawing.Point(369, 189);
            this.Btn_Transaction_Report.Name = "Btn_Transaction_Report";
            this.Btn_Transaction_Report.Size = new System.Drawing.Size(204, 65);
            this.Btn_Transaction_Report.TabIndex = 44;
            this.Btn_Transaction_Report.Text = "Transaction Report";
            this.Btn_Transaction_Report.UseVisualStyleBackColor = false;
            this.Btn_Transaction_Report.Click += new System.EventHandler(this.Btn_Transaction_Report_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 24);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "Select Date Of Report:";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Btn_Transaction_Report);
            this.Controls.Add(this.Btn_Cash_Sales_Report);
            this.Controls.Add(this.panel1);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(720, 407);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Cash_Sales_Report;
        private System.Windows.Forms.Button Btn_Transaction_Report;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}
