using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventory.Models;
using Inventory.DataLayer.AppSettings;

namespace Inventory.BusinessLayer.AppSettings
{
    class BL_Database
    {
        public static bool Is_Database_Created(string DatabaseName)
        {
            ConnectionString.Database = DatabaseName;
            BL_AppSettings.Save_Database_To_ConfigurationFile(DatabaseName);

            return DL_Database.Execute_Database_Creation(DatabaseName);
        }
    }
}
