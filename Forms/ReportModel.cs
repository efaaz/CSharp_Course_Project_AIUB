using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Forms
{
    internal class ReportModel
    {
        public int TotalOrders { get; set; }
        public int TotalCompleteOrders { get; set; }
        public decimal TotalSales { get; set; }
    }
}
