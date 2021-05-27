using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Inventory.DataLayer;

namespace Inventory.BusinessLayer
{
    class BL_Menu
    {
        public static DataTable Get_Best_Seller()
        {
            return DL_Menu.Get_Best_Seller();
        }

        public static int User_Count()
        {
            return DL_Menu.User_Count();
        }

        public static int Product_Count()
        {
            return DL_Menu.Product_Count();
        }
    }
}
