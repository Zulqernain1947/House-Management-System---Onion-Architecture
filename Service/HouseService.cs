using DatabaseAccess.Implementations;
using DatabaseAccess.Interfaces;
using Utility;
using Utility.DTOs;

namespace Service
{
    public class HouseService
    {
        IHMS _database = new HMSDA();
        public ResponseClass insertHouseData(HouseDTO house)
        {
            house = _database.insertHouse(house);
            if (house == null)
            {
                ResponseClass s1 = new ResponseClass();
                s1.result = null;
                s1.error_code = 3;
                return s1;

            }
            else
            {
                ResponseClass s1 = new ResponseClass();
                s1.result = house;
                s1.error_code = 1;
                return s1;
            }
        }

        public ResponseClass getHousesData()
        {
            List<HouseDTO> houses = new List<HouseDTO>();
            houses = _database.getAllHouses();
            if (houses == null)
            {
                ResponseClass s1 = new ResponseClass();
                s1.result = null;
                s1.error_code = 3;
                return s1;

            }
            else
            {
                ResponseClass s1 = new ResponseClass();
                s1.result = houses;
                s1.error_code = 1;
                return s1;
            }

        }

        public ResponseClass updateHouseData(HouseDTO house, int id)
        {
            house = _database.updateHouse(house, id);
            if (house == null)
            {
                ResponseClass s1 = new ResponseClass();
                s1.result = null;
                s1.error_code = 3;
                return s1;

            }
            else
            {
                ResponseClass s1 = new ResponseClass();
                s1.result = house;
                s1.error_code = 1;
                return s1;
            }
        }

        public ResponseClass deleteHouseData(int id)
        {
            var chk = _database.deleteHouse(id);
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