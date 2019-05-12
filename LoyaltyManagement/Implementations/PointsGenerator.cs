using LoyaltyManagement.Common;
using LoyaltyManagement.Enums;
using LoyaltyManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoyaltyManagement.implementations
{
    public class PointsGenerator : IPointsGenerator
    {
        // Dictionary<ProductCategory, int> PointsDictionary = new Dictionary<ProductCategory, int>();

        public int GetPoints(IProduct product)
        {
            Gaurd.IsNotNull(product, nameof(product));

            // We can add our logic to generat points
            // The Points can be fetched from DB based on the product category
            return product.Category == ProductCategory.Electronics ? 100 : 50;
        }
    }
}
