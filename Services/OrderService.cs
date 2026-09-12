using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.Models;
using Restaurant_Management.Data;

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
