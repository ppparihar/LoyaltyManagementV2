using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoyaltyManagement.Common
{
    public static class Gaurd
    {
        public static void IsNotNull(object objectVal, string propertyName)
        {
            if (objectVal == null)
            {
                var checkedPropertyName = CheckPropertyName(propertyName);
                throw new ArgumentNullException(string.Format("Argument [{0}] is required", checkedPropertyName));
            }
        }
        private static string CheckPropertyName(string propertyName)
        {
            return string.IsNullOrWhiteSpace(propertyName) ? "Unknown" : propertyName;

        }
    }
}
