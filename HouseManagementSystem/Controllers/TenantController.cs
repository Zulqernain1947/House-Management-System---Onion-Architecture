using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using Utility.DTOs;
using Utility;

namespace HouseManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantController : ControllerBase
    {
       TenantService tenantService = new TenantService();
        [HttpGet("get")]
        public ResponseClass get()
        {
            return tenantService.getTenantsData();
        }

        [HttpPost("post")]
        public ResponseClass post(TenantDTO tenant)
        {
            return tenantService.insertTenantData(tenant);
        }

        [HttpPut("put")]
        public ResponseClass put(TenantDTO tenant, int id)
        {
            return tenantService.updateTenantData(tenant, id);
        }

        [HttpDelete("delete")]
        public ResponseClass delete(int id)
        {
            return tenantService.deleteTenantData(id);
        }
    }
}
