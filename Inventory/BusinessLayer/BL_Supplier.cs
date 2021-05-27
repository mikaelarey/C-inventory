using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Inventory.Models;
using Inventory.DataLayer;

namespace Inventory.BusinessLayer
{
    class BL_Supplier
    {
        public static bool AddOrUpdate_Supplier(Supplier supplier)
        {
            return DL_Suppplier.AddOrUpdate_Supplier(supplier);
        }

        public static DataTable Get_All_Supplier()
        {
            return DL_Suppplier.Get_All_Supplier();
        }

        public static DataTable Get_Supplier_By_Search(string Search_Value)
        {
            return DL_Suppplier.Get_Supplier_By_Search(Search_Value);
        }
    }
}
