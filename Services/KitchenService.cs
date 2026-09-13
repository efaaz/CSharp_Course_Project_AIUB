using Restaurant_Management.Data;
using System.Data;


namespace Restaurant_Management.Services
{
    internal class KitchenService
    {
        public string ErrorMessage { get; set; }
        public KitchenRepository KitchenRepository;
        public KitchenService()
        {
            ErrorMessage = "";
            KitchenRepository = new KitchenRepository();
        }

        public string getErrorMessage()
        {
            return ErrorMessage;
        }

        public DataTable GetAllOrders()
        {
            return KitchenRepository.GetAllOrders();
        }

        public DataTable GetOrderItems(int orderId)
        {
            return KitchenRepository.GetOrderItems(orderId);
        }
        public bool UpdateOrderStatus(int orderId, string status)
        {
            bool result = KitchenRepository.UpdateOrderStatus(orderId, status);
            if (!result)
            {
                ErrorMessage = "Failed to update order status.";
                return false;

            }
            return true;
        }
    }
}
