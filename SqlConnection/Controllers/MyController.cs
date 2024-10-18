using Microsoft.AspNetCore.Mvc;

namespace SqlConnection.Controllers
{
    [Route("api/[Controller]")]
    public class MyController :ControllerBase
    {
        public string Get()
        {
            return "This is my controller"; 
        }
    }
}
