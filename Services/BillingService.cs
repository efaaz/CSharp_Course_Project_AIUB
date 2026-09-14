using Restaurant_Management.Data;
using Restaurant_Management.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Services
{
    internal class BillingService
    {
        public string ErrorMessage { get; set; }
        BillingRepository billingRepository;

        public BillingService(){
            billingRepository = new BillingRepository();
            ErrorMessage = "";
        }

        public string GetErrorMessage() { 
            return ErrorMessage;
        }

        public DataTable GetOrderDetails() {
            return billingRepository.GetOrderDetails();
        }

        public DataTable GetItemDetails(int orderId) {
            return billingRepository.GetItemDetails( orderId);
        }
        public bool GenerateBill(PaymentDetails pd) 
        {
            bool result = billingRepository.GenerateBill( pd);
            if (!result) 
            {
                ErrorMessage = "Failed to Generate Bill";
                return false;
            }
            return true;

        }
    }
}
