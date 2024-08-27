using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.DTOs;

namespace DatabaseAccess.Interfaces
{
    public interface IHMS
    {
        HouseDTO insertHouse(HouseDTO house);
        List<HouseDTO> getAllHouses();
        HouseDTO updateHouse(HouseDTO house, int id);
        HouseDTO deleteHouse(int id);

        TenantDTO insertTenant(TenantDTO tenant);
        List<TenantDTO> getAllTenants();
        TenantDTO updateTenant(TenantDTO tenant, int id);
        TenantDTO deleteTenant(int id);
    }
}
