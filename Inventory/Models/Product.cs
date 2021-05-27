using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Models
{
    class Product
    {
        public int ProductId { get; set; }
        public string BrandName { get; set; }
        public int BrandId { get; set; }
        public string ProductName { get; set; }
        public string ProductImageName { get; set; }
        public System.Drawing.Image ProductImage { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
        public decimal PurchasedPrice { get; set; }
        public decimal SellingPrice { get; set; }
    }
}
