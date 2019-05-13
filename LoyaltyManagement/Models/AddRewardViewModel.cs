using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LoyaltyManagement.Models
{
    public class AddRewardViewModel
    {
        [Required]
        public int CustomerId { get; set; }
        
        [Required]
        public int Points { get; set; }
    }
}
