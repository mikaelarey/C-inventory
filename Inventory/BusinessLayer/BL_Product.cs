using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Inventory.Models;
using Inventory.DataLayer;

namespace Inventory.BusinessLayer
{
    class BL_Product
    {
        public static bool Save_Product(Product product)
        {
            int ProductId = DL_Product.Add_Product(product);

            if (ProductId > 0)
            {
                string filename = ProductId.ToString() + ".jpg";
                string storage = System.Windows.Forms.Application.StartupPath + "\\images\\products";

                // Save the image
                string path = System.IO.Path.Combine(storage, filename);
                System.Drawing.Image image = product.ProductImage;
                image.Save(path);

                return true;
            }

            return false;
        }

        public static bool Add_BrandName(string BrandName)
        {
            return DL_Product.Add_BrandName(BrandName);
        }

        public static DataTable Get_All_Brand()
        {
            return DL_Product.Get_All_Brand();
        }

        public static DataTable Get_All_Product() 
        {
            return DL_Product.Get_All_Product();
        }

        public static DataTable Get_Products_By_Search(string Search_Value)
        {
            return DL_Product.Get_Products_By_Search(Search_Value);
        }

        public static bool Update_Stock(int ProductId, int UpdatedStock)
        {
            return DL_Product.Update_Stock(ProductId, UpdatedStock);
        }
    }
}
