using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Inventory.Models;
using Inventory.DataLayer;

namespace Inventory.BusinessLayer
{
    class BL_Customer
    {
        public static bool Add_Customer(Customer customer)
        {
            int CustomerId = DL_Customer.Add_Customer(customer);

            if (CustomerId > 0)
            {
                if (customer.CustomerImage == null)
                    return true;

                string filename = CustomerId.ToString() + ".jpg";
                string storage = System.Windows.Forms.Application.StartupPath + "\\images\\customers";

                // Save the image
                string path = System.IO.Path.Combine(storage, filename);
                System.Drawing.Image image = customer.CustomerImage;
                image.Save(path);

                return true;
            }

            return false;
        }

        public static DataTable Get_All_Customer()
        {
            return DL_Customer.Get_All_Customer();
        }

        public static DataTable Get_Customers_By_Search(string Search_Value)
        {
            return DL_Customer.Get_Customers_By_Search(Search_Value);
        }

        public static bool Update_Customer(Customer customer)
        {
            if (DL_Customer.Update_Customer(customer))
            {
                if (customer.CustomerImage == null)
                    return true;

                string filename = customer.ImageFileName + ".jpg";
                string storage = System.Windows.Forms.Application.StartupPath + "\\images\\customers";

                // Save the image
                string path = System.IO.Path.Combine(storage, filename);
                System.Drawing.Image image = customer.CustomerImage;

                // TODO: Delete image and replace with the new one
                if (System.IO.File.Exists(path))
                    return true;
                
                image.Save(path);

                return true;
            }

            return false;
        }
    }
}
