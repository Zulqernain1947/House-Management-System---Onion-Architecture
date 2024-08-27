using HouseManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.DTOs
{
    public class TenantDTO
    {
        public int TenantId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public int HouseId { get; set; }

    }
}
