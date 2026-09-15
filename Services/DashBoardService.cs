using Restaurant_Management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Services
{
    internal class DashBoardService
    {
        public string ErrorMassege { get; set; }
        DashBoardRepository dashBoardRepository;
        public DashBoardService()
        {
            dashBoardRepository = new DashBoardRepository();
            ErrorMassege = "";
        }
        public string GetErrorMassege()
        {
            return ErrorMassege;
        }
        public string GetOrders()
        {
            string orders = dashBoardRepository.GetOrders().ToString();
            if (orders == null)
            {
                ErrorMassege = "Failed to get order count.";
             
            }
            return orders;
        }

        public string GetPendingOrders()
        {
            string pending = dashBoardRepository.GetPendingOrders().ToString();
            if (pending == null)
            {
                ErrorMassege = "Failed to get pending orders count.";
               
            }
            return pending;
        }

        public string GetPreparingOrders()
        {
            string preparing = dashBoardRepository.GetPreparingOrders().ToString();
            if (preparing == null)
            {
                ErrorMassege = "Failed to get the preparing orders count";
                
            }
            return preparing;
        }

        public string GetTotalSales()
        {
            string TotalSales = dashBoardRepository.GetTotalSales().ToString("0.00");
            if (TotalSales == null)
            {
                ErrorMassege = "Failed to get the total sales value";

            }
            return TotalSales;
        }
    }
}
