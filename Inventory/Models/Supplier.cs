using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Models
{
    class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Remarks { get; set; }
    }
}
