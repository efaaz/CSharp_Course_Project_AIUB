using Restaurant_Management.Data;
using Restaurant_Management.Models;
using System.Data;


namespace Restaurant_Management.Services
{
    internal class TableService
    {
        TableRepository tableRepository;
        string errorMessage;
        public TableService()
        {
            tableRepository = new TableRepository();
        }

        public string GetErrorMessage()
        {
            return errorMessage;
        }

        public DataTable GetTableInfo()
        {
            DataTable tableData = tableRepository.GetTableInfo();
            return tableData;
        }

        public bool AddTable(RestaurantTable table)
        {

            if (tableRepository.findTableByTableNumber(table.TableNumber))
            {
                errorMessage = "Table number: " + table.TableNumber + " is used choose different table number!";
                return false;
            }

            bool result = tableRepository.AddTable(table);
            if (!result)
            {
                errorMessage = "Failed to add table";
                return false;
            }

            return true;
        }

        public bool UpdateTableInfo(RestaurantTable table)
        {
            if (tableRepository.findTableByTableNumber(table.TableNumber))
            {
                errorMessage = "Table number: " + table.TableNumber + "is used choose different table number!";
                return false;
            }
            bool result = tableRepository.UpdateTableInfo(table);
            if (!result)
            {
                errorMessage = "Failed to update table info";
                return false;
            }

            return true;
        }

    }
}
