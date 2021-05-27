using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Models
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string ImageFileName { get; set; }
        public System.Drawing.Image CustomerImage { get; set; }
    }
}
