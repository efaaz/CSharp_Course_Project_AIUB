using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.Enums;

namespace Restaurant_Management.Models
{
    internal class MenuItems
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public ItemStatus ItemStatus { get; set; }
    }
}
