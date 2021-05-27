using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Models
{
    class TransactionReportModel
    {
        public string creation_date { get; set; }
        public string customer_name { get; set; }
        public string name { get; set; }
        public string item_quantity { get; set; }
        public string unit { get; set; }
        public string price { get; set; }
        public string total_price { get; set; }
    }
}
