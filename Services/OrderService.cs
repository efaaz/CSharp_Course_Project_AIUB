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
    internal class OrderService
    {
        public string ErrorMessage { get; set; }
        public TableRepository tableRepository;
        public MenuRepository menuRepository;

        public OrderRepository orderRepository = new OrderRepository();

        public OrderService()
        {
            ErrorMessage = "";
            tableRepository = new TableRepository();
            menuRepository = new MenuRepository();

        }

        public string GetErrorMessage()
        {
            return ErrorMessage;
        }
        public DataTable GetTableInfo()
        {
            DataTable tableData = orderRepository.GetTableInfo();
            return tableData;
        }


        public bool PlaceOrder(Order order)
        { 
            if (!tableRepository.IsAvailable(order.TableId))
            {
                ErrorMessage = "The selected table is Occupied, please choose another table.";
                return false;
            }

            bool result = orderRepository.AddOrder(order);
            if (!result)
            {
                ErrorMessage = "Failed to place the order.";
                return false;
            }

            
            return true; // Order placed successfully
        }
    }
}
