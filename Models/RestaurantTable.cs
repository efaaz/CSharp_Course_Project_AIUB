using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.Enums;

namespace Restaurant_Management.Models
{
    internal class RestaurantTable
    {
        public int TableId { get; set; }
        public int TableNumber { get; set; }
        public int Capacity { get; set; }
        public TableStatus Status { get; set; }
    }
}