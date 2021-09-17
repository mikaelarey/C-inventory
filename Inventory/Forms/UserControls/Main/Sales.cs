using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory.Models;
using Inventory.BusinessLayer;
using Inventory.Properties;

namespace Inventory.Forms.UserControls.MainUserControl
{
    public partial class Sales : UserControl
    {
        public Sales()
        {
            InitializeComponent();
            this.Load += new EventHandler(Sales_Load);
        }

        void Sales_Load(object sender, EventArgs e)
        {
            try
            {
                BL_Sales.Get_All_Transactions(1);
                DG_Products.DataSource = BL_Sales.TransactionData;

                DG_Products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DG_Products.MultiSelect = false;
                DG_Products.ReadOnly = true;

                DG_OrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DG_OrderDetails.MultiSelect = false;
                DG_OrderDetails.ReadOnly = true;

                DG_Products.Columns["order_ids"].HeaderText = "Order Number";
                DG_Products.Columns["customer_name"].HeaderText = "Customer Name";
                DG_Products.Columns["customer_address"].HeaderText = "Delivery Address";
                DG_Products.Columns["customer_contact"].HeaderText = "Contact Number";
                DG_Products.Columns["number_of_products"].HeaderText = "Number Of Products";
                DG_Products.Columns["number_of_items"].HeaderText = "Number Of Items";
                DG_Products.Columns["total_price"].HeaderText = "Total Price";
                DG_Products.Columns["purchased_date"].HeaderText = "Purchased Date";
                DG_Products.Columns["order_status"].HeaderText = "Order Status";

                DG_Products.Columns["customer_image"].Visible = false;
                DG_Products.Columns["order_status_id"].Visible = false;

                foreach (DataGridViewColumn col in DG_Products.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

                Date_Filter.Format = DateTimePickerFormat.Custom;
                Date_Filter.CustomFormat = "ddd dd MMM yyyy";

                OrderDetails.Visible = false;
                btn_CancelOrder.Visible = false;
                btn_Checkout.Visible = false;
                btn_OrderRecieved.Visible = false;
                Lbl_ProcessCompleted.Visible = false;
                Lbl_CancelledOrder.Visible = false;

                DG_Products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DG_OrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            { }
            
            
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            BL_Sales.Get_All_Transactions(1);
            DG_Products.DataSource = BL_Sales.TransactionData;
        }

        private void Search_And_Filter(object sender, EventArgs e)
        {
            string Filter_Value = (Use_Filter.Checked) 
                ? String.Format("customer_name like '%{0}%' and purchased_date = '{1}'",
                                 Search.Text, Date_Filter.Value.ToShortDateString())
                : String.Format("customer_name like '%{0}%'", Search.Text);

            (DG_Products.DataSource as DataTable).DefaultView.RowFilter
                = Filter_Value;
        }

        private void GetSelectedData()
        {
            try
            {
                int orderID = 0;

                foreach (DataGridViewRow row in DG_Products.SelectedRows)
                {
                    orderID = Convert.ToInt32(row.Cells["order_ids"].Value.ToString());
                    CustomerImage.Image = (String.IsNullOrEmpty(row.Cells["customer_image"].Value.ToString()))
                        ? new Bitmap(Resources.user) : Image.FromFile(Application.StartupPath + "\\images\\customers\\" + row.Cells["customer_image"].Value.ToString());

                    Lbl_OrderID.Text = row.Cells["order_ids"].Value.ToString();
                    Lbl_Address.Text = row.Cells["customer_address"].Value.ToString();
                    Lbl_ContactNumber.Text = row.Cells["customer_contact"].Value.ToString();
                    Lbl_CustomerName.Text = row.Cells["customer_name"].Value.ToString();
                    Lbl_Date.Text = (Convert.ToDateTime(row.Cells["purchased_date"].Value.ToString())).ToShortDateString();
                    Lbl_NumberOfItems.Text = row.Cells["number_of_items"].Value.ToString();
                    Lbl_NumberOfProducts.Text = row.Cells["number_of_products"].Value.ToString();
                    Lbl_OrderStatus.Text = row.Cells["order_status"].Value.ToString();
                    Lbl_TotalPrice.Text = row.Cells["total_price"].Value.ToString();
                    Lbl_OrderStatus.Text = row.Cells["order_status_id"].Value.ToString();
                }

                OrderDetails.Visible = true;
                DG_OrderDetails.DataSource = BL_Sales.Get_Cart_Data_By_Order_Number(orderID);

                if (Convert.ToInt32(Lbl_OrderStatus.Text) == 1)
                {
                    if (AuthenticatedUser.SalesModify == 1) 
                    {
                        btn_CancelOrder.Visible = true;
                        btn_Checkout.Visible = true;
                    }
                    
                    btn_OrderRecieved.Visible = false;
                    Lbl_ProcessCompleted.Visible = false;
                    Lbl_CancelledOrder.Visible = false;
                }
                else if (Convert.ToInt32(Lbl_OrderStatus.Text) == 2)
                {
                    if (AuthenticatedUser.SalesModify == 1)
                    {
                        btn_OrderRecieved.Visible = true;
                    }

                    btn_CancelOrder.Visible = false;
                    btn_Checkout.Visible = false;
                    Lbl_ProcessCompleted.Visible = false;
                    Lbl_CancelledOrder.Visible = false;
                }
                else if (Convert.ToInt32(Lbl_OrderStatus.Text) == 3)
                {
                    btn_CancelOrder.Visible = false;
                    btn_Checkout.Visible = false;
                    btn_OrderRecieved.Visible = false;
                    Lbl_ProcessCompleted.Visible = true;
                    Lbl_CancelledOrder.Visible = false;
                }
                else if (Convert.ToInt32(Lbl_OrderStatus.Text) == 4)
                {
                    btn_CancelOrder.Visible = false;
                    btn_Checkout.Visible = false;
                    btn_OrderRecieved.Visible = false;
                    Lbl_ProcessCompleted.Visible = false;
                    Lbl_CancelledOrder.Visible = true;
                }
                else
                {
                    btn_CancelOrder.Visible = false;
                    btn_Checkout.Visible = false;
                    btn_OrderRecieved.Visible = false;
                    Lbl_ProcessCompleted.Visible = false;
                    Lbl_CancelledOrder.Visible = false;
                }
            }
            catch (Exception ex) { OrderDetails.Visible = false; }
        }

        

        private void DG_Stocks_Selection_Change(object sender, EventArgs e)
        {
            GetSelectedData();
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            List<ReceiptModel> list = new List<ReceiptModel>();
            list.Clear();

            int size = 2;
            foreach (DataGridViewRow row in DG_OrderDetails.Rows)
            {
                string productId = row.Cells["product_id"].Value.ToString();
                string quantity = row.Cells["quantity"].Value.ToString();

                string Amount = row.Cells["total_price"].Value.ToString();
                string Brand = row.Cells["product_brand_name"].Value.ToString();
                string Price = row.Cells["selling_price"].Value.ToString();
                string Product = row.Cells["name"].Value.ToString();
                string Quantity = row.Cells["quantity"].Value.ToString();
                string Unit = row.Cells["unit"].Value.ToString();

                ReceiptModel receiptModel = new ReceiptModel() { 
                    Amount = Amount,
                    Brand = Brand,
                    Price = Price,
                    Product = Product,
                    Quantity = Quantity,
                    Unit = Unit
                };

                list.Add(receiptModel);

                if (size == DG_OrderDetails.RowCount) break;
                size++;
            }

            BL_Sales.Receipt_Report_DataSource.Name = "ReceiptDataSet";
            BL_Sales.Receipt_Report_DataSource.Value = list;

            ReceiptData.Address = Lbl_Address.Text;
            ReceiptData.Cashier = String.Format("{0} {1}", AuthenticatedUser.FirstName, AuthenticatedUser.LastName);
            ReceiptData.Contact = Lbl_ContactNumber.Text;
            ReceiptData.Date = DateTime.Now.ToString();
            ReceiptData.ItemSold = Lbl_NumberOfItems.Text;
            ReceiptData.Name = Lbl_CustomerName.Text;
            ReceiptData.OrderNumber = Lbl_OrderID.Text;
            ReceiptData.SubTotal = Lbl_TotalPrice.Text;
            ReceiptData.Tax = Convert.ToDecimal((Convert.ToDecimal(Lbl_TotalPrice.Text) * Convert.ToDecimal(0.12))).ToString();
            ReceiptData.Total = Convert.ToDecimal((Convert.ToDecimal(ReceiptData.Tax) + Convert.ToDecimal(ReceiptData.SubTotal))).ToString();

            ReceiptForm receiptForm = new ReceiptForm();
            receiptForm.ShowDialog();
            Reset_ReceiptData();

            if (BL_Sales.Proceed_To_Checkout)
            {
                if (Is_Stocks_Sufficient())
                {
                    MessageBox.Show("Order has been successfully checked out.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BL_Sales.Get_All_Transactions(1);
                    DG_Products.DataSource = BL_Sales.TransactionData;
                    BL_Sales.Proceed_To_Checkout = false;
                    Reset_ReceiptData();
                    return;
                }
                else MessageBox.Show("The stocks are not sufficient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BL_Sales.Proceed_To_Checkout = false;
            Reset_ReceiptData();
        }

        private bool Is_Stocks_Sufficient()
        {
            BL_Sales.Get_All_Products();

            string productQuery = "";
            int size = 2;
            foreach (DataGridViewRow row in DG_OrderDetails.Rows)
            {
                string productId = row.Cells["product_id"].Value.ToString();
                string quantity = row.Cells["quantity"].Value.ToString();

                int DTSize = 1;
                foreach (DataRow dr in BL_Sales.ProductsData.Rows)
                {
                    if (dr["product_id"].ToString() == productId)
                    {
                        if (Convert.ToInt32(dr["quantity"].ToString()) < Convert.ToInt32(quantity)) return false;
                        productQuery += String.Format(
                            "UPDATE product SET quantity = {0} WHERE product_id = {1};", 
                            Convert.ToInt32(dr["quantity"].ToString()) - Convert.ToInt32(quantity), productId);
                        break;
                    }

                    if (DTSize == BL_Sales.ProductsData.Rows.Count) break;
                    DTSize++;
                }

                if (size == DG_OrderDetails.RowCount) break;
                size++;
            }

            productQuery += "UPDATE orders SET order_status_id = 2 WHERE order_id = " + Lbl_OrderID.Text;
            return BL_Sales.Update_Product_On_Checkout(productQuery);
        }

        private void btn_OrderRecieved_Click(object sender, EventArgs e)
        {
            if (BL_Sales.Update_Order_From_OnGoing_To_Completed(Convert.ToInt32(Lbl_OrderID.Text)))
                MessageBox.Show("Order has been successfully completed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else MessageBox.Show("Unable to complete order", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            BL_Sales.Get_All_Transactions(2);
            DG_Products.DataSource = BL_Sales.TransactionData;
        }

        private void Reset_ReceiptData()
        {
            ReceiptData.Address = "";
            ReceiptData.Cashier = "";
            ReceiptData.Contact = "";
            ReceiptData.Date = "";
            ReceiptData.ItemSold = "";
            ReceiptData.Name = "";
            ReceiptData.OrderNumber = "";
            ReceiptData.SubTotal = "";
            ReceiptData.Tax = "";
            ReceiptData.Total = "";
        }

        private void btn_CancelOrder_Click(object sender, EventArgs e)
        {
            string productQuery = "UPDATE orders SET order_status_id = 4 WHERE order_id = " + Lbl_OrderID.Text;
            if (BL_Sales.Cancel_Order(productQuery))
                MessageBox.Show("Order has been successfully cancelled.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Unable to cancel order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            BL_Sales.Get_All_Transactions(1);
            DG_Products.DataSource = BL_Sales.TransactionData;
        }

        private void btn_forCheckout_Click(object sender, EventArgs e)
        {
            BL_Sales.Get_All_Transactions(1);
            DG_Products.DataSource = BL_Sales.TransactionData;
        }

        private void btn_forDelivery_Click(object sender, EventArgs e)
        {
            BL_Sales.Get_All_Transactions(2);
            DG_Products.DataSource = BL_Sales.TransactionData;
        }

        private void btn_completed_Click(object sender, EventArgs e)
        {
            BL_Sales.Get_All_Transactions(3);
            DG_Products.DataSource = BL_Sales.TransactionData;
        }
    }
}
