using System;
using System.Collections.Generic;

namespace HouseManagementSystem
{
    public partial class Tenant
    {
        public int TenantId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public int HouseId { get; set; }

    }
}
