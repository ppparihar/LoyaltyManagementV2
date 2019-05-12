using LoyaltyManagement.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoyaltyManagement.Interfaces
{
    public interface IProduct
    {
        int ProductId { get; set; }
        ProductCategory Category { get; set; }
    }
}
