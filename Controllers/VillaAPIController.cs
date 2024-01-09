using Microsoft.AspNetCore.Mvc;
using STMSApi.Data;
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
            return VillaStore.villaList;
        }
        [HttpGet("{id:int}")]
        public VillaDTO GetVilla(int id)
        {
            return VillaStore.villaList.FirstOrDefault(u => u.Id == id);
        }
    }
}
