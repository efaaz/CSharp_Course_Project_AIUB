using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Restaurant_Management.Models
{
    internal class MenuItem
    {
        public int MenuItemId { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
