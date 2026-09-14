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

        public bool AddMenuItem(MenuItems menu)
        {
            if (menuRepository.IsMenuItemExists(menu.ItemName))
            {
                ErrorMessage = "Menu item: " + menu.ItemName + " already exists. Choose a different item.";
                return false;
            }

            bool result = menuRepository.AddMenuItem(menu);

            if (!result)
            {
                ErrorMessage = "Failed to add the menu item.";
                return false;
            }
            return true;
        }

        public bool UpdateMenuItem(MenuItems menu)
        {
            bool result = menuRepository.UpdateMenuItem(menu);
            if (!result)
            {
                ErrorMessage = "Failed to update the menu item.";
                return false;
            }
            return true;
        }
    }
}
