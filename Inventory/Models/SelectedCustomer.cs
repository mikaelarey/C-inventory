using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Models
{
    class SelectedCustomer
    {
        public static int CustomerId { get; set; }
        public static string FristName { get; set; }
        public static string LastName { get; set; }
        public static string ContactNumber { get; set; }
        public static string Address { get; set; }
        public static string ImageFileName { get; set; }
        public static System.Drawing.Image CustomerImage { get; set; }
    }
}
