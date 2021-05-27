using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Models
{
    class SelectedStock
    {
        public static int ProductId { get; set; }
        public static string BrandName { get; set; }
        public static string ProductName { get; set; }
        public static string ProductImageName { get; set; }
        public static System.Drawing.Image ProductImage { get; set; }
        public static int Quantity { get; set; }
        public static string Unit { get; set; }
        public static decimal PurchasedPrice { get; set; }
        public static decimal SellingPrice { get; set; }
    }
}
