using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Models
{
    public class Report
    {
        public int TotalOrders { get; set; }
        public int TotalCompleteOrders { get; set; }
        public double TotalSales { get; set; }
    }
}
