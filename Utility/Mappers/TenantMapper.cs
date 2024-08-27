using HouseManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.DTOs;

namespace Utility.Mappers
{
    public class TenantMapper
    {
        public Tenant toSql(TenantDTO model)
        {
            Tenant tenant = new Tenant();
            tenant.TenantId = model.TenantId;
            tenant.FirstName = model.FirstName;
            tenant.LastName = model.LastName;
            tenant.Contact = model.Contact;
            tenant.HouseId = model.HouseId;
            return tenant;
        }

        public TenantDTO toDto(Tenant model)
        {
            TenantDTO tenant = new TenantDTO();
            tenant.TenantId = model.TenantId;
            tenant.FirstName = model.FirstName;
            tenant.LastName = model.LastName;
            tenant.Contact = model.Contact;
            tenant.HouseId = model.HouseId;
            return tenant;
        }
    }
}
