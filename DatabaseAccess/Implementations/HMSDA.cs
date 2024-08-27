using DatabaseAccess.Interfaces;
using HouseManagementSystem;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.DTOs;
using Utility.Mappers;

namespace DatabaseAccess.Implementations
{
    public class HMSDA : IHMS
    {
        public HouseDTO insertHouse(HouseDTO house)
        {
            using (var context = new HouseRentalSystemContext())
            {
                HouseMapper houseMapper = new HouseMapper();
                var data = houseMapper.toSql(house);
                context.Houses.Add(data);
                context.SaveChanges();
                var data2 = houseMapper.toDto(data);

            }
            return house;
        }

        public List<HouseDTO> getAllHouses()
        {
            List<HouseDTO> houseDTOs = new List<HouseDTO>();
            using (var context = new HouseRentalSystemContext())
            {
                var housesDataList = context.Houses.ToList();
                foreach (var house in housesDataList)
                {
                    HouseMapper houseMapper = new HouseMapper();
                    houseDTOs.Add(houseMapper.toDto(house));
                }
            }

            return houseDTOs;
        }

        public  HouseDTO updateHouse(HouseDTO house, int id)
        {
            using (var context = new HouseRentalSystemContext())
            {
                    var data = context.Houses.Where(i => i.HouseId == id);
                    HouseMapper houseMapper = new HouseMapper();
                    var house1 = houseMapper.toSql(house);
                    context.Entry(house1).State = EntityState.Modified;
                    context.SaveChanges();
                    var data2 = houseMapper.toDto(house1);
            }

            return house;
        }

        public HouseDTO deleteHouse(int id)
        {
            HouseDTO houseDto = new HouseDTO();
            using (var context = new HouseRentalSystemContext())
            {
                var houseEntity = context.Houses.SingleOrDefault(i => i.HouseId == id);

                if (houseEntity != null)
                {
                    HouseMapper houseMapper = new HouseMapper();
                    houseDto = houseMapper.toDto(houseEntity);

                    context.Houses.Remove(houseEntity);
                    context.SaveChanges();
                }
            }

            return houseDto;
        }

        public TenantDTO insertTenant(TenantDTO tenant)
        {
            using (var context = new HouseRentalSystemContext())
            {
                TenantMapper tenantMapper = new TenantMapper();
                var data = tenantMapper.toSql(tenant);
                context.Tenants.Add(data);
                context.SaveChanges();
                var data2 = tenantMapper.toDto(data);

            }
            return tenant;
        }

        public List<TenantDTO> getAllTenants()
        {
            List<TenantDTO> tenantDTOs = new List<TenantDTO>();
            using (var context = new HouseRentalSystemContext())
            {
                var tenantsData = context.Tenants.ToList();
                foreach (var tenant in tenantsData)
                {
                   TenantMapper tenantMapper = new TenantMapper();
                    tenantDTOs.Add(tenantMapper.toDto(tenant));
                }
            }

            return tenantDTOs;
        }

        public TenantDTO updateTenant(TenantDTO tenant, int id)
        {
            using (var context = new HouseRentalSystemContext())
            {
                var data = context.Tenants.Where(i => i.TenantId == id);
                TenantMapper tenantMapper = new TenantMapper();
                var tenant1 = tenantMapper.toSql(tenant);
                context.Entry(tenant1).State = EntityState.Modified;
                context.SaveChanges();
                var data2 = tenantMapper.toDto(tenant1);
            }

            return tenant;
        }

        public TenantDTO deleteTenant(int id)
        {
            TenantDTO tenantDTO = new TenantDTO();
            using (var context = new HouseRentalSystemContext())
            {
                var tenantEntity = context.Tenants.SingleOrDefault(i => i.TenantId == id);

                if (tenantEntity != null)
                {
                    TenantMapper tenantMapper = new TenantMapper();
                    tenantDTO = tenantMapper.toDto(tenantEntity);

                    context.Tenants.Remove(tenantEntity);
                    context.SaveChanges();
                }
            }

            return tenantDTO;
        }
    }
 }
