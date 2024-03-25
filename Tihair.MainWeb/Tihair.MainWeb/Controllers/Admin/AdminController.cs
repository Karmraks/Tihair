using Microsoft.AspNetCore.Mvc;

namespace Tihair.MainWeb.Controllers.Admin;

[ApiController]
[Route("api/[controller]")]
public class AdminController : Controller
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("I am admin");
    }
}
