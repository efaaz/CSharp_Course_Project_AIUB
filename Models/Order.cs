using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.Enums;

namespace Restaurant_Management.Models
{
    internal class Order
    {
        public int OrderId { get; set; }
        public int TableId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public decimal Total { get; set; }
    }
}