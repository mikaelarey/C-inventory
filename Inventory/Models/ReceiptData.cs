using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Models
{
    class ReceiptData
    {
        public static string OrderNumber { get; set; }
        public static string Name { get; set; }
        public static string Address { get; set; }
        public static string Date { get; set; }
        public static string Contact { get; set; }
        public static string ItemSold { get; set; }
        public static string Cashier { get; set; }
        public static string SubTotal { get; set; }
        public static string Tax { get; set; }
        public static string Total { get; set; }
    }
}
