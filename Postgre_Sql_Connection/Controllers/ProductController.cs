using Microsoft.AspNetCore.Mvc;
using Postgre_Sql_Connection.Data;

namespace Postgre_Sql_Connection.Controllers
{
    
    public class ProductController : Controller
    {
        private readonly PostgreDbContext _context; 
        public ProductController(PostgreDbContext context)
        {
            _context = context;  
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult StringGet()
        {
            return Ok("This is my controller");
        }
    }
}
