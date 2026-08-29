using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.Enums;

namespace Restaurant_Management.Models
{
    internal class PaymentSlip
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal Tax { get; set; }
        public decimal Vat { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
