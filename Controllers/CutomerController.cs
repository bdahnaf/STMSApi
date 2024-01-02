using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STMSApi.Service;

namespace STMSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CutomerController : ControllerBase
    {
        private readonly ICustomerService service;

        public CutomerController(ICustomerService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var data = this.service.GetAll();
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }
    }
}
