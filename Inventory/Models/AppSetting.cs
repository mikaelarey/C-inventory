using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Models
{
    class AppSetting
    {
        public static bool isFirtsRun { get; set; }
        public static bool HasConnectionString { get; set; }
        public static bool HasDatabase { get; set; }
        public static bool HasDefaultUser { get; set; }

        // If UserInfo Has Been Provided: Not Save To Config
        public static bool HasUserInfo = false;
    }
}
