using Restaurant_Management.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Services
{
    internal class MenuService
    {
        public string ErrorMessage { get; set; }
        public MenuRepository menuRepository;

        public MenuService()
        {
            menuRepository = new MenuRepository();
            ErrorMessage = "";
        }
        public string GetErrorMessage()
        {
            return ErrorMessage;
        }

        public DataTable GetAllMenuItems()
        {
            
            
            DataTable dt = menuRepository.GetAllMenuItems();
            
            if (dt == null)
            {
                ErrorMessage = "Failed to retrieve menu items.";
                return null;
            }

            return dt;
        }
    }
}
