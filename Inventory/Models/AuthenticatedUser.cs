using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Models
{
    class AuthenticatedUser
    {
        public static string Id { get; set; }
        public static string Username { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Password { get; set; }
        public static System.Drawing.Image Profile { get; set; }

        public static int InventoryAccess { get; set; }
        public static int InventoryModify { get; set; }
        public static int SalesAccess { get; set; }
        public static int SalesModify { get; set; }
        public static int DeliveryAccess { get; set; }
        public static int DeliveryModify { get; set; }
    }
}
