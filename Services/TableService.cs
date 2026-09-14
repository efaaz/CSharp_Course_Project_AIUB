using Restaurant_Management.Data;
using Restaurant_Management.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
            
                bool result = tableRepository.AddTable(table);
            if (!result)
            {
                errorMessage = "Failed to add table";
                return false;
            }

            return true;
        }
    }
}
