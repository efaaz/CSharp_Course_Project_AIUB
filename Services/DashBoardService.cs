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
        public int GetOrders()
        {
            int orders = dashBoardRepository.GetOrders();
            if (orders == null)
            {
                ErrorMassege = "Failed to get order count.";
                return 0;
            }
            return orders;
        }

        public int GetPendingOrders()
        {
            int pending = dashBoardRepository.GetPendingOrders();
            if (pending == null)
            {
                ErrorMassege = "Failed to get pending orders count.";
                return 0;
            }
            return pending;
        }

        public int GetPreparingOrders()
        {
            int preparing = dashBoardRepository.GetPreparingOrders();
            if (preparing == null)
            {
                ErrorMassege = "Failed to get the preparing orders count";
                return 0;
            }
            return preparing;
        }

        public double GetTotalSales()
        {
            double TotalSales = dashBoardRepository.GetTotalSales();
            if (TotalSales == null)
            {
                ErrorMassege = "Failed to get the total sales value";

            }
            return TotalSales;
        }
    }
}
