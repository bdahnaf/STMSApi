using Microsoft.AspNetCore.Mvc;
using STMSApi.Models;

namespace STMSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Villa> GetVillas()
        {
            return new List<Villa> {
                new Villa { Id = 1, Name = "Pool View"},
                new Villa { Id = 2, Name = "Alif Mansion"}
            };
        }
    }
}
