using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.Enums;

namespace Restaurant_Management.Models
{
    internal class PaymentDetails
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public String PaymentMethod { get; set; }
        public double ServiceCharge { get; set; }
        public double Vat { get; set; }
        public double TotalAmount { get; set; }
    }
}
