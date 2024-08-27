using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using Utility;
using Utility.DTOs;

namespace HouseManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseController : ControllerBase
    {
        HouseService service = new HouseService();
        [HttpGet("get")]
        public ResponseClass get()
        {
            return service.getHousesData();
        }

        [HttpPost("post")]
        public ResponseClass post(HouseDTO house)
        {
            return service.insertHouseData(house);
        }

        [HttpPut("put")]
        public ResponseClass put(HouseDTO house, int id)
        {
            return service.updateHouseData(house, id);
        }

        [HttpDelete("delete")]
        public ResponseClass delete(int id)
        {
            return service.deleteHouseData(id);
        }
    }
}
