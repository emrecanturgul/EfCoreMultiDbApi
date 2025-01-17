using Microsoft.AspNetCore.Mvc;

namespace SqlConnection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyController : ControllerBase
    {
        [HttpGet]
        public IActionResult StrGet()
        {
            return Ok("This is my controller"); 
        }
    }
}
