using HouseManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.DTOs;

namespace Utility.Mappers
{
    public class HouseMapper
    {
        public House toSql(HouseDTO model)
        {
            House house = new House();
            house.HouseId = model.HouseId;
            house.Address = model.Address;
            house.Bedrooms = model.Bedrooms;
            house.RentAmount = model.RentAmount;
            return house;
        }

        public HouseDTO toDto(House model)
        {
            HouseDTO house = new HouseDTO();
            house.HouseId = model.HouseId;
            house.Address = model.Address;
            house.Bedrooms = model.Bedrooms;
            house.RentAmount = model.RentAmount;
            return house;
        }
    }
}
