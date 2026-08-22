using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Utilities
{
    public static class ValidationHelper
    {
      
            public static bool IsEmpty(string value)
            {
                return string.IsNullOrWhiteSpace(value);
            }

            public static bool IsPositive(decimal value)
            {
                return value > 0;
            }
        
    }
}
