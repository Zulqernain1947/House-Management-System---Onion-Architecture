using HouseManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.DTOs
{
    public class HouseDTO
    {
        public int HouseId { get; set; }
        public string Address { get; set; } = null!;
        public int Bedrooms { get; set; }
        public decimal RentAmount { get; set; }

    }
}
