using DatabaseAccess.Implementations;
using DatabaseAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.DTOs;
using Utility;

namespace Service
{
    public class TenantService
    {
        IHMS _database = new HMSDA();
        public ResponseClass insertTenantData(TenantDTO tenant)
        {
            tenant = _database.insertTenant(tenant);
            if (tenant == null)
            {
                ResponseClass s1 = new ResponseClass();
                s1.result = null;
                s1.error_code = 3;
                return s1;

            }
            else
            {
                ResponseClass s1 = new ResponseClass();
                s1.result = tenant;
                s1.error_code = 1;
                return s1;
            }
        }

        public ResponseClass getTenantsData()
        {
            List<TenantDTO> tenants = new List<TenantDTO>();
            tenants = _database.getAllTenants();
            if (tenants == null)
            {
                ResponseClass s1 = new ResponseClass();
                s1.result = null;
                s1.error_code = 3;
                return s1;

            }
            else
            {
                ResponseClass s1 = new ResponseClass();
                s1.result = tenants;
                s1.error_code = 1;
                return s1;
            }

        }

        public ResponseClass updateTenantData(TenantDTO tenant, int id)
        {
            tenant = _database.updateTenant(tenant, id);
            if (tenant == null)
            {
                ResponseClass s1 = new ResponseClass();
                s1.result = null;
                s1.error_code = 3;
                return s1;

            }
            else
            {
                ResponseClass s1 = new ResponseClass();
                s1.result = tenant;
                s1.error_code = 1;
                return s1;
            }
        }

        public ResponseClass deleteTenantData(int id)
        {
            var chk = _database.deleteTenant(id);
            if (chk == null)
            {
                ResponseClass s1 = new ResponseClass();
                s1.result = null;
                s1.error_code = 3;
                return s1;

            }
            else
            {
                ResponseClass s1 = new ResponseClass();
                s1.result = chk;
                s1.error_code = 1;
                return s1;
            }
        }
    }
}
