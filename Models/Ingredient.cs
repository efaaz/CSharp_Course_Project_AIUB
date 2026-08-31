using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Restaurant_Management.Models
{
    internal class Ingredient
    {
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public decimal Quantity { get; set; }
        public decimal MinimumStock { get; set; }
    }
}