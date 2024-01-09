using Microsoft.AspNetCore.Mvc;
using STMSApi.Models;
using STMSApi.Models.DTOs;

namespace STMSApi.Controllers
{
    [Route("api/VanillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return new List<VillaDTO> {
                new VillaDTO { Id = 1, Name = "Pool View"},
                new VillaDTO { Id = 2, Name = "Alif Mansion"}
            };
        }
    }
}
