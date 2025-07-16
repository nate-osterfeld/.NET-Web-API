using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace M10_Git.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        // GET: api/<NameController>
        [HttpGet]
        public IActionResult Get()
        {
            var result = new
            {
                name = "Nate Osterfeld"
            };

            return Ok(result);
        }
    }
}
