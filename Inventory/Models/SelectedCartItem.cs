using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Models
{
    class SelectedCartItem
    {
        public static int ID { get; set; }
        public static string Name { get; set; }
        public static string Brand { get; set; }
        public static string Unit { get; set; }
        public static decimal Price { get; set; }
        public static int Quantity { get; set; }
        public static decimal TotalPrice { get; set; }
        public static System.Drawing.Image ProductImage { get; set; }
    }
}
