using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventory.Models;

namespace Inventory.Configuration
{
    class General
    {
        public static string Build_ConnectionString()
        {
            return String.Format("server={0};username={1};password={2};database={3};Allow User Variables=True",
                ConnectionString.Server, ConnectionString.Username, ConnectionString.Password, ConnectionString.Database);
        }
    }
}
