using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventory.DataLayer.AppSettings;

namespace Inventory.BusinessLayer.AppSettings
{
    class BL_AdminAccount
    {
        public static bool Is_AdminAccount_Created()
        {
            return DL_AdminAccount.Execute_AdminAccount_Creation();
        }
    }
}
