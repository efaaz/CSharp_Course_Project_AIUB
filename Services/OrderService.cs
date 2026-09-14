using Restaurant_Management.Data;
using Restaurant_Management.Models;
using System.Data;


namespace Restaurant_Management.Services
{
    internal class OrderService
    {
        public string ErrorMessage { get; set; }

        public OrderRepository orderRepository;

        public OrderService()
        {
            ErrorMessage = "";
            orderRepository = new OrderRepository();

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
            if (!orderRepository.IsAvailable(order.TableId))
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

            
            return true;
        }
    }
}
