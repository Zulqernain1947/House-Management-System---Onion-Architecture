using System;
using System.Collections.Generic;

namespace HouseManagementSystem
{
    public partial class House
    {
        public House()
        {
            Tenants = new HashSet<Tenant>();
        }

        public int HouseId { get; set; }
        public string Address { get; set; } = null!;
        public int Bedrooms { get; set; }
        public decimal RentAmount { get; set; }

        public virtual ICollection<Tenant> Tenants { get; set; }
    }
}
