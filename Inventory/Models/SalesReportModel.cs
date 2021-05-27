using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Models
{
    class SalesReportModel
    {
        public string purchased_date { get; set; }
        public string order_ids { get; set; }
        public string customer_name { get; set; }
        public string cashier { get; set; }
        public string total_price { get; set; }
    }
}
