using Microsoft.AspNetCore.Mvc;

namespace Tihair.MainWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MainController : Controller
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok("HomePage is here");
        }
    }
}
