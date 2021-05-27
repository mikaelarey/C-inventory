using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Models
{
    class ReceiptModel
    {
        public string Quantity { get; set; }
        public string Product { get; set; }
        public string Brand { get; set; }
        public string Unit { get; set; }
        public string Price { get; set; }
        public string Amount { get; set; }
    }
}
